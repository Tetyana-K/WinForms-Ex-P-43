namespace WinForms_Ex_P_43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // універсальний обробник для всіх радіокнопок
        private void rbRed_CheckedChanged(object sender, EventArgs e) //sender - це та радіокнопка, яка викликала подію
        {
            var radio = (RadioButton) sender; // приводимо sender до типу RadioButton, щоб отримати доступ до його властивостей
            if (radio.Checked) // перевіряємо, чи ця радіокнопка була вибрана
            {
                //grpColors.BackColor = Color.Red;
                // Color.FromName(рядок) - перетворює рядок з назвою кольору в об'єкт Color, який можна використовувати для встановлення кольору фону 
                lblColor.BackColor = Color.FromName(radio.Text); // використовуємо текст радіокнопки як назву кольору для встановлення фону lblColor
            }
        }

        private void checkEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkEnglish.Checked)
            //{
            //    MessageBox.Show("You have selected English");
            //}
            List<string> result = new() { }; // створюємо порожній список рядків для збереження вибраних мов
            foreach (CheckBox check in grpLanguage.Controls) // проходимо по всіх контролах в групі grpLanguage, які є CheckBox
            {
                if (check.Checked) // перевіряємо, чи ця CheckBox була вибрана
                {
                    result.Add(check.Text); // якщо вибрана, додаємо її текст (назву мови) до списку результатів
                }
            }
            lblLanguages.Text = "Selected Languages: " + string.Join(", ", result);

        }

        private void rbKyiv_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Kyiv Checked : {rbKyiv.Checked}");
        }
    }
}

