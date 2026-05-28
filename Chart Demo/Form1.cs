using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
namespace Chart_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CartesianChart chart;
        
        List<double> values = new List<double> { 10, 25.6, 15, 30, 45, 33.4, 47 };
        
        List<double> values2 = new List<double> { 56, 5.6, 5, 34, 4, 73.4, 49 };
        private void Form1_Load(object sender, EventArgs e)
        {
            numericValue.Minimum = -100;
            listBox1.DataSource = values; // прив'язуємо список значень до ListBox для відображення поточних даних
            chart = new CartesianChart
            {
                Dock = DockStyle.Fill, // діаграма заповнюємо весь простір панелі
                Series = new ISeries[]
                {

                      //column chart - стовпчаста діаграма
                     new ColumnSeries<double>
                     {
                         Name = "Sales Diagram",
                         Values = values,
                         Fill = new SolidColorPaint(SkiaSharp.SKColors.PaleVioletRed)
                     },
                     new LineSeries<double>
                     {
                         Name = "Sales Diagram 2",
                         Values = values2,
                         Stroke = new SolidColorPaint(SKColors.Red, 5),
                         //Fill = new SolidColorPaint(SkiaSharp.SKColors.Yellow)
                         Fill = null
                     }
                     //  new ColumnSeries<double>
                     //{
                     //    Name = "Sales Diagram2",
                     //    Values = values2,
                     //    Fill = new SolidColorPaint(SkiaSharp.SKColors.Indigo)
                     //},
                },
                ForeColor = Color.Coral,
                BackColor = Color.LightYellow,
                //Title = "My Chart",
                //LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom
            };
            chart.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Sales",
                    NamePaint = new SolidColorPaint(SkiaSharp.SKColors.Orange),
                    LabelsPaint = new SolidColorPaint(SkiaSharp.SKColors.Blue)
                }
            };
            chart.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Months",
                    MinLimit = 1,
                    MinStep = 1,
                    NamePaint = new SolidColorPaint(SkiaSharp.SKColors.Violet),
                    LabelsPaint = new SolidColorPaint(SkiaSharp.SKColors.Green)
                }
            };

            //this.Controls.Add(chart);
            panel1.Controls.Add(chart);
        }

        private void UpdateChart()
        {
            chart.Series.First().Values = values; // Оновлюємо значення серії без створення нової серії
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            values.Add((double)numericValue.Value);
            listBox1.DataSource = null; // Скидаємо прив'язку даних
            listBox1.DataSource = values; // Повторно прив'язуємо оновлений список
            UpdateChart(); // Оновлюємо діаграму з новими даними    
        }
    }
}
