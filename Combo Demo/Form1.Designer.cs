namespace Combo_Demo
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
            comboColors = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboColors
            // 
            comboColors.FormattingEnabled = true;
            comboColors.Items.AddRange(new object[] { "Red", "Yellow", "Green" });
            comboColors.Location = new Point(95, 61);
            comboColors.Name = "comboColors";
            comboColors.Size = new Size(121, 23);
            comboColors.TabIndex = 0;
            comboColors.SelectedIndexChanged += comboColors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 222);
            Controls.Add(label1);
            Controls.Add(comboColors);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboColors;
        private Label label1;
    }
}
