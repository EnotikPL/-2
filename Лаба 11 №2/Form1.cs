using System.Text;

namespace Лаба_11__2
{
    public partial class Form1 : Form
    {
        class Znak
        {
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string ZodiacSign { get; set; }

            public override string ToString()
            {
                return $"{FullName}; {DateOfBirth.ToShortDateString()}; {ZodiacSign}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<Znak> notes = new List<Znak>();
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new();
            List<string> firstNames = new() { "Евгений", "Максим", "Александр", "Данил", "Алексей", "Фёдор", "Емельян", "Георгий", "Иван", "Кирилл" };
            List<string> lastNames = new () { "Самойлов", "Михайлов", "Кемеров", "Достоевский", "Ваянт", "Давыдов", "Онегин", "Топский", "Толстой", "Медведев" };
            notes.Clear();
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                Znak Znak = new Znak
                {
                    FullName = $"{firstNames[random.Next(firstNames.Count)]} {lastNames[random.Next(lastNames.Count)]}",
                    DateOfBirth = GenerateRandomDateOfBirth(random)
                };

                int month = Znak.DateOfBirth.Month;
                int day = Znak.DateOfBirth.Day;
                string zodiacSign = "";
                if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                    zodiacSign = "Овен";
                else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                    zodiacSign = "Телец";
                else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                    zodiacSign = "Близнецы";
                else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                    zodiacSign = "Рак";
                else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                    zodiacSign = "Лев";
                else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                    zodiacSign = "Дева";
                else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                    zodiacSign = "Весы";
                else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                    zodiacSign = "Скорпион";
                else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                    zodiacSign = "Стрелец";
                else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                    zodiacSign = "Козерог";
                else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                    zodiacSign = "Водолей";
                else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                    zodiacSign = "Рыбы";

                Znak.ZodiacSign = zodiacSign;
                notes.Add(Znak);
            }

            using (StreamWriter writer = new StreamWriter("spisok.txt"))
            {
                foreach (var Znak in notes)
                {
                    writer.WriteLine($"{Znak.FullName},{Znak.DateOfBirth.ToShortDateString()}");
                }
            }
            foreach (var Znak in notes)
            {
                listBox1.Items.Add($"{Znak.FullName}, {Znak.DateOfBirth.ToShortDateString()}, {Znak.ZodiacSign}");
            }
        }

        private DateTime GenerateRandomDateOfBirth(Random random)
        {
            int year = DateTime.Now.Year - random.Next(60);
            int month = random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int day = random.Next(1, daysInMonth + 1);
            return new DateTime(year, month, day);
        }


        private void Cleaner_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            File.WriteAllText("spisok.txt", string.Empty);
            MessageBox.Show("Списки очищены");
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Список пуст. Пожалуйста, сначала сгенерируйте данные.");
                return;
            }
            notes.Sort((x, y) => x.DateOfBirth.CompareTo(y.DateOfBirth));
            listBox2.Items.Clear();
            foreach (var Znak in notes)
            {
                listBox2.Items.Add($"{Znak.FullName} - {Znak.DateOfBirth.ToShortDateString()} - {Znak.ZodiacSign}");
            }
            MessageBox.Show("Список отсортирован по дате рождения");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchZodiacSign = textBox1.Text;
            var results = notes.Where(x => x.ZodiacSign.Equals(searchZodiacSign, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Any())
            {
                StringBuilder resultMessage = new StringBuilder();
                foreach (var result in results)
                {
                    resultMessage.AppendLine($"Нашёлся! {result.FullName} - {result.DateOfBirth.ToShortDateString()} - {result.ZodiacSign}");
                }
                MessageBox.Show(resultMessage.ToString());
            }
            else
            {
                MessageBox.Show("Людей с таким знаком зодиака нет.");
            }
        }

    }
}
