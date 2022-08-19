/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
System.Console.WriteLine("введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int sumnumber (int number)
{
int length = Convert.ToString(number).Length;
int sum = 0;
int advance = 0;
for (int i = 0; i <= length; i++)
{
    advance = number - number % 10;
      sum = sum + (number - advance);
      number = number / 10;
}
return sum;
}
//System.Console.WriteLine($"сумма цифр в числе {number} = {sum} "); 
int sumNumber = sumnumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);