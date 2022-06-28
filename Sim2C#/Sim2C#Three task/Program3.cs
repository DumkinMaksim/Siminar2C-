void Week()
{
//программа по обработке номера дня находит рабочий день или нет    
   int days ;
   Console.Write("Enter number of day :");
   days=Convert.ToInt32(Console.ReadLine());
// yes is a working day
    if (days==1) 
   {
        Console.Write("Manday -is a  working day");
    }
    if (days==2) 
   {
        Console.Write("Tuesday -is a  working day");
    }
    if (days==3) 
   {
         Console.Write("Wednesday -is a  working day");
    }
    if (days==4) 
   {
        Console.Write("Thursday -is a  working day");
    }
    if (days==5) 
   {
        Console.Write("Friday -is a  working day");
    }
//no -not working day    
    if (days==6) 
   {
        Console.Write("Saturday -is a day off");
    }
    if (days==7) 
   {
        Console.Write("Sunday -s a day off");
    }
//error)    
    if (days<=0 | days>=8) 
   {
        Console.Write("The day of the week is entered incorrectly");
    }
}
Week();

