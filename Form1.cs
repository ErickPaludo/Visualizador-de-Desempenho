using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ViewDesemp
{
    public partial class Form1 : Form
    {
        Monitor monitor = new Monitor();
        SalvarDados savelogs = new SalvarDados();
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InicializarTimer();
            InitializeComponent();
            InicializarTimer();
            ramtotal.Visible = true;
            ramusada.Visible = true;
        }
        private void InicializarTimer()
        {
            // Cria um Timer que chama a função AtualizarLabel a cada 10 segundos
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(AtualizarLabel);
            timer.Interval = 1000;
            timer.Start();
        }

        private void AtualizarLabel(object sender, EventArgs e)
        {
            GraficoRAM();
            GraficoCPU();
            savelogs.GravarDados();
            ramtotal.Text = monitor.RAMTOTAL();
            ramusada.Text = monitor.RAMUSADA();
        }
        public void GraficoRAM()
        {
            Series series = new Series("MySeries");
            chart1.Series.Clear();


            series.ChartType = SeriesChartType.Pie;


            series.Points.AddXY($"Livre {100 - Convert.ToInt64(monitor.RAMPORCENTAGEM())}%", 100 - Convert.ToInt64(monitor.RAMPORCENTAGEM()));
            series.Points.AddXY($"USADA {monitor.RAMPORCENTAGEM()}%", monitor.RAMPORCENTAGEM());

            chart1.Series.Add(series);
        }
        public void GraficoCPU()
        {

            Series series2 = new Series("MySeries");
            chart2.Series.Clear();


            series2.ChartType = SeriesChartType.Pie;

            ulong cpu = ulong.Parse(monitor.CPU());
            series2.Points.AddXY($"LIVRE {100 - cpu}%", 100 - cpu);
            series2.Points.AddXY($"OCUPADA {cpu + 1}%", cpu + 1);

            chart2.Series.Add(series2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ramusada_Click(object sender, EventArgs e)
        {
        }

        private void ramtotal_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}