namespace GettingStarted;

public class Rect
{
    public int Width { get ; set;}
    public int Height { get ; set;}
}


public class Square : Rect
{

}


public class AreaCalculator
{
    public static int CalcSquare(Square square)
    {
        return square.Width * square.Width;
    }

    public static int CalcSquare(Rect rect)
    {
        return rect.Width * rect.Height;
    }
}