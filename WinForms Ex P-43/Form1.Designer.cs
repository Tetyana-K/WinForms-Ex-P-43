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
            grpColors.SuspendLayout();
            grpLanguage.SuspendLayout();
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
            rbRed.Checked = true;
            rbRed.Location = new Point(60, 46);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(45, 19);
            rbRed.TabIndex = 0;
            rbRed.TabStop = true;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // lblColor
            // 
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
            grpLanguage.Size = new Size(209, 201);
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
            lblLanguages.Size = new Size(216, 83);
            lblLanguages.TabIndex = 3;
            lblLanguages.Text = "Languages:";
            lblLanguages.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
