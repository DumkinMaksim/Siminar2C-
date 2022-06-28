//A program for finding the second number from a three-digit number
/*
void FIndmax()
{
    int ramd=new Random().Next(100,1000);
    Console.WriteLine("A three-digit number has been generated  "+ramd);
    int sot=ramd / 10;
    int ntwo=sot%10;
    Console.WriteLine("The second number->  "+ntwo);
}
FIndmax();
*/
//Задача по поиску второго числа из введенного трехзначного
int SecondNumber()
{
 int nums, krat, rez;
 Console.Write("Enter a three-digit number: ");
 nums= Convert.ToInt32(Console.ReadLine());
 krat=nums/10;
 rez=krat%10;
 Console.Write(nums+"->the second number: ");
 return rez;
}
int numberTwo=SecondNumber();
Console.WriteLine(numberTwo);
