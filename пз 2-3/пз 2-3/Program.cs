using System;

class Fraction1
{
    private int first;
    private int second;

    public Fraction1(int first, int second)
    {
        this.first = first;
        this.second = second;
    }

    public void Read()
    {
        Console.Write("Введите числитель: ");
        first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите знаменатель: ");
        second = Convert.ToInt32(Console.ReadLine());

        if (second == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю.");
        }
    }

    public void Display()
    {
        Console.WriteLine("{0}/{1}", first, second);
    }

    public int ipart()
    {
        if (second == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю.");
        }

        return first / second;
    }
}
