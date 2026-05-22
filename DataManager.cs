using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Hydrologist_Handbook
{
    public class DataManager
    {
        public List<River> Rivers { get; private set; } = new List<River>();
        public List<Lake> Lakes { get; private set; } = new List<Lake>();
        public List<Sea> Seas { get; private set; } = new List<Sea>();

        public void Load(string path)
        {
            Rivers.Clear();
            Seas.Clear();
            Lakes.Clear();

            XDocument doc = XDocument.Load(path);

            //Спочатку створюємо всі об'єкти без зв'язків
            foreach (var el in doc.Root.Element("Rivers").Elements("River"))
            {
                var river = new River(
                    name: el.Attribute("name").Value,
                    length: double.Parse(el.Attribute("length").Value, CultureInfo.InvariantCulture),
                    flow:   double.Parse(el.Attribute("flow").Value, CultureInfo.InvariantCulture),
                    area:   double.Parse(el.Attribute("area").Value, CultureInfo.InvariantCulture)
                );
                // flowsInto зберігаємо тимчасово як рядок
                river.FlowsIntoName = el.Attribute("flowsInto")?.Value;
                river.FlowsFromName = el.Attribute("flowsFrom")?.Value ?? "";
                river.ImagePath = el.Attribute("imagePath")?.Value ?? "";
                Rivers.Add(river);
            }

            foreach (var el in doc.Root.Element("Seas").Elements("Sea"))
            {
                var sea = new Sea(
                    el.Attribute("name").Value,
                    double.Parse(el.Attribute("area")?.Value ?? "0", CultureInfo.InvariantCulture),
                    double.Parse(el.Attribute("avgDepth")?.Value ?? "0", CultureInfo.InvariantCulture),
                    double.Parse(el.Attribute("maxDepth")?.Value ?? "0", CultureInfo.InvariantCulture)
                );
                sea.ImagePath = el.Attribute("imagePath")?.Value ?? "";
                Seas.Add(sea);
            }

            foreach (var el in doc.Root.Element("Lakes").Elements("Lake"))
            {
                var lake = new Lake(
                    el.Attribute("name").Value,
                    double.Parse(el.Attribute("area")?.Value ?? "0", CultureInfo.InvariantCulture),
                    double.Parse(el.Attribute("avgDepth")?.Value ?? "0", CultureInfo.InvariantCulture),
                    double.Parse(el.Attribute("maxDepth")?.Value ?? "0", CultureInfo.InvariantCulture)
                );
                lake.ImagePath = el.Attribute("imagePath")?.Value ?? "";
                Lakes.Add(lake);
            }

            // Тепер зв'язуємо об'єкти між собою
            foreach (var river in Rivers)
            {
                if (string.IsNullOrEmpty(river.FlowsIntoName)) continue;

                BodyOfWater target =
                    (BodyOfWater)Rivers.FirstOrDefault(r => r.Name == river.FlowsIntoName) ??
                    (BodyOfWater)Seas.FirstOrDefault(s => s.Name == river.FlowsIntoName) ??
                    (BodyOfWater)Lakes.FirstOrDefault(l => l.Name == river.FlowsIntoName);

                if (target == null) continue;

                river.FlowsInto = target;

                // Додаємо притоку до батьківського об'єкта
                if (target is River parentRiver)
                    parentRiver.RiversThatFlowInto.Add(river);
                else if (target is Lake lakeparent)
                    lakeparent.InflowingRivers.Add(river);
                else if (target is Sea sea)
                    sea.InflowingRivers.Add(river);
            }
        }
        public void Save(string path) 
        {
            var doc = new XDocument(
                new XElement("Hydrologist",
                    new XElement("Rivers",
                        Rivers.Select(r => new XElement("River",
                            new XAttribute("name", r.Name),
                            new XAttribute("length", r.Length.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("flow", r.OwnAnnualFlow.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("area", r.OwnBasinArea.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("flowsInto", r.FlowsIntoName ?? ""),
                            new XAttribute("flowsFrom", r.FlowsFromName ?? ""),
                            new XAttribute("imagePath", r.ImagePath ?? "")
                        ))
                    ),
                    new XElement("Seas",
                        Seas.Select(s => new XElement("Sea",
                            new XAttribute("name", s.Name),
                            new XAttribute("area", s.Area.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("avgDepth", s.AvgDepth.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("maxDepth", s.MaxDepth.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("imagePath", s.ImagePath ?? "")
                        ))
                    ),
                    new XElement("Lakes",
                        Lakes.Select(l => new XElement("Lake",
                            new XAttribute("name", l.Name),
                            new XAttribute("area", l.Area.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("avgDepth", l.AvgDepth.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("maxDepth", l.MaxDepth.ToString(CultureInfo.InvariantCulture)),
                            new XAttribute("imagePath", l.ImagePath ?? "")
                        ))
                    )
                )
            );
            doc.Save(path);
        }

        public void RebuildLinks()
        {
            foreach (var r in Rivers)
                r.RiversThatFlowInto.Clear();

            foreach (var s in Seas)
                s.InflowingRivers.Clear();

            foreach (var l in Lakes)
            {
                l.InflowingRivers.Clear();
                l.OutflowingRivers.Clear();
            }

            foreach (var river in Rivers)
            {
                if (string.IsNullOrEmpty(river.FlowsIntoName)) continue;

                BodyOfWater target =
                    (BodyOfWater)Rivers.FirstOrDefault(r => r.Name == river.FlowsIntoName) ??
                    (BodyOfWater)Seas.FirstOrDefault(s => s.Name == river.FlowsIntoName) ??
                    (BodyOfWater)Lakes.FirstOrDefault(l => l.Name == river.FlowsIntoName);

                if (target == null) continue;

                river.FlowsInto = target;

                if (target is River parentRiver)
                    parentRiver.RiversThatFlowInto.Add(river);
                else if (target is Lake lakeparent)
                    lakeparent.InflowingRivers.Add(river);
                else if (target is Sea sea)
                    sea.InflowingRivers.Add(river);
            }

            foreach (var river in Rivers)
            {
                if (string.IsNullOrEmpty(river.FlowsFromName)) continue;
                var lake = Lakes.FirstOrDefault(l => l.Name == river.FlowsFromName);
                if (lake != null)
                    lake.OutflowingRivers.Add(river);
            }
        }
    }
}
