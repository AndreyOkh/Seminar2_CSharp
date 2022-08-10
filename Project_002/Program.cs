// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomNumber = new Random().Next(10, 100);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

Console.WriteLine(randomNumber);

if (firstDigit < secondDigit) 
{
    Console.WriteLine(secondDigit);
}
else if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine("Значения равны");
}