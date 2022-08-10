// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"Число {firstNumber} кратно {secondNumber}");
}
else
{
    Console.WriteLine($"Число {firstNumber} не кратно {secondNumber}, остаток {firstNumber % secondNumber}");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}