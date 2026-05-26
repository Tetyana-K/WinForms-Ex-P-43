namespace Timer_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 500;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //pictureBox1.ImageLocation = "../../../Images/Lviv.jpg"; CitiesPictures.GetPIctureByIndex(0);
            // string? picturePath = CitiesPictures.GetPIctureByIndex(2);
            //string fullPath = Path.Combine("../../../Images/", picturePath ?? string.Empty);
            //pictureBox1.ImageLocation = fullPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start(); // запускаємо таймер, який буде викликати подію timer1_Tick кожні 1000 мілісекунд (1 секунду)

        }

        // індекс поточного зображення
        int index = 0; // індекс для відображення зображень по черзі, який буде збільшуватися на 1 при кожному виклику timer1_Tick і повертатися до 0 після досягнення кількості зображень
        private void timer1_Tick(object sender, EventArgs e)
        {
            string? picturePath = CitiesPictures.GetPIctureByIndex(index);
            if (picturePath != null)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("../../../Images/", picturePath));
            }
            index = (index + 1) % CitiesPictures.Count;
        // 0 1 2 - так будуть бігти індекси картинок
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application will be closed");
            this.Close();
        }

        int moveStep = 10;
        private void timerMoving_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += moveStep;// Top = координата верхньої межі pictureBox1 відносно верхньої межі форми, тому збільшуючи її на moveStep, ми рухаємо pictureBox1 вниз на moveStep пікселів при кожному виклику timerMoving_Tick
            if (pictureBox1.Top + pictureBox1.Height > ClientSize.Height || pictureBox1.Top < 0)
            {
                moveStep = -moveStep;
            }
        }

        private void btnStartMoving_Click(object sender, EventArgs e)
        {
            timerMoving.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // зупиняємо таймер1, щоб припинити виклик події timer1_Tick
        }

        private void timerNew_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
