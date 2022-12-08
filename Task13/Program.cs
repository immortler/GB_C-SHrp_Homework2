/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter number:");
int number = int.Parse(Console.ReadLine() ?? "");

if (number < 100)
{
    Console.WriteLine("There is no third digit. :(");
}
else
{
    int i = 1;
    int tmp1 = number;
    for(i = 1; tmp1 >= 10; i++)
    {
        int tmp2 = tmp1 / 10;
        tmp1 = tmp2;       
    }
    int tenInPower = Convert.ToInt32(Math.Pow (10, i-2));
    tmp1 = number/tenInPower;
    int thrdDigit = (number - tmp1*tenInPower)/(Convert.ToInt32(Math.Pow (10, i-3)));
    
    Console.WriteLine($"Third digit of number {number} is {thrdDigit}.");
}