

void Cube (int number)

{
    for (int i=1;i<=number;i++)
    {
        Console.Write(i*i*i+" ");
    }
    
}


Console.WriteLine("Введите число для продолжения ...");

int rez=Convert.ToInt32(Console.ReadLine());

Cube(rez);

