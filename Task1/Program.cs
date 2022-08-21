/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

class Program
{
    static int Sum(int[] array, int i = 0)
    {
        if (i >= array.Length)
            return 0;
        return array[i] + Sum(array, i + 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Введите начальное число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начальное число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int x = n - m + 1;
        int[] array = new int[x];
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = m;
                m++;
            }  
        int result = Sum(array);
        Console.WriteLine("M = " + (m - array.Length) + "; " + "N = " + n + "  Сумма -> " + result);
    }
}
