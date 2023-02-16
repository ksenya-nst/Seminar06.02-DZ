// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int num = GetNumber("Введите число: ");
int len = NumberLen(num);
SumNumbers(num, len);

int GetNumber(string text)
{
 System.Console.WriteLine(text);
 return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
 int index = 0;
 while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    System.Console.WriteLine($"Сумма цифр числа {num} = {sum}");
}
