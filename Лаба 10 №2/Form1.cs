namespace Лаба_10__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;
                int n = Convert.ToInt32(num);
                double sum = 0;
                for (double i = 0; i <= n; i++)
                {
                    sum += Math.Pow(i, 2);
                }
                textBox2.Text = sum.ToString();
            }
            catch (Exception ) { textBox2.Text = "Ошибка ввода"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;
                int n = Convert.ToInt32(num);
                double sum2 = n * (n + 1) * (2 * n + 1) / 6;
                textBox2.Text = sum2.ToString();
            }
            catch (Exception) { textBox2.Text = "Ошибка ввода"; }
        }
    }
}
