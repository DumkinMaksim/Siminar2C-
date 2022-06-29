double lengthLine(double xa, double ya, double za, double xb, double yb, double zb)
{
    //d = √ ( x b − x a ) 2 + ( y b − y a ) 2 + ( z b − z a ) 2
    
   
    double linez = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return linez;
}
Console.WriteLine("Введите x первого числа ...");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y первого числа ...");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z первого числа ...");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x второго числа ...");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y второго числа ...");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z второго числа ...");
double zb = Convert.ToDouble(Console.ReadLine());

double rezult=lengthLine(xa, ya, za, xb, yb, zb);

Console.WriteLine("Расстояние равно ..." + rezult);
