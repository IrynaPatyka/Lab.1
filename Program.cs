using System;

class Rectangle
{
    private double a;
    private double b;
    public Rectangle(double sideA, double sideB)
    {
        a = sideA;
        b = sideB;
    }
    public bool Correct()
    {
        return a > 0 && b > 0;
    }

    public double Area()
    {
        return a * b;
    }
    public double Perimeter()
    {
        return 2 * (a + b);
    }
    public void Print()
    {
        Console.WriteLine($"Сторона A: {a}");
        Console.WriteLine($"Сторона B: {b}");
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть довжину сторони A: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину сторони B: ");
            double sideB = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(sideA, sideB);

            Console.WriteLine("\nВластивості прямокутника:");
            rectangle.Print();

            if (rectangle.Correct())
            {
                Console.WriteLine($"\nПлоща: {rectangle.Area()}");
                Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
            }
            else
            {
                Console.WriteLine("\nНеприпустимий прямокутник - сторони повинні бути додатними числами.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }
}
