// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int firstArg = 7;
int secondArg = 23;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % firstArg == 0 && number % secondArg == 0)
{
    Console.WriteLine($"{number} кратно {firstArg} и {secondArg}");
}
else
{
    Console.WriteLine($"{number} не кратно {firstArg} и {secondArg}");
}