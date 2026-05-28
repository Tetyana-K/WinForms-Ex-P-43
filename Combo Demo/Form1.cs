namespace Combo_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboColors.Items.AddRange(new string[] { "Violet", "Navy", "Blue", "Pink" });
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColors.SelectedItem != null)
            {
                label1.Text = $"Selected color: {comboColors.SelectedItem}"; // відображаємо вибраний колір у label1
                label1.BackColor = Color.FromName(comboColors.SelectedItem.ToString()); // змінюємо колір тексту label1 на вибраний колір
            }
        }
    }
}
