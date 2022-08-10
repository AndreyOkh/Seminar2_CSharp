// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = 0;

number = ReadInt("Введите трехзначное число: ");

if (GetIf(number)) 
{
    GetTwoDigit(number);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным.");
}


/*--------------------Functions--------------------*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void GetTwoDigit (int number)
{
    int twoDigit = (number / 10) % 10;
    Console.WriteLine(twoDigit);
}

bool GetIf (int number)
{
    return number > 99 && number < 1000;
}