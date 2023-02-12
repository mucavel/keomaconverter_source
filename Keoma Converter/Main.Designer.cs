namespace Keoma_Converter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CrossLabel = new System.Windows.Forms.Label();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PathTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OperationComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LossLessCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CkeckBoxLabel = new System.Windows.Forms.Label();
            this.QualityTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OutputTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UploadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CrossLabel
            // 
            this.CrossLabel.AutoSize = true;
            this.CrossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossLabel.ForeColor = System.Drawing.Color.Black;
            this.CrossLabel.Location = new System.Drawing.Point(590, 5);
            this.CrossLabel.Name = "CrossLabel";
            this.CrossLabel.Size = new System.Drawing.Size(25, 24);
            this.CrossLabel.TabIndex = 0;
            this.CrossLabel.Text = "X";
            this.CrossLabel.Click += new System.EventHandler(this.CrossLabel_Click);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.Color.Black;
            this.MinimizeLabel.Location = new System.Drawing.Point(562, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(22, 29);
            this.MinimizeLabel.TabIndex = 1;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.Title.Location = new System.Drawing.Point(230, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 19);
            this.Title.TabIndex = 2;
            this.Title.Text = "KEOMA CONVERTER";
            // 
            // PathTxtBox
            // 
            this.PathTxtBox.AllowDrop = true;
            this.PathTxtBox.Animated = true;
            this.PathTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.PathTxtBox.BorderRadius = 2;
            this.PathTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PathTxtBox.DefaultText = "";
            this.PathTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathTxtBox.FillColor = System.Drawing.Color.Gainsboro;
            this.PathTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathTxtBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTxtBox.ForeColor = System.Drawing.Color.Black;
            this.PathTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathTxtBox.Location = new System.Drawing.Point(76, 86);
            this.PathTxtBox.MaxLength = 500;
            this.PathTxtBox.Name = "PathTxtBox";
            this.PathTxtBox.PasswordChar = '\0';
            this.PathTxtBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PathTxtBox.PlaceholderText = "Upload or Drop a picture here";
            this.PathTxtBox.ReadOnly = true;
            this.PathTxtBox.SelectedText = "";
            this.PathTxtBox.Size = new System.Drawing.Size(466, 45);
            this.PathTxtBox.TabIndex = 3;
            this.PathTxtBox.WordWrap = false;
            // 
            // OperationComboBox
            // 
            this.OperationComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.OperationComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.OperationComboBox.BorderRadius = 2;
            this.OperationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationComboBox.FillColor = System.Drawing.Color.Gainsboro;
            this.OperationComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OperationComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OperationComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationComboBox.ForeColor = System.Drawing.Color.Black;
            this.OperationComboBox.ItemHeight = 30;
            this.OperationComboBox.Items.AddRange(new object[] {
            "Operation",
            "cwebp (Compress)",
            "dwebp (Decompress)",
            "gif2webp (Gif to WebP)"});
            this.OperationComboBox.Location = new System.Drawing.Point(352, 156);
            this.OperationComboBox.MaxDropDownItems = 3;
            this.OperationComboBox.Name = "OperationComboBox";
            this.OperationComboBox.Size = new System.Drawing.Size(190, 36);
            this.OperationComboBox.StartIndex = 0;
            this.OperationComboBox.TabIndex = 4;
            // 
            // LossLessCheckBox
            // 
            this.LossLessCheckBox.Animated = true;
            this.LossLessCheckBox.AutoSize = true;
            this.LossLessCheckBox.BackColor = System.Drawing.Color.Gainsboro;
            this.LossLessCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LossLessCheckBox.CheckedState.BorderRadius = 0;
            this.LossLessCheckBox.CheckedState.BorderThickness = 0;
            this.LossLessCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LossLessCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.LossLessCheckBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LossLessCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LossLessCheckBox.Location = new System.Drawing.Point(76, 156);
            this.LossLessCheckBox.Name = "LossLessCheckBox";
            this.LossLessCheckBox.Size = new System.Drawing.Size(78, 20);
            this.LossLessCheckBox.TabIndex = 5;
            this.LossLessCheckBox.Text = "Lossless";
            this.LossLessCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LossLessCheckBox.UncheckedState.BorderRadius = 0;
            this.LossLessCheckBox.UncheckedState.BorderThickness = 1;
            this.LossLessCheckBox.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.LossLessCheckBox.UseVisualStyleBackColor = false;
            // 
            // CkeckBoxLabel
            // 
            this.CkeckBoxLabel.AutoSize = true;
            this.CkeckBoxLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkeckBoxLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CkeckBoxLabel.Location = new System.Drawing.Point(73, 179);
            this.CkeckBoxLabel.Name = "CkeckBoxLabel";
            this.CkeckBoxLabel.Size = new System.Drawing.Size(250, 14);
            this.CkeckBoxLabel.TabIndex = 6;
            this.CkeckBoxLabel.Text = "(Check for pictures with Transparent background)";
            // 
            // QualityTxtBox
            // 
            this.QualityTxtBox.Animated = true;
            this.QualityTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.QualityTxtBox.BorderRadius = 2;
            this.QualityTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.QualityTxtBox.DefaultText = "";
            this.QualityTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QualityTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QualityTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualityTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualityTxtBox.FillColor = System.Drawing.Color.Gainsboro;
            this.QualityTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualityTxtBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityTxtBox.ForeColor = System.Drawing.Color.Black;
            this.QualityTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualityTxtBox.Location = new System.Drawing.Point(76, 216);
            this.QualityTxtBox.MaxLength = 3;
            this.QualityTxtBox.Name = "QualityTxtBox";
            this.QualityTxtBox.PasswordChar = '\0';
            this.QualityTxtBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.QualityTxtBox.PlaceholderText = "Quality (0 -100)";
            this.QualityTxtBox.SelectedText = "";
            this.QualityTxtBox.Size = new System.Drawing.Size(129, 45);
            this.QualityTxtBox.TabIndex = 7;
            this.QualityTxtBox.WordWrap = false;
            // 
            // OutputTxtBox
            // 
            this.OutputTxtBox.Animated = true;
            this.OutputTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.OutputTxtBox.BorderRadius = 2;
            this.OutputTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputTxtBox.DefaultText = "";
            this.OutputTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OutputTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OutputTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTxtBox.FillColor = System.Drawing.Color.Gainsboro;
            this.OutputTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTxtBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.OutputTxtBox.ForeColor = System.Drawing.Color.Black;
            this.OutputTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTxtBox.Location = new System.Drawing.Point(285, 216);
            this.OutputTxtBox.MaxLength = 500;
            this.OutputTxtBox.Name = "OutputTxtBox";
            this.OutputTxtBox.PasswordChar = '\0';
            this.OutputTxtBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.OutputTxtBox.PlaceholderText = "Output Name";
            this.OutputTxtBox.SelectedText = "";
            this.OutputTxtBox.Size = new System.Drawing.Size(257, 45);
            this.OutputTxtBox.TabIndex = 8;
            this.OutputTxtBox.WordWrap = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.BorderRadius = 2;
            this.UploadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.ForeColor = System.Drawing.Color.White;
            this.UploadBtn.Location = new System.Drawing.Point(76, 308);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(129, 45);
            this.UploadBtn.TabIndex = 9;
            this.UploadBtn.Text = "Upload";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BorderRadius = 2;
            this.ResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(413, 308);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(129, 45);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BorderRadius = 2;
            this.StartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(247, 308);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(129, 45);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(133, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Developer: Salvador Mucavele @ 2023 - salvadormucavel.vercel.app";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(623, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.OutputTxtBox);
            this.Controls.Add(this.QualityTxtBox);
            this.Controls.Add(this.CkeckBoxLabel);
            this.Controls.Add(this.LossLessCheckBox);
            this.Controls.Add(this.OperationComboBox);
            this.Controls.Add(this.PathTxtBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MinimizeLabel);
            this.Controls.Add(this.CrossLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEOMA Converter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrossLabel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2TextBox PathTxtBox;
        private Guna.UI2.WinForms.Guna2ComboBox OperationComboBox;
        private Guna.UI2.WinForms.Guna2CheckBox LossLessCheckBox;
        private System.Windows.Forms.Label CkeckBoxLabel;
        private Guna.UI2.WinForms.Guna2TextBox QualityTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox OutputTxtBox;
        private Guna.UI2.WinForms.Guna2Button UploadBtn;
        private Guna.UI2.WinForms.Guna2Button ResetBtn;
        private Guna.UI2.WinForms.Guna2Button StartBtn;
        private System.Windows.Forms.Label label1;
    }
}

