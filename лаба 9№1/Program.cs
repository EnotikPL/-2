using System;
using System.Collections.Generic;

// Интерфейс, определяющий общие методы для шахматных фигур
interface IChessFigure
{
    void CheckPosition(string[,] field);   // Метод для проверки позиции фигуры на доске
    void PossibleMoves();                  // Метод для определения возможных ходов фигуры
    string ChessAttack(string[,] field);   // Метод для определения атакуемых фигур
    void Print();                          // Метод для вывода информации о возможных ходах
}

// Абстрактный класс, представляющий шахматную фигуру
abstract class ChessFigure : IChessFigure
{
    protected string position;             // Позиция фигуры на доске (например, "e4")
    protected int line;                    // Номер строки на доске (от 1 до 8)
    protected int column;                  // Номер столбца на доске (от 1 до 8)
    protected List<string> moves;         // Список возможных ходов фигуры
    protected string rivals;               // Список атакуемых фигур

    // Метод для проверки позиции фигуры на доске и установки ее в массиве field
    public virtual void CheckPosition(string[,] field)
    {
        // Преобразование позиции фигуры в координаты строки и столбца на доске
        Tuple<int, int> coordinates = ParsePosition(position);
        line = coordinates.Item1;
        column = coordinates.Item2;
        // Установка имени фигуры в массиве field
        field[line, column] = GetType().Name;
    }

    // Метод для определения атакуемых фигур
    public virtual string ChessAttack(string[,] field)
    {
        rivals = "";
        foreach (string e in moves)
        {
            // Преобразование позиции атакуемой фигуры в координаты строки и столбца на доске
            Tuple<int, int> coordinates = ParsePosition(e);
            int col = coordinates.Item2;
            int ln = coordinates.Item1;
            // Если на атакуемой позиции находится фигура, добавляем ее в список rivals
            if (field[ln, col] != null)
                rivals += $"{field[ln, col]} ";
        }
        return rivals;
    }

    // Абстрактный метод для определения возможных ходов фигуры
    public abstract void PossibleMoves();

    // Абстрактный метод для вывода информации о возможных ходах
    public abstract void Print();

    // Метод для преобразования позиции в координаты строки и столбца на доске
    static Tuple<int, int> ParsePosition(string position)
    {
        if (position.Length != 2)
            throw new ArgumentException("Неверный формат позиции");

        char colChar = position[0];
        int row = int.Parse(position[1].ToString());

        if (colChar < 'a' || colChar > 'h' || row < 1 || row > 8)
            throw new ArgumentException("Неверный формат позиции");

        int column = colChar - 'a' + 1;
        return Tuple.Create(row, column);
    }
}

// Класс, представляющий фигуру "Конь"
class Horse : ChessFigure
{
    public Horse(string position)
    {
        this.position = position.ToLower();
    }

    // Метод для определения возможных ходов коня
    public override void PossibleMoves()
    {
        moves = new List<string>();
        // Относительные смещения для всех восьми возможных ходов коня
        int[,] offsets = { { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 }, { 1, 2 }, { -1, 2 }, { 1, -2 }, { -1, -2 } };
        // Проверяем каждое смещение относительно текущей позиции
        for (int i = 0; i < offsets.GetLength(0); i++)
        {
            int x = column + offsets[i, 0];
            int y = line + offsets[i, 1];
            // Если ход в пределах доски, добавляем его в список возможных ходов
            if (x >= 1 && x <= 8 && y >= 1 && y <= 8)
                moves.Add($"{(char)(x + 96)}{y}");
        }
    }

    // Метод для вывода списка атакуемых фигур конем
    public override void Print()
    {
        Console.WriteLine($"Horse - Могу срубить: {rivals}");
    }
}

// Класс, представляющий фигуру "Пешка"
class Pawn : ChessFigure
{
    public Pawn(string position)
    {
        this.position = position.ToLower();
    }

    // Метод для определения возможных ходов пешки
    public override void PossibleMoves()
    {
        moves = new List<string>();
        // Относительное смещение для хода пешкой на одну клетку вперед
        int y = line + 1;
        // Если ход в пределах доски, добавляем его в список возможных ходов
        if (y <= 8)
            moves.Add($"{position[0]}{y}");
        // Если пешка стоит на своей начальной позиции, можно сделать двойной ход
        if (line == 2)
        {
            y = line + 2;
            if (y <= 8)
                moves.Add($"{position[0]}{y}");
        }
    }

    // Метод для вывода списка атакуемых фигур пешкой
    public override void Print()
    {
        Console.WriteLine($"Pawn - Могу срубить: {rivals}");
    }
}

// Класс, представляющий фигуру "Ферзь"
class Queen : ChessFigure
{
    public Queen(string position)
    {
        this.position = position.ToLower();
    }

    // Метод для определения возможных ходов ферзя
    public override void PossibleMoves()
    {
        moves = new List<string>();
        // Проверяем возможные ходы по всем восьми направлениям
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i != 0 || j != 0)
                {
                    int x = column + i;
                    int y = line + j;
                    // Пока ход в пределах доски, добавляем его в список возможных ходов
                    while (x >= 1 && x <= 8 && y >= 1 && y <= 8)
                    {
                        moves.Add($"{(char)(x + 96)}{y}");
                        x += i;
                        y += j;
                    }
                }
            }
        }
    }

    // Метод для вывода списка атакуемых фигур ферзем
    public override void Print()
    {
        Console.WriteLine($"Queen - Могу срубить: {rivals}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[,] field = new string[9, 9];
            // Запрос у пользователя позиции коня
            Console.WriteLine("Введите позицию коня на доске (например, e4):");
            string h_position = Console.ReadLine();
            IChessFigure horse = new Horse(h_position);

            // Запрос у пользователя позиции пешки
            Console.WriteLine("Введите позицию пешки на доске (например, a1):");
            string p_position = Console.ReadLine();
            IChessFigure pawn = new Pawn(p_position);

            // Запрос у пользователя позиции ферзя
            Console.WriteLine("Введите позицию ферзя на доске (например, d8):");
            string q_position = Console.ReadLine();
            IChessFigure queen = new Queen(q_position);

            // Проверка позиций фигур на доске, вычисление и вывод возможных ходов и атак
            horse.CheckPosition(field);
            pawn.CheckPosition(field);
            queen.CheckPosition(field);

            horse.PossibleMoves();
            pawn.PossibleMoves();
            queen.PossibleMoves();

            horse.ChessAttack(field);
            pawn.ChessAttack(field);
            queen.ChessAttack(field);

            horse.Print();
            pawn.Print();
            queen.Print();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp.Message);
        }
    }
}
