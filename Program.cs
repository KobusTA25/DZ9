/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);
void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.WriteLine(n);
    PrintNumbers(n - 1);
}

*/
/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(m, n);
int SumNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        return m + SumNumbers(m + 1, n);
    }
Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", m, n, sum);

*/

/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(m, n);
int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    Console.WriteLine("Функция Аккермана для чисел {0} и {1} равен = {2}", m, n, result);
*/