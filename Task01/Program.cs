/*Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/
Console.WriteLine("Введите трехзначное число ");
string nStr = Console.ReadLine() ??"";
int n = Convert.ToInt32(nStr);
n =Math.Abs(n);
int ntwo = n / 10 % 10;
     Console.WriteLine ( ntwo+ " второе числo");