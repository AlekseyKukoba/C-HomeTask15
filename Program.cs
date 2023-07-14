// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели.");
    return false;
}
bool ifWeekend(int number)
{
    if(number > 5)
    {
        return true;
    }
    return false;
}

if(ValidateWeekday(number))
{
    if(ifWeekend(number))
    {
        Console.WriteLine("-> да");
    }
    else
    {
        Console.WriteLine("-> нет");
    }
}

