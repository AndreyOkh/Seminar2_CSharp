// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number = 0;

number = ReadInt("Введите число: ");

if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Нет");
}
else 
{
    Console.WriteLine("Введеное число не соответствует дням недели.");
}

/*--------------------Functions--------------------*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}