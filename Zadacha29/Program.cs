// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine);
}

int[] arr = new int[8];
var rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 100);
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}