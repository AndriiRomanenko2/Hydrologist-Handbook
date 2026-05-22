using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Hydrologist_Handbook
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public abstract class BodyOfWater
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }

        protected BodyOfWater(string name)
        {
            Name = name;
        }

        public abstract double GetTotalAnnualFlow();
        public abstract double GetTotalBasinArea();
    }

    public class River : BodyOfWater
    {
        public double Length { get; set; }
        public double OwnAnnualFlow { get; set; }
        public double OwnBasinArea { get; set; }

        public BodyOfWater FlowsInto { get; set; }
        public string FlowsIntoName { get; set; }
        public string FlowsFromName { get; set; }

        public List<River> RiversThatFlowInto { get; set; } = new List<River>();

        public River(string name, double length, double flow, double area) : base(name)
        {
            Length = length;
            OwnAnnualFlow = flow;
            OwnBasinArea = area;
        }

        public override double GetTotalAnnualFlow()
        {
            double total = OwnAnnualFlow;
            foreach (var tributary in RiversThatFlowInto)
            {
                total += tributary.GetTotalAnnualFlow();
            }
            return total;
        }

        public override double GetTotalBasinArea()
        {
            double total = OwnBasinArea;
            foreach (var tributary in RiversThatFlowInto)
            {
                total += tributary.GetTotalBasinArea();
            }
            return total;
        }
    }
    public class Sea : BodyOfWater
    {
        public double Area { get; set; }
        public double AvgDepth { get; set; }
        public double MaxDepth { get; set; }
        public List<River> InflowingRivers { get; set; } = new List<River>();

        public Sea(string name, double area = 0, double avgDepth = 0, double maxDepth = 0) : base(name)
        {
            Area = area;
            AvgDepth = avgDepth;
            MaxDepth = maxDepth;
        }

        public override double GetTotalAnnualFlow()
        {
            double total = 0;
            foreach (var river in InflowingRivers)
            {
                total += river.GetTotalAnnualFlow();
            }
            return total;
        }

        public override double GetTotalBasinArea()
        {
            double total = 0;
            foreach (var river in InflowingRivers)
            {
                total += river.GetTotalBasinArea();
            }
            return total;
        }
    }
    public class Lake : Sea
    {
        public List<River> OutflowingRivers { get; set; } = new List<River>();

        public Lake(string name, double area = 0, double avgDepth = 0, double maxDepth = 0)
            : base(name, area, avgDepth, maxDepth) { }
    }
}