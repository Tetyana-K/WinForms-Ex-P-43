namespace WinForms_Ex_P_43
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpColors = new GroupBox();
            rbGreen = new RadioButton();
            rbYellow = new RadioButton();
            rbRed = new RadioButton();
            lblColor = new Label();
            grpLanguage = new GroupBox();
            checkPolish = new CheckBox();
            checkFrench = new CheckBox();
            checkEnglish = new CheckBox();
            lblLanguages = new Label();
            rbKyiv = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBoxCities = new GroupBox();
            grpColors.SuspendLayout();
            grpLanguage.SuspendLayout();
            groupBoxCities.SuspendLayout();
            SuspendLayout();
            // 
            // grpColors
            // 
            grpColors.Controls.Add(rbGreen);
            grpColors.Controls.Add(rbYellow);
            grpColors.Controls.Add(rbRed);
            grpColors.Location = new Point(126, 86);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(209, 201);
            grpColors.TabIndex = 0;
            grpColors.TabStop = false;
            grpColors.Text = "Colors";
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(60, 134);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(56, 19);
            rbGreen.TabIndex = 2;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbYellow
            // 
            rbYellow.AutoSize = true;
            rbYellow.Location = new Point(57, 91);
            rbYellow.Name = "rbYellow";
            rbYellow.Size = new Size(59, 19);
            rbYellow.TabIndex = 1;
            rbYellow.Text = "Yellow";
            rbYellow.UseVisualStyleBackColor = true;
            rbYellow.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(60, 46);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(45, 19);
            rbRed.TabIndex = 0;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // lblColor
            // 
            lblColor.BackColor = SystemColors.ActiveCaption;
            lblColor.Location = new Point(126, 321);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(209, 28);
            lblColor.TabIndex = 1;
            lblColor.Text = "Current Color";
            lblColor.UseCompatibleTextRendering = true;
            // 
            // grpLanguage
            // 
            grpLanguage.Controls.Add(checkPolish);
            grpLanguage.Controls.Add(checkFrench);
            grpLanguage.Controls.Add(checkEnglish);
            grpLanguage.Location = new Point(456, 86);
            grpLanguage.Name = "grpLanguage";
            grpLanguage.Size = new Size(203, 201);
            grpLanguage.TabIndex = 2;
            grpLanguage.TabStop = false;
            grpLanguage.Text = "Languages";
            // 
            // checkPolish
            // 
            checkPolish.AutoSize = true;
            checkPolish.Location = new Point(63, 134);
            checkPolish.Name = "checkPolish";
            checkPolish.Size = new Size(58, 19);
            checkPolish.TabIndex = 2;
            checkPolish.Text = "Polish";
            checkPolish.UseVisualStyleBackColor = true;
            checkPolish.CheckedChanged += checkEnglish_CheckedChanged;
            // 
            // checkFrench
            // 
            checkFrench.AutoSize = true;
            checkFrench.Location = new Point(63, 82);
            checkFrench.Name = "checkFrench";
            checkFrench.Size = new Size(62, 19);
            checkFrench.TabIndex = 1;
            checkFrench.Text = "French";
            checkFrench.UseVisualStyleBackColor = true;
            checkFrench.CheckedChanged += checkEnglish_CheckedChanged;
            // 
            // checkEnglish
            // 
            checkEnglish.AutoSize = true;
            checkEnglish.Location = new Point(63, 37);
            checkEnglish.Name = "checkEnglish";
            checkEnglish.Size = new Size(64, 19);
            checkEnglish.TabIndex = 0;
            checkEnglish.Text = "English";
            checkEnglish.UseVisualStyleBackColor = true;
            checkEnglish.CheckedChanged += checkEnglish_CheckedChanged;
            // 
            // lblLanguages
            // 
            lblLanguages.Location = new Point(456, 321);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(203, 83);
            lblLanguages.TabIndex = 3;
            lblLanguages.Text = "Languages:";
            lblLanguages.UseCompatibleTextRendering = true;
            // 
            // rbKyiv
            // 
            rbKyiv.AutoSize = true;
            rbKyiv.Location = new Point(38, 42);
            rbKyiv.Name = "rbKyiv";
            rbKyiv.Size = new Size(46, 19);
            rbKyiv.TabIndex = 4;
            rbKyiv.Text = "Kyiv";
            rbKyiv.UseVisualStyleBackColor = true;
            rbKyiv.CheckedChanged += rbKyiv_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(38, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(38, 154);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxCities
            // 
            groupBoxCities.Controls.Add(rbKyiv);
            groupBoxCities.Controls.Add(radioButton3);
            groupBoxCities.Controls.Add(radioButton2);
            groupBoxCities.Location = new Point(830, 86);
            groupBoxCities.Name = "groupBoxCities";
            groupBoxCities.Size = new Size(183, 201);
            groupBoxCities.TabIndex = 7;
            groupBoxCities.TabStop = false;
            groupBoxCities.Text = "Cities";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 450);
            Controls.Add(groupBoxCities);
            Controls.Add(lblLanguages);
            Controls.Add(grpLanguage);
            Controls.Add(lblColor);
            Controls.Add(grpColors);
            Name = "Form1";
            Text = "Form1";
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpLanguage.ResumeLayout(false);
            grpLanguage.PerformLayout();
            groupBoxCities.ResumeLayout(false);
            groupBoxCities.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpColors;
        private RadioButton rbGreen;
        private RadioButton rbYellow;
        private RadioButton rbRed;
        private Label lblColor;
        private GroupBox grpLanguage;
        private Label lblLanguages;
        private CheckBox checkPolish;
        private CheckBox checkFrench;
        private CheckBox checkEnglish;
        private RadioButton rbKyiv;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBoxCities;
    }
}
