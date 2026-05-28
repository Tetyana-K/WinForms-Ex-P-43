using System.Xml.Linq;

namespace Listbox_demo
{
    public partial class Form1 : Form
    {
        public Form1() // ctor
        {
            InitializeComponent();
            
            // тут теж можна додавати елементи до ListBox, але краще це робити у Form1_Load, щоб бути впевненим, що всі компоненти форми вже ініціалізовані.
        }


        // Form1_Load - це обробник події завантаження форми, який виконується, коли форма завантажується. У цьому методі ми додаємо рядок "SQL" до колекції елементів ListBox1, що дозволяє відобразити цей рядок у ListBox при запуску програми.
        private void Form1_Load(object sender, EventArgs e)
        {
            //  listBox.Items - колекція елементів ListBox, яка є реалізацією інтерфейсу IList. Вона дозволяє додавати, видаляти та отримувати доступ до елементів ListBox.

            listBox1.Items.Add("SQL"); // рядок додається до колекції елементів ListBox як object
            lbNumbers.Items.Add(100); // число додається до колекції елементів ListBox як object (100 -- boxing -- object)
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var index = listBox1.SelectedIndex; // отримуємо індекс вибраного елемента або -1, якщо нічого не вибрано
            //if (index != -1) // перевіряємо, чи вибрано якийсь елемент (індекс не -1)
            //{
            //    lblInfo.Text = listBox1.Items[index].ToString();
            //    tbValue.Text = listBox1.Items[index].ToString();
            //}
            var element = listBox1.SelectedItem; // отримуємо вибраний елемент як object
            if (element != null) // перевіряємо, чи вибрано якийсь елемент (SelectedItem не null)
            {
                lblInfo.Text = $"Selected :{element}"; // перетворюємо об'єкт на рядок і відображаємо його в lblInfo
                tbValue.Text = element.ToString(); // також відображаємо вибраний елемент у текстовому полі для можливого редагування
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var element = tbValue.Text;
            if (!string.IsNullOrEmpty(element) && !listBox1.Items.Contains(element))
            {
                listBox1.Items.Add(element); // додаємо новий елемент до ListBox
                tbValue.Clear(); // очищаємо текстове поле після додавання
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var element = listBox1.SelectedItem; // отримуємо вибраний елемент
            if (element != null)
            {
                listBox1.Items.Remove(element); // видаляємо вибраний елемент з ListBox
                lblInfo.Text = $"Element '{element}' is removed"; // очищаємо lblInfo після видалення
                lblInfo.ForeColor = Color.Green; // змінюємо колір тексту на зелений для підкреслення успішного видалення
            }
            else
            {
                lblInfo.Text = "No element selected to remove"; // повідомлення, якщо не вибрано елемент для видалення
                lblInfo.ForeColor = Color.Red; // змінюємо колір тексту на червоний для підкреслення помилки
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index != -1 && !String.IsNullOrEmpty(tbValue.Text)) // перевіряємо, чи вибрано якийсь елемент для оновлення
            {
                listBox1.Items[index] = tbValue.Text; // оновлюємо елемент за індексом новим значенням з текстового поля
                tbValue.Clear(); // очищаємо текстове поле після оновлення
            }
        }
    }
}
