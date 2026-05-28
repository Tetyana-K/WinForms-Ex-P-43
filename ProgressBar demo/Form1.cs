namespace ProgressBar_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //тут можна налаштувати прогрес-бар та ListBox тут, але краще це робити у Form1_Load, щоб бути впевненим, що всі компоненти форми вже ініціалізовані.
            progressBar1.Minimum = 0; // Встановлюємо мінімальне значення прогрес-бару
            progressBar1.Maximum = maxQuantity; // Встановлюємо максимальне значення прогрес-бару
            listBox1.MultiColumn = true; // Встановлюємо режим багатоколоночного відображення для ListBox
            //listBox1.HorizontalScrollbar = true; // Додаємо горизонтальну смугу прокрутки для ListBox
            //listBox1.ScrollAlwaysVisible = true; // Завжди показуємо смугу прокрутки для ListBox
        }

        const int maxQuantity = 10; // Максимальна кількість для прогрес-бару 
        Random rnd = new Random();
        private async void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0; // Скидаємо прогрес-бар перед початком
            listBox1.Items.Clear(); // Очищаємо ListBox перед початком

            for (int i = 0; i < maxQuantity; i++)
            {
                var value = rnd.Next(1, 1000);
                listBox1.Items.Add(value); // Додаємо випадкове число до ListBox
                // Симуляція виконання деякої роботи, яка займає час
                //System.Threading.Thread.Sleep(200); // Затримка для імітації роботи
                await Task.Delay(300);
                progressBar1.Value = i + 1; // Оновлюємо значення прогрес-бару
                //progressBar1.Value += 1; // Оновлюємо значення прогрес-бару, збільшуючи його на 1
                //progressBar1.Increment(1); // Оновлюємо значення прогрес-бару, збільшуючи його на 1
               // progressBar1.Step = 1; // Встановлюємо крок для прогрес-бару
               // progressBar1.PerformStep(); // Оновлюємо значення прогрес-бару, виконуючи крок, визначений властивістю Step

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
