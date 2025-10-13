using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.WriteLine("введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x");
double x = Convert.ToDouble(Console.ReadLine());
Mat z = new Mat (a, b, x);
Console.WriteLine(z.one);
Console.WriteLine(z.two);
Console.WriteLine(z.three);
Console.WriteLine("введите a");
double g1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b");
double g2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x");
double g3 = Convert.ToDouble(Console.ReadLine());
Mat o = new Mat(g1, g2, g3);
Console.WriteLine(o.one);
Console.WriteLine(o.two);
Console.WriteLine(o.three);
Console.WriteLine("введите a");
double f1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b");
double f2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x");
double f3= Convert.ToDouble(Console.ReadLine());
Mat v = new Mat(f1, f2, f3);
Console.WriteLine(v.one);
Console.WriteLine(v.two);
Console.WriteLine(v.three);
class Mat
{
    double a;
    double b;
    double x;
    double s = 1;
    public Mat(double a, double b, double x)
    {
        this.a = a;
        this.b = b;
        this.x = x;
    }
    public double one()
    {
        return 3 * this.x + 5;
    }
    public double two()
    { 
            return (this.a + this.b) / (this.a - this.b);
    }
    public double three()
    {
        for (int i = 1; i <= (this.a * this.x / this.b); i++)
        {
            s *= i;
        }
        return s;
    }
}
