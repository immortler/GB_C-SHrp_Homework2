/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int SecondDigitOfThreeDigNumber(int number)
{
    int hundred = number/100;
    int secondDigit = (number - hundred*100)/10;
    return secondDigit;    
}

Console.WriteLine("Enter triple digits number:");
int number = int.Parse(Console.ReadLine() ?? "");

if (number < 100 || number > 999)
{
    Console.WriteLine("Error: number is not triple digits.");
}
else
{
    int result = SecondDigitOfThreeDigNumber(number);
    Console.WriteLine($"Second digit of number {number} is {result}.");
}