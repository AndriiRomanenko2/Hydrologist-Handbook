using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydrologist_Handbook
{
    public partial class RedactForm : Form
    {
        private DataManager _dataManager;
        private BodyOfWater _editingObject; //null - adding a new one
        private string _selectedImagePath = "";

        public BodyOfWater ResultObject{ get; private set; }

        //Adding
        public RedactForm(DataManager dataManager)
        {
            InitializeComponent();
            _dataManager = dataManager;
            this.Text = "Додати об'єкт";
            SetupTypeComboBox();
            PopulateFlowsInto();
            PopulateFlowsFrom();
            SetupEvents();

            Button_ImageSelect.Text = "Вибрати картинку";
            Button_ImageSelect.Click += Button_ImageSelect_Click;

            // Якщо редагування і картинка вже є
            if (_editingObject != null && !string.IsNullOrEmpty(_editingObject.ImagePath))
            {
                Label_ImagePath.Text = _editingObject.ImagePath;
                LoadPreview(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", _editingObject.ImagePath));
            }

            ComboBox_ObjectType.SelectedIndex = 0;
        }

        //Redacting
        public RedactForm(DataManager dataManager, BodyOfWater obj)
        {
            InitializeComponent();
            _dataManager = dataManager;
            _editingObject = obj;
            this.Text = "Редагувати об'єкт";
            SetupTypeComboBox();
            PopulateFlowsInto();
            PopulateFlowsFrom();
            SetupEvents();

            Button_ImageSelect.Text = "Вибрати картинку";
            Button_ImageSelect.Click += Button_ImageSelect_Click;

            // Якщо редагування і картинка вже є
            if (_editingObject != null && !string.IsNullOrEmpty(_editingObject.ImagePath))
            {
                Label_ImagePath.Text = _editingObject.ImagePath;
                LoadPreview(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", _editingObject.ImagePath));
            }

            FillFields(obj);
        }

        private void SetupTypeComboBox()
        {
            ComboBox_ObjectType.Items.Clear();
            ComboBox_ObjectType.Items.Add("Річка");
            ComboBox_ObjectType.Items.Add("Озеро");
            ComboBox_ObjectType.Items.Add("Море");
            ComboBox_ObjectType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PopulateFlowsInto()
        {
            ComboBox_FlowsInto.Items.Clear();
            ComboBox_FlowsInto.Items.Add(""); // порожній варіант
            foreach (var r in _dataManager.Rivers)
                ComboBox_FlowsInto.Items.Add(r.Name);
            foreach (var s in _dataManager.Seas)
                ComboBox_FlowsInto.Items.Add(s.Name);
            foreach (var l in _dataManager.Lakes)
                ComboBox_FlowsInto.Items.Add(l.Name);
        }

        private void PopulateFlowsFrom()
        {
            ComboBox_FlowsFrom.Items.Clear();
            ComboBox_FlowsFrom.Items.Add("");
            foreach (var l in _dataManager.Lakes)
                ComboBox_FlowsFrom.Items.Add(l.Name);
        }

        private void FillFields(BodyOfWater obj)
        {
            TextBox_Name.Text = obj.Name;

            if (obj is River river)
            {
                ComboBox_ObjectType.SelectedIndex = 0;
                TextBox_Length.Text = river.Length.ToString(CultureInfo.InvariantCulture);
                TextBox_Flow.Text = river.OwnAnnualFlow.ToString(CultureInfo.InvariantCulture);
                TextBox_Area.Text = river.OwnBasinArea.ToString(CultureInfo.InvariantCulture);
                if (!string.IsNullOrEmpty(river.FlowsIntoName))
                    ComboBox_FlowsInto.SelectedItem = river.FlowsIntoName;
                if (!string.IsNullOrEmpty(river.FlowsFromName))
                    ComboBox_FlowsFrom.SelectedItem = river.FlowsFromName;
            }
            else if (obj is Lake lake)
            {
                ComboBox_ObjectType.SelectedIndex = 1;
                TextBox_SeaArea.Text = lake.Area.ToString(CultureInfo.InvariantCulture);
                TextBox_AvgDepth.Text = lake.AvgDepth.ToString(CultureInfo.InvariantCulture);
                TextBox_MaxDepth.Text = lake.MaxDepth.ToString(CultureInfo.InvariantCulture);
            }
            else if (obj is Sea sea)
            {
                ComboBox_ObjectType.SelectedIndex = 2;
                TextBox_SeaArea.Text = sea.Area.ToString(CultureInfo.InvariantCulture);
                TextBox_AvgDepth.Text = sea.AvgDepth.ToString(CultureInfo.InvariantCulture);
                TextBox_MaxDepth.Text = sea.MaxDepth.ToString(CultureInfo.InvariantCulture);
            }

            ComboBox_ObjectType.Enabled = false;
        }

        private void SetupEvents()
        {
            ComboBox_ObjectType.SelectedIndexChanged += ComboBox_ObjectType_SelectedIndexChanged;
            Button_SubmitRedact.Click += Button_SubmitRedact_Click;
            Button_CancelRedact.Click += Button_CancelRedact_Click;
        }

        private void ShowRiverFields()
        {
            Label_Length.Visible = true;
            TextBox_Length.Visible = true;
            Label_Flow.Visible = true;
            TextBox_Flow.Visible = true;
            Label_BasinArea.Visible = true;
            TextBox_Area.Visible = true;
            Label_FlowsInto.Visible = true;
            ComboBox_FlowsInto.Visible = true;
            Label_FlowFrom.Visible = true;
            ComboBox_FlowsFrom.Visible = true;

            Label_SeaArea.Visible = false;
            TextBox_SeaArea.Visible = false;
            Label_AvgDepth.Visible = false;
            TextBox_AvgDepth.Visible = false;
            Label_MaxDepth.Visible = false;
            TextBox_MaxDepth.Visible = false;
        }

        private void ShowSeaLakeFields()
        {
            Label_Length.Visible = false;
            TextBox_Length.Visible = false;
            Label_Flow.Visible = false;
            TextBox_Flow.Visible = false;
            Label_BasinArea.Visible = false;
            TextBox_Area.Visible = false;
            Label_FlowsInto.Visible = false;
            ComboBox_FlowsInto.Visible = false;
            Label_FlowFrom.Visible = false;
            ComboBox_FlowsFrom.Visible = false;

            Label_SeaArea.Visible = true;
            TextBox_SeaArea.Visible = true;
            Label_AvgDepth.Visible = true;
            TextBox_AvgDepth.Visible = true;
            Label_MaxDepth.Visible = true;
            TextBox_MaxDepth.Visible = true;
        }

        private void ComboBox_ObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_ObjectType.SelectedIndex == 0)
                ShowRiverFields();
            else
                ShowSeaLakeFields();
        }

        private void Button_SubmitRedact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_Name.Text))
            {
                MessageBox.Show("Введіть назву");
                return;
            }

            int type = ComboBox_ObjectType.SelectedIndex;

            if (type == 0) // Річка
            {
                if (!double.TryParse(TextBox_Length.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double length) || length <= 0)
                { MessageBox.Show("Введіть коректну довжину"); return; }

                if (!double.TryParse(TextBox_Flow.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double flow) || flow <= 0)
                { MessageBox.Show("Введіть коректний річний стік"); return; }

                if (!double.TryParse(TextBox_Area.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double area) || area <= 0)
                { MessageBox.Show("Введіть коректну площу басейну"); return; }

                if (_editingObject is River editRiver)
                {
                    editRiver.Name = TextBox_Name.Text.Trim();
                    editRiver.Length = length;
                    editRiver.OwnAnnualFlow = flow;
                    editRiver.OwnBasinArea = area;
                    editRiver.FlowsIntoName = ComboBox_FlowsInto.SelectedItem?.ToString();
                    editRiver.FlowsFromName = ComboBox_FlowsFrom.SelectedItem?.ToString() ?? "";
                    ResultObject = editRiver;
                }
                else
                {
                    var river = new River(TextBox_Name.Text.Trim(), length, flow, area);
                    river.FlowsIntoName = ComboBox_FlowsInto.SelectedItem?.ToString();
                    river.FlowsFromName = ComboBox_FlowsFrom.SelectedItem?.ToString() ?? "";
                    ResultObject = river;
                }
            }
            else // Море або Озеро
            {
                double.TryParse(TextBox_SeaArea.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double seaArea);
                double.TryParse(TextBox_AvgDepth.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double avgDepth);
                double.TryParse(TextBox_MaxDepth.Text, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double maxDepth);

                string name = TextBox_Name.Text.Trim();

                if (type == 1) // Озеро
                {
                    if (_editingObject is Lake editLake)
                    {
                        editLake.Name = name;
                        editLake.Area = seaArea;
                        editLake.AvgDepth = avgDepth;
                        editLake.MaxDepth = maxDepth;
                        ResultObject = editLake;
                    }
                    else
                        ResultObject = new Lake(name, seaArea, avgDepth, maxDepth);
                }
                else // Море (type == 2)
                {
                    if (_editingObject is Sea editSea)
                    {
                        editSea.Name = name;
                        editSea.Area = seaArea;
                        editSea.AvgDepth = avgDepth;
                        editSea.MaxDepth = maxDepth;
                        ResultObject = editSea;
                    }
                    else
                        ResultObject = new Sea(name, seaArea, avgDepth, maxDepth);
                }
            }

            if (!string.IsNullOrEmpty(_selectedImagePath))
            {
                string objectType = ComboBox_ObjectType.SelectedIndex == 0 ? "Rivers" :
                                    ComboBox_ObjectType.SelectedIndex == 1 ? "Lakes" : "Seas";
                string relativePath = CopyImageToProject(_selectedImagePath, objectType, TextBox_Name.Text.Trim());
                ResultObject.ImagePath = relativePath;
            }
            else if (_editingObject != null)
            {
                // Зберігаємо стару картинку якщо нову не обрали
                ResultObject.ImagePath = _editingObject.ImagePath;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button_CancelRedact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button_ImageSelect_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Оберіть картинку";
                dialog.Filter = "Зображення|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK) return;

                _selectedImagePath = dialog.FileName;
                Label_ImagePath.Text = Path.GetFileName(_selectedImagePath);
                LoadPreview(_selectedImagePath);
            }
        }

        private void LoadPreview(string fullPath)
        {
            if (!File.Exists(fullPath)) return;
            try
            {
                byte[] bytes = File.ReadAllBytes(fullPath);
                using (var ms = new System.IO.MemoryStream(bytes))
                    PictureBox_PreviewBox.Image = Image.FromStream(ms);
            }
            catch { PictureBox_PreviewBox.Image = null; }
        }

        private string CopyImageToProject(string sourcePath, string objectType, string objectName)
        {
            // Визначаємо папку залежно від типу
            string folder = objectType == "Rivers" ? "Rivers" :
                            objectType == "Lakes" ? "Lakes" : "Seas";

            string projectRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..");
            string targetDir = Path.Combine(projectRoot, "Images", folder);

            Directory.CreateDirectory(targetDir);

            // Ім'я файлу = назва об'єкта (замінюємо пробіли і спецсимволи)
            string ext = Path.GetExtension(sourcePath);
            string safeName = string.Concat(objectName.Split(Path.GetInvalidFileNameChars()))
                                   .Replace(" ", "_").ToLower();
            string fileName = safeName + ext;
            string targetPath = Path.Combine(targetDir, fileName);

            File.Copy(sourcePath, targetPath, overwrite: true);

            // Повертаємо відносний шлях для збереження в XML
            return Path.Combine("Images", folder, fileName);
        }
    }
}