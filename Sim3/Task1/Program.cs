// Programms "Palindrom
void FindPolindrom()
{
int inputnum, sim1, sim2, sim4, sim5, krat;
Console.WriteLine("Enter 5-digital numbers:  ");
string linepol = Console.ReadLine();
krat =Convert.ToInt32(linepol.Length);
inputnum = Convert.ToInt32(linepol);
if (krat == 5)
{
    sim1 = inputnum / 10000;
    sim2 = inputnum / 1000 - sim1 * 10;
    sim4 = inputnum % 100 / 10;
    sim5 = inputnum % 10;
   if (sim1 == sim5 && sim2 == sim4)
        {
            Console.WriteLine("Palindrome");
            Console.WriteLine("1s=5s " + sim1 + " = " + sim5);
            Console.WriteLine("2s=4s " + sim2 + " = " + sim4);
        }
    else
    {
        Console.WriteLine("No palindrome"); 
    } 
}      
else
{
   Console.WriteLine("The number is not a five-digit number, it consists-> " + krat+" of numbers");
}         
}
FindPolindrom();

    

