static double y1(double a, double b, double c, double d) =>
    2 * Math.Sqrt((Math.Sin(a) / Math.Abs(Math.Tan(b - a))) + (Math.Log(c) / d)); //#14


static double y2(double a, double b, double c, double d) =>
     2 * Math.Cos(Math.Pow(a, b)) + Math.Abs(Math.Acos(-Math.Sqrt(c / d))); //#5


static double y3(double a, double b, double c, double d) => 
    (5 * c) / Math.Cos(a) + Math.Sqrt(Math.Sinh(Math.Abs(b) * c) / Math.Tan(d)); //#23


Console.WriteLine($"y1 = {y1(1.54, 0.49, 24.1, 0.87)}");
Console.WriteLine($"y2 = {y2(2.54, 1.23, -2.14, -0.23)}");
Console.WriteLine($"y3 = {y3(-3.45, -2.34, 1.45, 0.83)}");

