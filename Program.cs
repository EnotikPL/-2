public interface IMoney
{
    void Print();
    double TotalAmount();
}

public abstract class Money : IMoney
{
    public long Rubles { get; set; }
    public int Kopecks { get; set; }

    public Money(long rubles, int kopecks)
    {
        Rubles = rubles;
        Kopecks = kopecks;
    }

    public abstract void Print();

    public abstract Money Add(Money new_money);
    public abstract Money Subtract(Money new_money);
    public abstract Money Divide(double divisor);
    public abstract Money Multiply(double multiplier);

    public double TotalAmount()
    {
        return Rubles + Kopecks / 100.0;
    }
}

public class MoneyOperation : Money
{
    public MoneyOperation(long rubles, int kopecks) : base(rubles, kopecks)
    {
    }

    public override Money Add(Money new_money)
    {
        long totalKopecks = Rubles * 100 + Kopecks + new_money.Rubles * 100 + new_money.Kopecks;
        return new MoneyOperation(totalKopecks / 100, (int)(totalKopecks % 100));
    }

    public override Money Subtract(Money new_money)
    {
        long totalKopecks = Rubles * 100 + Kopecks - (new_money.Rubles * 100 + new_money.Kopecks);
        return new MoneyOperation(totalKopecks / 100, (int)(totalKopecks % 100));
    }

    public override Money Divide(double divisor)
    {
        long totalKopecks = Rubles * 100 + Kopecks;
        return new MoneyOperation((long)(totalKopecks / divisor) / 100, (int)((totalKopecks / divisor) % 100));
    }

    public override Money Multiply(double multiplier)
    {
        long totalKopecks = Rubles * 100 + Kopecks;
        return new MoneyOperation((long)(totalKopecks * multiplier) / 100, (int)((totalKopecks * multiplier) % 100));
    }

    public override void Print()
    {
        Console.WriteLine($"{Rubles},{Kopecks:D2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите информацию о первой сумме:");

            Console.Write("Введите количество рублей для первой суммы: ");
            long rubles1 = long.Parse(Console.ReadLine());

            Console.Write("Введите количество копеек для первой суммы: ");
            int kopecks1 = int.Parse(Console.ReadLine());

            Money m1 = new MoneyOperation(rubles1, kopecks1);

            Console.WriteLine("\nВведите информацию о второй сумме:");

            Console.Write("Введите количество рублей для второй суммы: ");
            long rubles2 = long.Parse(Console.ReadLine());

            Console.Write("Введите количество копеек для второй суммы: ");
            int kopecks2 = int.Parse(Console.ReadLine());

            Money m2 = new MoneyOperation(rubles2, kopecks2);

            Money m3 = m1.Add(m2);
            Money m4 = m1.Subtract(m2);
            Money m5 = m1.Divide(1.5);
            Money m6 = m1.Multiply(2.5);

            Console.WriteLine("\nРезультаты операций:");
            Console.Write("Первая сумма: "); m1.Print();
            Console.Write("Вторая сумма: "); m2.Print();
            Console.Write("Их сумма: "); m3.Print();
            Console.Write("Разность: "); m4.Print();
            Console.Write("Деление: "); m5.Print();
            Console.Write("Умножение: "); m6.Print();

            if (m1.TotalAmount() > m2.TotalAmount())
                Console.WriteLine("\nСумма 1 больше суммы 2");
            else if (m1.TotalAmount() < m2.TotalAmount())
                Console.WriteLine("\nСумма 1 меньше суммы 2");
            else
                Console.WriteLine("\nСуммы равны");
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода!!! Вводи циферки, а букавки!");
        }
    }
}