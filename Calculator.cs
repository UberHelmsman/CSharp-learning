using System.Net.NetworkInformation;

namespace GettingStarted;

public static class Calculator
{
    public static bool TryDivide(double divisible, double diviser, out double result)
    {
        result = 0;
        if (diviser == 0)
        {
            return false;
        }
        result = divisible / diviser;
        return true;
    }
    public static double CalcTriangleSquare(double ab, double bc, double ac)
    {
        double p = (ab + bc + ac) / 2;

        return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    }

    public static double CalcTriangleSquare(double b, double h)
    {
        return 0.5 * b * h;
    }

    public static double Average(int[] numbers)
    {
        double sum = 0;
        foreach (int v in numbers)
        {
            sum += v;
        }
        return sum / numbers.Length;
    }

    public static double Average2(params int[] numbers)
    {
        double sum = 0;
        foreach (int v in numbers)
        {
            sum += v;
        }
        return sum / numbers.Length;
    }

    public static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
    {
        if (isInRadians)
        {
            return 0.5 * ab * ac * Math.Sin(alpha);
        }
        else
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(rads);
        }

    }
}