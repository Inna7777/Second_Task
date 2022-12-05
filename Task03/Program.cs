/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/
Console.WriteLine("Введите число от 1 до 7 ");
int nday = Convert.ToInt32(Console.ReadLine());

if (nday >7)
    Console.WriteLine($"Нет такого дня недели");
    else
{
  if (nday == 6 || nday == 7)
  { 
    if (nday == 6)
    {
    Console.WriteLine($"День {nday} (суббота)- является выводным днем ");
    }
    else
    {
    Console.WriteLine($"День {nday} (воскресенье)- является выводным днем ");
    }
   } 
 else
   {
    Console.WriteLine($"День {nday} не является выводным днем");
   }
}