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
            timer1.Start();

        }

        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string? picturePath = CitiesPictures.GetPIctureByIndex(index);
            if (picturePath != null)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("../../../Images/", picturePath));
            }
            index = (index + 1) % CitiesPictures.Count;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application will be closed");
            this.Close();
        }

        int moveStep = 50;
        private void timerMoving_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += moveStep;
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
            timer1.Stop();
        }
    }
}
