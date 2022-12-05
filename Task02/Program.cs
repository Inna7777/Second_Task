/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
Console.WriteLine("Введите число ");
string nStr = Console.ReadLine() ??"";
string [] mas = nStr.Select(i => i.ToString()).ToArray();

 if ( nStr.Length < 3 )
     {
        Console.WriteLine("В веденном числе третьей цифры нет");
      }
   else
   {
    Console.WriteLine(mas[2]);
   }          
