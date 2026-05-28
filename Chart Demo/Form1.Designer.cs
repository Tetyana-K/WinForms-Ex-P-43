namespace Chart_Demo
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            btnAdd = new Button();
            numericValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericValue).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 184);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(285, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 506);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add value";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numericValue
            // 
            numericValue.Location = new Point(22, 255);
            numericValue.Name = "numericValue";
            numericValue.Size = new Size(181, 23);
            numericValue.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 582);
            Controls.Add(numericValue);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Button btnAdd;
        private NumericUpDown numericValue;
    }
}
