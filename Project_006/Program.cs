// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

if (IfSqr(firstNumber, secondNumber) || IfSqr(secondNumber, firstNumber))
{
    Console.WriteLine($"Yes");
}
else
{
    Console.WriteLine($"No");
}

bool IfSqr (int a, int b)
{
    return a * a == b;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}