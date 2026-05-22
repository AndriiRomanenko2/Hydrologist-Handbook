namespace Hydrologist_Handbook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage_Rivers = new System.Windows.Forms.TabPage();
            this.TabPage_Lakes = new System.Windows.Forms.TabPage();
            this.TabPage_Seas = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Label_TributariesVariable = new System.Windows.Forms.Label();
            this.Label_FlowsIntoVariable = new System.Windows.Forms.Label();
            this.Label_FlowVariable = new System.Windows.Forms.Label();
            this.Label_AreaVariable = new System.Windows.Forms.Label();
            this.Label_LengthVariable = new System.Windows.Forms.Label();
            this.Label_TotalAreaText = new System.Windows.Forms.Label();
            this.Label_TotalFlowText = new System.Windows.Forms.Label();
            this.Label_TributariesTitle = new System.Windows.Forms.Label();
            this.Label_FlowsIntoTitle = new System.Windows.Forms.Label();
            this.Label_AreaTitle = new System.Windows.Forms.Label();
            this.Label_FlowTitle = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Panel_ButtonsBackground = new System.Windows.Forms.Panel();
            this.RedactButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Label_LengthTitle = new System.Windows.Forms.Label();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.Label_TotalFlowVar = new System.Windows.Forms.Label();
            this.Label_TotalAreaVar = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Load = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.Panel_ButtonsBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage_Rivers);
            this.TabControl.Controls.Add(this.TabPage_Lakes);
            this.TabControl.Controls.Add(this.TabPage_Seas);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1904, 29);
            this.TabControl.TabIndex = 0;
            // 
            // TabPage_Rivers
            // 
            this.TabPage_Rivers.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Rivers.Name = "TabPage_Rivers";
            this.TabPage_Rivers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Rivers.Size = new System.Drawing.Size(1896, 3);
            this.TabPage_Rivers.TabIndex = 0;
            this.TabPage_Rivers.Text = "Rivers";
            this.TabPage_Rivers.UseVisualStyleBackColor = true;
            // 
            // TabPage_Lakes
            // 
            this.TabPage_Lakes.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Lakes.Name = "TabPage_Lakes";
            this.TabPage_Lakes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Lakes.Size = new System.Drawing.Size(1896, 3);
            this.TabPage_Lakes.TabIndex = 1;
            this.TabPage_Lakes.Text = "Lakes";
            this.TabPage_Lakes.UseVisualStyleBackColor = true;
            // 
            // TabPage_Seas
            // 
            this.TabPage_Seas.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Seas.Name = "TabPage_Seas";
            this.TabPage_Seas.Size = new System.Drawing.Size(1896, 3);
            this.TabPage_Seas.TabIndex = 2;
            this.TabPage_Seas.Text = "Seas";
            this.TabPage_Seas.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 1012);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel_Background.Controls.Add(this.Button_Load);
            this.Panel_Background.Controls.Add(this.Button_Save);
            this.Panel_Background.Controls.Add(this.Label_TotalAreaVar);
            this.Panel_Background.Controls.Add(this.Label_TotalFlowVar);
            this.Panel_Background.Controls.Add(this.PictureBox_Image);
            this.Panel_Background.Controls.Add(this.Label_TributariesVariable);
            this.Panel_Background.Controls.Add(this.Label_FlowsIntoVariable);
            this.Panel_Background.Controls.Add(this.Label_FlowVariable);
            this.Panel_Background.Controls.Add(this.Label_AreaVariable);
            this.Panel_Background.Controls.Add(this.Label_LengthVariable);
            this.Panel_Background.Controls.Add(this.Label_TotalAreaText);
            this.Panel_Background.Controls.Add(this.Label_TotalFlowText);
            this.Panel_Background.Controls.Add(this.Label_TributariesTitle);
            this.Panel_Background.Controls.Add(this.Label_FlowsIntoTitle);
            this.Panel_Background.Controls.Add(this.Label_AreaTitle);
            this.Panel_Background.Controls.Add(this.Label_FlowTitle);
            this.Panel_Background.Controls.Add(this.Label_Name);
            this.Panel_Background.Controls.Add(this.Panel_ButtonsBackground);
            this.Panel_Background.Controls.Add(this.Label_LengthTitle);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_Background.Location = new System.Drawing.Point(360, 29);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(1544, 1012);
            this.Panel_Background.TabIndex = 2;
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_Image.Location = new System.Drawing.Point(791, 50);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(700, 700);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 15;
            this.PictureBox_Image.TabStop = false;
            // 
            // Label_TributariesVariable
            // 
            this.Label_TributariesVariable.AutoSize = true;
            this.Label_TributariesVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TributariesVariable.ForeColor = System.Drawing.Color.Black;
            this.Label_TributariesVariable.Location = new System.Drawing.Point(250, 350);
            this.Label_TributariesVariable.Name = "Label_TributariesVariable";
            this.Label_TributariesVariable.Size = new System.Drawing.Size(57, 24);
            this.Label_TributariesVariable.TabIndex = 14;
            this.Label_TributariesVariable.Text = "None";
            // 
            // Label_FlowsIntoVariable
            // 
            this.Label_FlowsIntoVariable.AutoSize = true;
            this.Label_FlowsIntoVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FlowsIntoVariable.ForeColor = System.Drawing.Color.Black;
            this.Label_FlowsIntoVariable.Location = new System.Drawing.Point(250, 300);
            this.Label_FlowsIntoVariable.Name = "Label_FlowsIntoVariable";
            this.Label_FlowsIntoVariable.Size = new System.Drawing.Size(57, 24);
            this.Label_FlowsIntoVariable.TabIndex = 13;
            this.Label_FlowsIntoVariable.Text = "None";
            // 
            // Label_FlowVariable
            // 
            this.Label_FlowVariable.AutoSize = true;
            this.Label_FlowVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FlowVariable.ForeColor = System.Drawing.Color.Black;
            this.Label_FlowVariable.Location = new System.Drawing.Point(250, 400);
            this.Label_FlowVariable.Name = "Label_FlowVariable";
            this.Label_FlowVariable.Size = new System.Drawing.Size(57, 24);
            this.Label_FlowVariable.TabIndex = 12;
            this.Label_FlowVariable.Text = "None";
            // 
            // Label_AreaVariable
            // 
            this.Label_AreaVariable.AutoSize = true;
            this.Label_AreaVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_AreaVariable.ForeColor = System.Drawing.Color.Black;
            this.Label_AreaVariable.Location = new System.Drawing.Point(250, 200);
            this.Label_AreaVariable.Name = "Label_AreaVariable";
            this.Label_AreaVariable.Size = new System.Drawing.Size(57, 24);
            this.Label_AreaVariable.TabIndex = 11;
            this.Label_AreaVariable.Text = "None";
            // 
            // Label_LengthVariable
            // 
            this.Label_LengthVariable.AutoSize = true;
            this.Label_LengthVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_LengthVariable.ForeColor = System.Drawing.Color.Black;
            this.Label_LengthVariable.Location = new System.Drawing.Point(250, 150);
            this.Label_LengthVariable.Name = "Label_LengthVariable";
            this.Label_LengthVariable.Size = new System.Drawing.Size(57, 24);
            this.Label_LengthVariable.TabIndex = 10;
            this.Label_LengthVariable.Text = "None";
            // 
            // Label_TotalAreaText
            // 
            this.Label_TotalAreaText.AutoSize = true;
            this.Label_TotalAreaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TotalAreaText.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalAreaText.Location = new System.Drawing.Point(80, 250);
            this.Label_TotalAreaText.Name = "Label_TotalAreaText";
            this.Label_TotalAreaText.Size = new System.Drawing.Size(96, 24);
            this.Label_TotalAreaText.TabIndex = 9;
            this.Label_TotalAreaText.Text = "Total Area";
            // 
            // Label_TotalFlowText
            // 
            this.Label_TotalFlowText.AutoSize = true;
            this.Label_TotalFlowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TotalFlowText.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalFlowText.Location = new System.Drawing.Point(81, 450);
            this.Label_TotalFlowText.Name = "Label_TotalFlowText";
            this.Label_TotalFlowText.Size = new System.Drawing.Size(97, 24);
            this.Label_TotalFlowText.TabIndex = 8;
            this.Label_TotalFlowText.Text = "Total Flow";
            // 
            // Label_TributariesTitle
            // 
            this.Label_TributariesTitle.AutoSize = true;
            this.Label_TributariesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TributariesTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_TributariesTitle.Location = new System.Drawing.Point(80, 350);
            this.Label_TributariesTitle.Name = "Label_TributariesTitle";
            this.Label_TributariesTitle.Size = new System.Drawing.Size(98, 24);
            this.Label_TributariesTitle.TabIndex = 7;
            this.Label_TributariesTitle.Text = "Tributaries";
            // 
            // Label_FlowsIntoTitle
            // 
            this.Label_FlowsIntoTitle.AutoSize = true;
            this.Label_FlowsIntoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FlowsIntoTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_FlowsIntoTitle.Location = new System.Drawing.Point(80, 300);
            this.Label_FlowsIntoTitle.Name = "Label_FlowsIntoTitle";
            this.Label_FlowsIntoTitle.Size = new System.Drawing.Size(95, 24);
            this.Label_FlowsIntoTitle.TabIndex = 6;
            this.Label_FlowsIntoTitle.Text = "Flows Into";
            // 
            // Label_AreaTitle
            // 
            this.Label_AreaTitle.AutoSize = true;
            this.Label_AreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_AreaTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_AreaTitle.Location = new System.Drawing.Point(80, 200);
            this.Label_AreaTitle.Name = "Label_AreaTitle";
            this.Label_AreaTitle.Size = new System.Drawing.Size(50, 24);
            this.Label_AreaTitle.TabIndex = 5;
            this.Label_AreaTitle.Text = "Area";
            // 
            // Label_FlowTitle
            // 
            this.Label_FlowTitle.AutoSize = true;
            this.Label_FlowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FlowTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_FlowTitle.Location = new System.Drawing.Point(80, 400);
            this.Label_FlowTitle.Name = "Label_FlowTitle";
            this.Label_FlowTitle.Size = new System.Drawing.Size(51, 24);
            this.Label_FlowTitle.TabIndex = 3;
            this.Label_FlowTitle.Text = "Flow";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.ForeColor = System.Drawing.Color.Black;
            this.Label_Name.Location = new System.Drawing.Point(80, 50);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(61, 24);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name";
            // 
            // Panel_ButtonsBackground
            // 
            this.Panel_ButtonsBackground.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Panel_ButtonsBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_ButtonsBackground.Controls.Add(this.RedactButton);
            this.Panel_ButtonsBackground.Controls.Add(this.DeleteButton);
            this.Panel_ButtonsBackground.Controls.Add(this.AddButton);
            this.Panel_ButtonsBackground.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_ButtonsBackground.Location = new System.Drawing.Point(0, 945);
            this.Panel_ButtonsBackground.Name = "Panel_ButtonsBackground";
            this.Panel_ButtonsBackground.Size = new System.Drawing.Size(1544, 67);
            this.Panel_ButtonsBackground.TabIndex = 1;
            // 
            // RedactButton
            // 
            this.RedactButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RedactButton.BackColor = System.Drawing.SystemColors.Control;
            this.RedactButton.ForeColor = System.Drawing.Color.Black;
            this.RedactButton.Location = new System.Drawing.Point(690, 10);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(144, 45);
            this.RedactButton.TabIndex = 2;
            this.RedactButton.Text = "Redact";
            this.RedactButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(1280, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(144, 45);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(60, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 45);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // Label_LengthTitle
            // 
            this.Label_LengthTitle.AutoSize = true;
            this.Label_LengthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_LengthTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_LengthTitle.Location = new System.Drawing.Point(80, 150);
            this.Label_LengthTitle.Name = "Label_LengthTitle";
            this.Label_LengthTitle.Size = new System.Drawing.Size(68, 24);
            this.Label_LengthTitle.TabIndex = 0;
            this.Label_LengthTitle.Text = "Length";
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox_Search.ForeColor = System.Drawing.Color.DimGray;
            this.TextBox_Search.Location = new System.Drawing.Point(276, 35);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(63, 20);
            this.TextBox_Search.TabIndex = 3;
            this.TextBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_TotalFlowVar
            // 
            this.Label_TotalFlowVar.AutoSize = true;
            this.Label_TotalFlowVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TotalFlowVar.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalFlowVar.Location = new System.Drawing.Point(250, 450);
            this.Label_TotalFlowVar.Name = "Label_TotalFlowVar";
            this.Label_TotalFlowVar.Size = new System.Drawing.Size(57, 24);
            this.Label_TotalFlowVar.TabIndex = 16;
            this.Label_TotalFlowVar.Text = "None";
            // 
            // Label_TotalAreaVar
            // 
            this.Label_TotalAreaVar.AutoSize = true;
            this.Label_TotalAreaVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_TotalAreaVar.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalAreaVar.Location = new System.Drawing.Point(250, 250);
            this.Label_TotalAreaVar.Name = "Label_TotalAreaVar";
            this.Label_TotalAreaVar.Size = new System.Drawing.Size(57, 24);
            this.Label_TotalAreaVar.TabIndex = 17;
            this.Label_TotalAreaVar.Text = "None";
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Save.ForeColor = System.Drawing.Color.Black;
            this.Button_Save.Location = new System.Drawing.Point(85, 737);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(119, 36);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "Зберігти";
            this.Button_Save.UseVisualStyleBackColor = false;
            // 
            // Button_Load
            // 
            this.Button_Load.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Load.ForeColor = System.Drawing.Color.Black;
            this.Button_Load.Location = new System.Drawing.Point(85, 779);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(119, 36);
            this.Button_Load.TabIndex = 19;
            this.Button_Load.Text = "Завантажити";
            this.Button_Load.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TextBox_Search);
            this.Controls.Add(this.Panel_Background);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Handbook";
            this.TabControl.ResumeLayout(false);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.Panel_ButtonsBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage_Rivers;
        private System.Windows.Forms.TabPage TabPage_Lakes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Panel Panel_ButtonsBackground;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Label_LengthTitle;
        private System.Windows.Forms.TabPage TabPage_Seas;
        private System.Windows.Forms.Label Label_TotalAreaText;
        private System.Windows.Forms.Label Label_TotalFlowText;
        private System.Windows.Forms.Label Label_TributariesTitle;
        private System.Windows.Forms.Label Label_FlowsIntoTitle;
        private System.Windows.Forms.Label Label_AreaTitle;
        private System.Windows.Forms.Label Label_FlowTitle;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_AreaVariable;
        private System.Windows.Forms.Label Label_LengthVariable;
        private System.Windows.Forms.Label Label_FlowVariable;
        private System.Windows.Forms.Label Label_TributariesVariable;
        private System.Windows.Forms.Label Label_FlowsIntoVariable;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_TotalFlowVar;
        private System.Windows.Forms.Label Label_TotalAreaVar;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.Button Button_Save;
    }
}