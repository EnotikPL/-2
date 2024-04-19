namespace Лаба_10__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            trackBar1.LargeChange = 1;
            trackBar1.SmallChange = 1;

            int n = trackBar1.Value;
            textBox1.Text = $"{n}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            double n = Convert.ToDouble(num);
            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum += Math.Pow(-1, i - 1) * Math.Pow(i, 5);
            }
            textBox2.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            int n = Convert.ToInt32(num);
            double sum2 = (0.25) * (1 + Math.Pow(-1, n) * (5 * Math.Pow(n, 2) - 5 * Math.Pow(n, 4) - 2 * Math.Pow(n, 5) - 1));
            textBox2.Text = sum2.ToString();
        }
    }
}
