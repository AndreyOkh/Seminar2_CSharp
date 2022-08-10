// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomNumber = GetRandomNumber(10, 99);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

Console.WriteLine(randomNumber);

Console.WriteLine(Max(firstDigit, secondDigit));

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int Max (int a, int b)
{
    int max = 0;
    if (a > b) 
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}