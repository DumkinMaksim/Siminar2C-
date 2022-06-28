//Задача которая выводит третью цифру
/*
int  krat,index;
char[] array;
// krat10, krat100, krat1000, krat10000
Console.Write("Enter the number: ");
string nums=Console.ReadLine();
 array = nums.ToCharArray();
krat=nums.Length;
if (krat<3)
{
    Console.WriteLine("a number less than three digits");
}
else
{
   for(index = 0; index < nums.Length; index++)
    {
        array[index] = nums[index];

    }
    Console.WriteLine("a number less than three digits:  "+array[2]);
}

*/

int  krat,rez,prez,numstwo,stepen;
Console.Write("Enter the number: ");
string nums=Console.ReadLine();
krat=nums.Length;
if (krat<3)
{
  Console.WriteLine("In a number less than three digits");  
}    
else
{
    prez=Convert.ToInt32(nums);
    stepen = Convert.ToInt32(Math.Pow(10,krat-3));
    numstwo=prez/stepen;
    rez=numstwo%10;
    Console.WriteLine("A number less than three digits:  "+rez);
}    