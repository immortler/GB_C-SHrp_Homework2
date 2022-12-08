/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

string DayOfTheWeek(int weekDay)
{
    if (weekDay == 3)
    {
        return "It's not weekend, but it's Wednesday, my dudes.";
    }    
    else if (weekDay >= 6)
    {
        return "It's weekend. (:";
    }
    else 
    {
        return "It's not weekend.";
    }
}

Console.WriteLine("Enter number of weekday:");
int weekDay = int.Parse(Console.ReadLine() ?? "");
if (weekDay > 7 || weekDay < 1)
{
    Console.WriteLine($"Error: there is no weekday number {weekDay}.");
}
else
{
    Console.WriteLine(DayOfTheWeek(weekDay));
}