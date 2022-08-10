// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = GetRandomNumber(100, 999);

Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 100;
int threeDigit = randomNumber % 10;

Console.WriteLine($"{firstDigit}{threeDigit}");

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}