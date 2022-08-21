/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

string f(int m, int n)
{
    if (n == m)
        return Convert.ToString(m);
    return f(m, n - 1) + ", " + Convert.ToString(n);
}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
