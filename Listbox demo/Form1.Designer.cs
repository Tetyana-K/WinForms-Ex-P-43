namespace Listbox_demo
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
            lblInfo = new Label();
            listBox1 = new ListBox();
            tbValue = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            lbNumbers = new ListBox();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(87, 225);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(28, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "C++", "Python", "HTML" });
            listBox1.Location = new Point(87, 52);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(189, 154);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbValue
            // 
            tbValue.Location = new Point(346, 52);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(116, 23);
            tbValue.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(346, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(346, 160);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(116, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(346, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(346, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbNumbers
            // 
            lbNumbers.FormattingEnabled = true;
            lbNumbers.Items.AddRange(new object[] { "12", "hello", "book", "true" });
            lbNumbers.Location = new Point(555, 52);
            lbNumbers.Name = "lbNumbers";
            lbNumbers.Size = new Size(185, 154);
            lbNumbers.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNumbers);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(tbValue);
            Controls.Add(listBox1);
            Controls.Add(lblInfo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private ListBox listBox1;
        private TextBox tbValue;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnUpdate;
        private ListBox lbNumbers;
    }
}
