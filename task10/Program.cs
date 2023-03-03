/*// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5



Console.WriteLine("Введите трехзначаное число");
int a = Convert.ToInt32(Console.ReadLine());

int Num2Prompt(int a)
{
    return (a/10) % 10;   
}

Console.WriteLine(Num2Prompt(a));

Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет


int getnumber(string message)
{
    Console.WriteLine(message);
    string? a = Console.ReadLine();
    int b = Convert.ToInt32(a);
    return b;
}

int rank3(int number)
{
    while (number>999)
    {
        number = number /10;
    }
    return number %10;
}

bool Check( int number)
{
    if (number<100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = getnumber("Введи число");
if (Check(number))
{
    Console.WriteLine(rank3(number));
}

Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

byte WeekDayPrompt(string message)
{
    Console.WriteLine(message);
    string? a = Console.ReadLine();
    byte b = Convert.ToByte(a);
    return b;
}

byte number = WeekDayPrompt("Введите день недели с помощью цифры");

bool Validate(byte number)
{
    if (number>7)
    {
        Console.WriteLine("Недействительное число");
        return false;
    }
    return true;
}
if (Validate(number))
{
    if(number > 5)
    {
        Console.WriteLine("да");

    }
    else
    {
        Console.WriteLine("нет");
    }
}
    