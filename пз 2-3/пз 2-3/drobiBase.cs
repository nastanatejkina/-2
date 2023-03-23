
internal class drobiBase
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("B:");
        double b = Convert.ToInt32(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("выражение неверно");
        }
        else
        {
            var result = a / b;
            Console.WriteLine("выражение равно = ");

            Console.WriteLine(result);
        }
    }
}