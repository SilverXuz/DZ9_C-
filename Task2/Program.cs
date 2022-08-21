/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

// Это не мое решение. Я пониятия не имею что тут происходит. Не смог понять смысл функции. 
using System;
class GFG
{
    static int ack( int m, int n)
    {
        if (m == 0)
            {
                return n + 1;
            }
        else if ((m > 0) && (n == 0))
            {
                return ack(m - 1, 1);
            }
        else if ((m > 0) && (n > 0))
            {
                return ack(m - 1, ack(m, n - 1));
            } else
        return n + 1;
    }
    public static void Main()
    {
        Console.Write("Введите положительное 1 число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите положительное 2 число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ack(m, n));
    }
}