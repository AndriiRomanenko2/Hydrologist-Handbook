using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydrologist_Handbook
{
    public partial class MainForm : Form
    {
        private DataManager dataManager = new DataManager();
        private string dataPath;
        private bool isDirty = false; //If the changes were saved or not

        //Files will be deleted after the deltion process was cofirmed and saved
        private List<string> filesToDelete = new List<string>(); 

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            SetupListView();
            SetupTabs();
            PopulateList();
            SetupSearchPlaceholder();

            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            AddButton.Click += AddButton_Click;
            RedactButton.Click += RedactButton_Click;
            DeleteButton.Click += DeleteButton_Click;
            Button_Save.Click += SaveButton_Click;
            Button_Load.Click += LoadButton_Click;
            TextBox_Search.TextChanged += TextBox_Search_TextChanged;
            FormClosing += MainForm_FormClosing;
        }

        private void LoadData()
        {
            dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bodies_of_water.xml");
            dataManager.Load(dataPath);
            MessageBox.Show("Було завантажено демо-файл за замовчуванням.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MarkAsChanged() // For when any change was made, 
        {
            isDirty = true;
            this.Text = "Hydrologist Handbook*";
        }

        private bool CheckUnsavedChanges()
        {
            if (isDirty)
            {
                var result = MessageBox.Show("Є незбережені зміни. Зберегти їх перед продовженням?",
                                             "Збереження", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveButton_Click(this, EventArgs.Empty); // Викликаємо ваше збереження
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    return false; // Скасовуємо дію
                }
            }
            return true; // Змін немає або користувач відмовився зберігати
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                var result = MessageBox.Show("Зберегти зміни перед виходом?", "Вихід", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveButton_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SetupListView()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Назва", 180);
            listView1.Columns.Add("Довжина", 130);
        }

        private void SetupTabs()
        {
            TabPage_Rivers.Text = "Річки";
            TabPage_Lakes.Text = "Озера";
            TabPage_Seas.Text = "Моря";
        }

        private void PopulateList()
        {
            TextBox_Search.Text = "Пошук";
            TextBox_Search.ForeColor = System.Drawing.Color.Gray;

            listView1.Items.Clear();
            ClearDetails();

            int tab = TabControl.SelectedIndex;

            if (tab == 0) // Річки
            {
                listView1.Columns[1].Text = "Довжина";
                listView1.Columns[1].Width = 130;

                foreach (var river in dataManager.Rivers)
                {
                    var item = new ListViewItem(river.Name);
                    item.SubItems.Add(river.Length.ToString());
                    item.Tag = river;
                    listView1.Items.Add(item);
                }
            }
            else if (tab == 1) // Озера
            {
                listView1.Columns[1].Text = "Річок впадає";
                foreach (var lake in dataManager.Lakes)
                {
                    var item = new ListViewItem(lake.Name);
                    item.SubItems.Add(lake.InflowingRivers.Count.ToString());
                    item.Tag = lake;
                    listView1.Items.Add(item);
                }
            }
            else // Моря
            {
                listView1.Columns[1].Text = "Річок впадає";
                foreach (var sea in dataManager.Seas)
                {
                    var item = new ListViewItem(sea.Name);
                    item.SubItems.Add(sea.InflowingRivers.Count.ToString());
                    item.Tag = sea;
                    listView1.Items.Add(item);
                }
            }
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_Search.Text == "Пошук") return;
            string query = TextBox_Search.Text.Trim().ToLower();

            listView1.Items.Clear();

            int tab = TabControl.SelectedIndex;

            if (tab == 0)
            {
                foreach (var river in dataManager.Rivers)
                {
                    if (river.Name.ToLower().Contains(query))
                    {
                        var item = new ListViewItem(river.Name);
                        item.SubItems.Add(river.Length.ToString());
                        item.Tag = river;
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (tab == 1)
            {
                foreach (var lake in dataManager.Lakes)
                {
                    if (lake.Name.ToLower().Contains(query))
                    {
                        var item = new ListViewItem(lake.Name);
                        item.SubItems.Add(lake.InflowingRivers.Count.ToString());
                        item.Tag = lake;
                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var sea in dataManager.Seas)
                {
                    if (sea.Name.ToLower().Contains(query))
                    {
                        var item = new ListViewItem(sea.Name);
                        item.SubItems.Add(sea.InflowingRivers.Count.ToString());
                        item.Tag = sea;
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void SetupSearchPlaceholder()
        {
            TextBox_Search.Text = "Пошук";
            TextBox_Search.ForeColor = System.Drawing.Color.DimGray;

            TextBox_Search.Enter += (s, e) =>
            {
                if (TextBox_Search.Text == "Пошук")
                {
                    TextBox_Search.Text = "";
                    TextBox_Search.ForeColor = System.Drawing.Color.Black;
                }
            };

            TextBox_Search.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(TextBox_Search.Text))
                {
                    TextBox_Search.Text = "Пошук";
                    TextBox_Search.ForeColor = System.Drawing.Color.DimGray;
                }
            };
        }

        private void ShowDetails(BodyOfWater obj)
        {
            Label_Name.Text = obj.Name;

            if (obj is River river)
            {
                Label_LengthTitle.Visible = true;
                Label_LengthVariable.Visible = true;
                Label_FlowsIntoTitle.Visible = true;
                Label_FlowsIntoVariable.Visible = true;
                Label_TributariesTitle.Visible = true;
                Label_TributariesVariable.Visible = true;

                Label_LengthVariable.Text = $"{river.Length} км";
                Label_AreaVariable.Text = $"{river.OwnBasinArea} км²";
                Label_FlowVariable.Text = $"{river.OwnAnnualFlow} км³/рік";
                Label_FlowsIntoVariable.Text = river.FlowsInto?.Name ?? "невідомо";

                var tributaryNames = river.RiversThatFlowInto.Count > 0
                    ? string.Join(", ", river.RiversThatFlowInto.Select(r => r.Name))
                    : "немає";
                Label_TributariesVariable.Text = tributaryNames;

                Label_TotalFlowText.Text = $"Сумарний стік: ";
                Label_TotalFlowVar.Text = $"{river.GetTotalAnnualFlow()} км³/рік";
                Label_TotalAreaText.Text = $"Сумарна площа: ";
                Label_TotalAreaVar.Text = $"{river.GetTotalBasinArea()} км²";
            }                           
            else // Sea або Lake
            {
                Label_LengthTitle.Visible = false;
                Label_LengthVariable.Visible = false;
                Label_FlowsIntoTitle.Visible = false;
                Label_FlowsIntoVariable.Visible = false;
                Label_TributariesTitle.Visible = false;
                Label_TributariesVariable.Visible = false;

                if (obj is Lake lake)
                {
                    Label_AreaTitle.Text = "Площа:";
                    Label_AreaVariable.Text = lake.Area > 0 ? $"{lake.Area:N0} км²" : "—";

                    Label_FlowTitle.Text = "Сер. глибина:";
                    Label_FlowVariable.Text = lake.AvgDepth > 0 ? $"{lake.AvgDepth} м" : "—";

                    Label_TotalFlowText.Text = $"Макс. глибина: ";
                    Label_TotalFlowVar.Text = $"{(lake.MaxDepth > 0 ? lake.MaxDepth + " м" : "—")}";
                    Label_TotalAreaText.Text = $"Площа басейну: ";
                    Label_TotalAreaVar.Text = $"{lake.GetTotalBasinArea():N0} км²";

                    Label_TributariesTitle.Visible = true;
                    Label_TributariesVariable.Visible = true;
                    Label_TributariesTitle.Text = "Впадають:";
                    Label_TributariesVariable.Text = lake.InflowingRivers.Count > 0
                        ? string.Join(", ", lake.InflowingRivers.Select(r => r.Name))
                        : "немає";

                    Label_FlowsIntoTitle.Visible = true;
                    Label_FlowsIntoVariable.Visible = true;
                    Label_FlowsIntoTitle.Text = "Витікають:";
                    Label_FlowsIntoVariable.Text = lake.OutflowingRivers.Count > 0
                        ? string.Join(", ", lake.OutflowingRivers.Select(r => r.Name))
                        : "немає";
                }
                else if (obj is Sea sea)
                {
                    Label_AreaTitle.Text = "Площа:";
                    Label_AreaVariable.Text = sea.Area > 0 ? $"{sea.Area:N0} км²" : "—";

                    Label_FlowTitle.Text = "Сер. глибина:";
                    Label_FlowVariable.Text = sea.AvgDepth > 0 ? $"{sea.AvgDepth} м" : "—";

                    Label_TotalFlowText.Text = $"Макс. глибина: ";
                    Label_TotalFlowVar.Text =  $"{(sea.MaxDepth > 0 ? sea.MaxDepth + " м" : "—")}";
                    Label_TotalAreaText.Text = $"Площа басейну: ";
                    Label_TotalAreaVar.Text =  $"{sea.GetTotalBasinArea():N0} км²";

                    Label_TributariesTitle.Visible = true;
                    Label_TributariesVariable.Visible = true;
                    Label_TributariesTitle.Text = "Впадають:";
                    Label_TributariesVariable.Text = sea.InflowingRivers.Count > 0
                        ? string.Join(", ", sea.InflowingRivers.Select(r => r.Name))
                        : "немає";
                }
            }

            LoadImage(obj.ImagePath);
        }

        private void LoadImage(string imagePath)
        {
            if (PictureBox_Image == null) return;

            PictureBox_Image.Image = null;

            if (string.IsNullOrEmpty(imagePath)) return;

            string fullPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..",
                imagePath
            );

            if (!File.Exists(fullPath)) return;

            try
            {
                byte[] bytes = File.ReadAllBytes(fullPath);
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    PictureBox_Image.Image = Image.FromStream(ms);
                }
            }
            catch
            {
                PictureBox_Image.Image = null;
            }
        }

        private void ClearDetails()
        {
            Label_Name.Text = "—";
            Label_LengthTitle.Text = "Довжина:";
            Label_LengthVariable.Text = "—";
            Label_AreaTitle.Text = "Площа басейну:";
            Label_AreaVariable.Text = "—";
            Label_FlowTitle.Text = "Річний стік:";
            Label_FlowVariable.Text = "—";
            Label_FlowsIntoTitle.Text = "Впадає в:";
            Label_FlowsIntoVariable.Text = "—";
            Label_TributariesTitle.Text = "Притоки:";
            Label_TributariesVariable.Text = "—";
            Label_TotalFlowText.Text = "Сумарний стік:";
            Label_TotalFlowVar.Text = "—";
            Label_TotalAreaText.Text = "Сумарна площа:";
            Label_TotalAreaVar.Text = "—";

            Label_LengthTitle.Visible = true;
            Label_LengthVariable.Visible = true;
            Label_FlowsIntoTitle.Visible = true;
            Label_FlowsIntoVariable.Visible = true;
            Label_TributariesTitle.Visible = true;
            Label_TributariesVariable.Visible = true;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var obj = listView1.SelectedItems[0].Tag as BodyOfWater;
            if (obj != null) ShowDetails(obj);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new RedactForm(dataManager))
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                if (form.ResultObject is River river)
                    dataManager.Rivers.Add(river);
                else if (form.ResultObject is Lake lake)
                    dataManager.Lakes.Add(lake);
                else if (form.ResultObject is Sea sea)
                    dataManager.Seas.Add(sea);

                dataManager.RebuildLinks();

                MarkAsChanged();
                PopulateList();
            }
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Оберіть об'єкт для редагування");
                return;
            }

            var obj = listView1.SelectedItems[0].Tag as BodyOfWater;

            using (var form = new RedactForm(dataManager, obj))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataManager.RebuildLinks();
                    MarkAsChanged();
                    PopulateList();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Оберіть об'єкт для видалення");
                return;
            }

            var obj = listView1.SelectedItems[0].Tag as BodyOfWater;
            var confirm = MessageBox.Show(
                $"Видалити '{obj.Name}'?",
                "Підтвердження",
                MessageBoxButtons.YesNo
            );

            if (!string.IsNullOrEmpty(obj.ImagePath))
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", obj.ImagePath);
                if (File.Exists(fullPath))
                {
                    filesToDelete.Add(fullPath);
                }
            }

            if (confirm != DialogResult.Yes) return;

            if (obj is River river)
                dataManager.Rivers.Remove(river);
            else if (obj is Lake lake)
                dataManager.Lakes.Remove(lake);
            else if (obj is Sea sea)
                dataManager.Seas.Remove(sea);

            dataManager.RebuildLinks();
            MarkAsChanged();
            PopulateList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                sfd.Title = "Зберегти файл як";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    dataPath = sfd.FileName;
                    dataManager.Save(dataPath);

                    // After confirmed save delete physical items
                    foreach (string path in filesToDelete)
                    {
                        if (File.Exists(path))
                        {
                            try { File.Delete(path); } catch { }
                        }
                    }
                    filesToDelete.Clear();

                    isDirty = false;
                    this.Text = "Hydrologist Handbook";
                    MessageBox.Show("Дані успішно збережено!");
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (!CheckUnsavedChanges()) return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dataPath = openFileDialog.FileName;
                        dataManager.Load(dataPath);
                        dataManager.RebuildLinks();

                        isDirty = false;
                        this.Text = "Hydrologist Handbook";

                        PopulateList();
                        MessageBox.Show("Дані успішно завантажено!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при завантаженні файлу: {ex.Message}");
                    }
                }
            }
        }
    }
}