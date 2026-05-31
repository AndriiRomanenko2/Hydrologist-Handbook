namespace Hydrologist_Handbook
{
    partial class RedactForm
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
            this.components = new System.ComponentModel.Container();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Label_Length = new System.Windows.Forms.Label();
            this.TextBox_Length = new System.Windows.Forms.TextBox();
            this.Label_Flow = new System.Windows.Forms.Label();
            this.TextBox_Flow = new System.Windows.Forms.TextBox();
            this.Label_BasinArea = new System.Windows.Forms.Label();
            this.TextBox_Area = new System.Windows.Forms.TextBox();
            this.Label_FlowsInto = new System.Windows.Forms.Label();
            this.ComboBox_FlowsInto = new System.Windows.Forms.ComboBox();
            this.Button_SubmitRedact = new System.Windows.Forms.Button();
            this.Button_CancelRedact = new System.Windows.Forms.Button();
            this.Label_ObjectType = new System.Windows.Forms.Label();
            this.ComboBox_ObjectType = new System.Windows.Forms.ComboBox();
            this.Label_SeaArea = new System.Windows.Forms.Label();
            this.TextBox_SeaArea = new System.Windows.Forms.TextBox();
            this.TextBox_AvgDepth = new System.Windows.Forms.TextBox();
            this.TextBox_MaxDepth = new System.Windows.Forms.TextBox();
            this.Label_AvgDepth = new System.Windows.Forms.Label();
            this.Label_MaxDepth = new System.Windows.Forms.Label();
            this.ComboBox_FlowsFrom = new System.Windows.Forms.ComboBox();
            this.Label_FlowFrom = new System.Windows.Forms.Label();
            this.Button_ImageSelect = new System.Windows.Forms.Button();
            this.Label_ImagePath = new System.Windows.Forms.Label();
            this.PictureBox_PreviewBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(12, 66);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(42, 13);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Назва:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(62, 63);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Name.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Label_Length
            // 
            this.Label_Length.AutoSize = true;
            this.Label_Length.Location = new System.Drawing.Point(10, 101);
            this.Label_Length.Name = "Label_Length";
            this.Label_Length.Size = new System.Drawing.Size(80, 13);
            this.Label_Length.TabIndex = 3;
            this.Label_Length.Text = "Довжина (км):";
            // 
            // TextBox_Length
            // 
            this.TextBox_Length.Location = new System.Drawing.Point(96, 99);
            this.TextBox_Length.Name = "TextBox_Length";
            this.TextBox_Length.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Length.TabIndex = 4;
            // 
            // Label_Flow
            // 
            this.Label_Flow.AutoSize = true;
            this.Label_Flow.Location = new System.Drawing.Point(12, 136);
            this.Label_Flow.Name = "Label_Flow";
            this.Label_Flow.Size = new System.Drawing.Size(90, 13);
            this.Label_Flow.TabIndex = 5;
            this.Label_Flow.Text = "Річний стік (км³):";
            // 
            // TextBox_Flow
            // 
            this.TextBox_Flow.Location = new System.Drawing.Point(107, 133);
            this.TextBox_Flow.Name = "TextBox_Flow";
            this.TextBox_Flow.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Flow.TabIndex = 6;
            // 
            // Label_BasinArea
            // 
            this.Label_BasinArea.AutoSize = true;
            this.Label_BasinArea.Location = new System.Drawing.Point(12, 171);
            this.Label_BasinArea.Name = "Label_BasinArea";
            this.Label_BasinArea.Size = new System.Drawing.Size(115, 13);
            this.Label_BasinArea.TabIndex = 7;
            this.Label_BasinArea.Text = "Площа басейну (км²):";
            // 
            // TextBox_Area
            // 
            this.TextBox_Area.Location = new System.Drawing.Point(132, 168);
            this.TextBox_Area.Name = "TextBox_Area";
            this.TextBox_Area.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Area.TabIndex = 8;
            // 
            // Label_FlowsInto
            // 
            this.Label_FlowsInto.AutoSize = true;
            this.Label_FlowsInto.Location = new System.Drawing.Point(12, 203);
            this.Label_FlowsInto.Name = "Label_FlowsInto";
            this.Label_FlowsInto.Size = new System.Drawing.Size(56, 13);
            this.Label_FlowsInto.TabIndex = 9;
            this.Label_FlowsInto.Text = "Впадає в:";
            // 
            // ComboBox_FlowsInto
            // 
            this.ComboBox_FlowsInto.FormattingEnabled = true;
            this.ComboBox_FlowsInto.Location = new System.Drawing.Point(15, 219);
            this.ComboBox_FlowsInto.Name = "ComboBox_FlowsInto";
            this.ComboBox_FlowsInto.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_FlowsInto.TabIndex = 10;
            // 
            // Button_SubmitRedact
            // 
            this.Button_SubmitRedact.Location = new System.Drawing.Point(15, 476);
            this.Button_SubmitRedact.Name = "Button_SubmitRedact";
            this.Button_SubmitRedact.Size = new System.Drawing.Size(87, 23);
            this.Button_SubmitRedact.TabIndex = 11;
            this.Button_SubmitRedact.Text = "Підтвердити";
            this.Button_SubmitRedact.UseVisualStyleBackColor = true;
            // 
            // Button_CancelRedact
            // 
            this.Button_CancelRedact.Location = new System.Drawing.Point(362, 476);
            this.Button_CancelRedact.Name = "Button_CancelRedact";
            this.Button_CancelRedact.Size = new System.Drawing.Size(75, 23);
            this.Button_CancelRedact.TabIndex = 12;
            this.Button_CancelRedact.Text = "Скасувати";
            this.Button_CancelRedact.UseVisualStyleBackColor = true;
            // 
            // Label_ObjectType
            // 
            this.Label_ObjectType.AutoSize = true;
            this.Label_ObjectType.Location = new System.Drawing.Point(12, 24);
            this.Label_ObjectType.Name = "Label_ObjectType";
            this.Label_ObjectType.Size = new System.Drawing.Size(29, 13);
            this.Label_ObjectType.TabIndex = 13;
            this.Label_ObjectType.Text = "Тип:";
            // 
            // ComboBox_ObjectType
            // 
            this.ComboBox_ObjectType.FormattingEnabled = true;
            this.ComboBox_ObjectType.Location = new System.Drawing.Point(62, 24);
            this.ComboBox_ObjectType.Name = "ComboBox_ObjectType";
            this.ComboBox_ObjectType.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_ObjectType.TabIndex = 14;
            // 
            // Label_SeaArea
            // 
            this.Label_SeaArea.AutoSize = true;
            this.Label_SeaArea.Location = new System.Drawing.Point(344, 43);
            this.Label_SeaArea.Name = "Label_SeaArea";
            this.Label_SeaArea.Size = new System.Drawing.Size(71, 13);
            this.Label_SeaArea.TabIndex = 15;
            this.Label_SeaArea.Text = "Площа (км²):";
            // 
            // TextBox_SeaArea
            // 
            this.TextBox_SeaArea.Location = new System.Drawing.Point(345, 59);
            this.TextBox_SeaArea.Name = "TextBox_SeaArea";
            this.TextBox_SeaArea.Size = new System.Drawing.Size(100, 20);
            this.TextBox_SeaArea.TabIndex = 16;
            // 
            // TextBox_AvgDepth
            // 
            this.TextBox_AvgDepth.Location = new System.Drawing.Point(345, 115);
            this.TextBox_AvgDepth.Name = "TextBox_AvgDepth";
            this.TextBox_AvgDepth.Size = new System.Drawing.Size(100, 20);
            this.TextBox_AvgDepth.TabIndex = 17;
            // 
            // TextBox_MaxDepth
            // 
            this.TextBox_MaxDepth.Location = new System.Drawing.Point(345, 171);
            this.TextBox_MaxDepth.Name = "TextBox_MaxDepth";
            this.TextBox_MaxDepth.Size = new System.Drawing.Size(100, 20);
            this.TextBox_MaxDepth.TabIndex = 18;
            // 
            // Label_AvgDepth
            // 
            this.Label_AvgDepth.AutoSize = true;
            this.Label_AvgDepth.Location = new System.Drawing.Point(344, 100);
            this.Label_AvgDepth.Name = "Label_AvgDepth";
            this.Label_AvgDepth.Size = new System.Drawing.Size(93, 13);
            this.Label_AvgDepth.TabIndex = 19;
            this.Label_AvgDepth.Text = "Сер. глибина (м):";
            // 
            // Label_MaxDepth
            // 
            this.Label_MaxDepth.AutoSize = true;
            this.Label_MaxDepth.Location = new System.Drawing.Point(345, 155);
            this.Label_MaxDepth.Name = "Label_MaxDepth";
            this.Label_MaxDepth.Size = new System.Drawing.Size(101, 13);
            this.Label_MaxDepth.TabIndex = 20;
            this.Label_MaxDepth.Text = "Макс. глибина (м):";
            // 
            // ComboBox_FlowsFrom
            // 
            this.ComboBox_FlowsFrom.FormattingEnabled = true;
            this.ComboBox_FlowsFrom.Location = new System.Drawing.Point(162, 219);
            this.ComboBox_FlowsFrom.Name = "ComboBox_FlowsFrom";
            this.ComboBox_FlowsFrom.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_FlowsFrom.TabIndex = 22;
            // 
            // Label_FlowFrom
            // 
            this.Label_FlowFrom.AutoSize = true;
            this.Label_FlowFrom.Location = new System.Drawing.Point(159, 203);
            this.Label_FlowFrom.Name = "Label_FlowFrom";
            this.Label_FlowFrom.Size = new System.Drawing.Size(57, 13);
            this.Label_FlowFrom.TabIndex = 21;
            this.Label_FlowFrom.Text = "Витікає з:";
            // 
            // Button_ImageSelect
            // 
            this.Button_ImageSelect.Location = new System.Drawing.Point(208, 416);
            this.Button_ImageSelect.Name = "Button_ImageSelect";
            this.Button_ImageSelect.Size = new System.Drawing.Size(75, 23);
            this.Button_ImageSelect.TabIndex = 23;
            this.Button_ImageSelect.UseVisualStyleBackColor = true;
            // 
            // Label_ImagePath
            // 
            this.Label_ImagePath.AutoSize = true;
            this.Label_ImagePath.Location = new System.Drawing.Point(214, 442);
            this.Label_ImagePath.Name = "Label_ImagePath";
            this.Label_ImagePath.Size = new System.Drawing.Size(60, 13);
            this.Label_ImagePath.TabIndex = 24;
            this.Label_ImagePath.Text = "Не обрано";
            // 
            // PictureBox_PreviewBox
            // 
            this.PictureBox_PreviewBox.Location = new System.Drawing.Point(150, 260);
            this.PictureBox_PreviewBox.Name = "PictureBox_PreviewBox";
            this.PictureBox_PreviewBox.Size = new System.Drawing.Size(200, 150);
            this.PictureBox_PreviewBox.TabIndex = 25;
            this.PictureBox_PreviewBox.TabStop = false;
            // 
            // RedactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.PictureBox_PreviewBox);
            this.Controls.Add(this.Label_ImagePath);
            this.Controls.Add(this.Button_ImageSelect);
            this.Controls.Add(this.ComboBox_FlowsFrom);
            this.Controls.Add(this.Label_FlowFrom);
            this.Controls.Add(this.Label_MaxDepth);
            this.Controls.Add(this.Label_AvgDepth);
            this.Controls.Add(this.TextBox_MaxDepth);
            this.Controls.Add(this.TextBox_AvgDepth);
            this.Controls.Add(this.TextBox_SeaArea);
            this.Controls.Add(this.Label_SeaArea);
            this.Controls.Add(this.ComboBox_ObjectType);
            this.Controls.Add(this.Label_ObjectType);
            this.Controls.Add(this.Button_CancelRedact);
            this.Controls.Add(this.Button_SubmitRedact);
            this.Controls.Add(this.ComboBox_FlowsInto);
            this.Controls.Add(this.Label_FlowsInto);
            this.Controls.Add(this.TextBox_Area);
            this.Controls.Add(this.Label_BasinArea);
            this.Controls.Add(this.TextBox_Flow);
            this.Controls.Add(this.Label_Flow);
            this.Controls.Add(this.TextBox_Length);
            this.Controls.Add(this.Label_Length);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "RedactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedactForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Label_Length;
        private System.Windows.Forms.TextBox TextBox_Length;
        private System.Windows.Forms.Label Label_Flow;
        private System.Windows.Forms.TextBox TextBox_Flow;
        private System.Windows.Forms.Label Label_BasinArea;
        private System.Windows.Forms.TextBox TextBox_Area;
        private System.Windows.Forms.Label Label_FlowsInto;
        private System.Windows.Forms.ComboBox ComboBox_FlowsInto;
        private System.Windows.Forms.Button Button_SubmitRedact;
        private System.Windows.Forms.Button Button_CancelRedact;
        private System.Windows.Forms.Label Label_ObjectType;
        private System.Windows.Forms.ComboBox ComboBox_ObjectType;
        private System.Windows.Forms.Label Label_SeaArea;
        private System.Windows.Forms.TextBox TextBox_SeaArea;
        private System.Windows.Forms.TextBox TextBox_AvgDepth;
        private System.Windows.Forms.TextBox TextBox_MaxDepth;
        private System.Windows.Forms.Label Label_AvgDepth;
        private System.Windows.Forms.Label Label_MaxDepth;
        private System.Windows.Forms.ComboBox ComboBox_FlowsFrom;
        private System.Windows.Forms.Label Label_FlowFrom;
        private System.Windows.Forms.Button Button_ImageSelect;
        private System.Windows.Forms.Label Label_ImagePath;
        private System.Windows.Forms.PictureBox PictureBox_PreviewBox;
    }
}