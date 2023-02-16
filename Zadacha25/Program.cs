// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetNumber("Введите число A: ");
int num2 = GetNumber("Введите число B: ");

System.Console.WriteLine($"Число {num1} в степени {num2} = {Math.Pow(num1, num2)}");