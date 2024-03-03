
public class Formula
{
    public static double Calculate(double x)
    {
        if (x >= 0.9)
        {
            return 1 / Math.Pow((0.1 + x), 2);
        }
        else if (x < 0.9 && x >= 0)
        {
            return 0.2 * x + 0.1;
        }
        else
        {
            return Math.Pow(x, 2) + 0.2;
        }
    }

    public static void Main()
    {
        double x = -1.5;

        double result = Calculate(x);
        Console.WriteLine("Результат: " + result);
    }
}