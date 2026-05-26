namespace WinForms_Ex_P_43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                //grpColors.BackColor = Color.Red;
                lblColor.BackColor = Color.FromName(radio.Text);
            }
        }

        private void checkEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkEnglish.Checked)
            //{
            //    MessageBox.Show("You have selected English");
            //}
            List<string> result = new() {  };
            foreach (CheckBox check in grpLanguage.Controls)
            {
                if (check.Checked)
                {
                    result.Add(check.Text);
                }
            }
            lblLanguages.Text = "Selected Languages: " + string.Join(", ", result);
                
            }
        }
    }

