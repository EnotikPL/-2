
public interface IGoods
{
    void ChangePrice(double newPrice);
    void ChangeQuantity(int delta);
    double CalculateTotalPrice();
    void Print();
}

public abstract class Goods : IGoods
{
    public string name;
    public DateTime registrationDate;
    public double price;
    public int quantity;
    public string document;
    public Goods(string name, DateTime registrationDate, double price, int quantity, string document)
    {
        this.name = name;
        this.registrationDate = registrationDate;
        this.price = price;
        this.quantity = quantity;
        this.document = document;
    }

    public void ChangePrice(double newPrice)
    {
        if (newPrice >= 0)
        {
            price = newPrice;
        }
        else
        {
            Console.WriteLine("Цена не может быть отрицательной.");
        }
    }

    public void ChangeQuantity(int delta)
    {
        if (quantity + delta >= 0)
        {
            quantity += delta;
        }
        else
        {
            Console.WriteLine("Количество товара не может быть отрицательным.");
        }
    }

    public double CalculateTotalPrice()
    {
        return price * quantity;
    }
    public abstract void Print();
}

public class NewGoods : Goods
{
    public NewGoods(string name, DateTime registrationDate, double price, int quantity, string document)
        : base(name, registrationDate, price, quantity, document)
    {
    }
    public override void Print()
    {
        Console.WriteLine($"Наименование: {name}\nДата оформления: {registrationDate.ToShortDateString()}\nЦена: {price:C}\nКоличество: {quantity}\nНомер накладной: {document}\nОбщая стоимость: {CalculateTotalPrice()}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите информацию о продукте:");
            string name = Console.ReadLine();

            Console.Write("Дата оформления (дд-мм-гггг): ");
            DateTime registrationDate;
            while (!DateTime.TryParse(Console.ReadLine(), out registrationDate))
            {
                Console.WriteLine("Неверный формат даты. Пожалуйста, введите в формате (дд-мм-гггг):");
            }

            Console.Write("Цена: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Количество: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Номер накладной: ");
            string document = Console.ReadLine();

            IGoods goods = new NewGoods(name, registrationDate, price, quantity, document);
            goods.Print();

            Console.WriteLine("Введите новую цену товара: ");
            double newPrice = double.Parse(Console.ReadLine());
            goods.ChangePrice(newPrice);

            Console.WriteLine("Введите на сколько увеличить или уменьшить количество товара: ");
            int delta = int.Parse(Console.ReadLine());
            goods.ChangeQuantity(delta);

            Console.WriteLine("Количество товара изменено:");
            goods.Print();
        }
        catch (Exception) { Console.WriteLine("Ошибка ввода!!!"); }
    }
}