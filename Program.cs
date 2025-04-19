using GettingStarted;

PointVal a;
a.X = 3;
a.Y = 5;

PointVal b = a;

b.X = 7;
b.Y = 10;

a.LogValues();
b.LogValues();

System.Console.WriteLine("now working with pointref");



PointRef c = new PointRef
{
    X = 3,
    Y = 5
};

PointRef d = c;

d.X = 7;
d.Y = 10;

c.LogValues();
d.LogValues();

