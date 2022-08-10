// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = ReadInt("Введите число: ");
int numberConvert = ConvertThreeDigit(number);



if (numberConvert < 100)
{
    Console.WriteLine($"В числе {numberConvert} нет третьей цифры.");
}
else
{
    Console.WriteLine(numberConvert % 10);
}

/*--------------------Functions--------------------*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ConvertThreeDigit (int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number;
}