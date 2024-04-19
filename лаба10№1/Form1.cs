namespace лаба10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAmount_Click(object sender, EventArgs e)
        {
            try
            {
                string TB = TextBook.Text;
                string TBCost = TextBookCost.Text;
                string P = Pencil.Text;
                string PCost = PencilCost.Text;

                int new_TB = Convert.ToInt32(TB);
                int new_TBCost = Convert.ToInt32(TBCost);
                int new_P = Convert.ToInt32(P);
                int new_Pcost = Convert.ToInt32(PCost);

                int summ = new_TB * new_TBCost + new_P * new_Pcost;
                textBoxSumm.Text = summ.ToString();
            }
            catch (Exception)
            { textBoxSumm.Text = "Ошибка ввода"; }
        }
    }
}
