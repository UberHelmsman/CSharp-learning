namespace GettingStarted;

public struct PointVal
{
    public int X;
    public int Y;

    public void LogValues(){
        System.Console.WriteLine($"x = {X} y = {Y}");
    }
}


public class PointRef
{
    public int X;
    public int Y;

    public void LogValues(){
        System.Console.WriteLine($"x = {X} y = {Y}");
    }
}