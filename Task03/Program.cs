// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт
// таблицу кубов чисел от N до M.

// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите первое число:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int m = int.Parse(Console.ReadLine());

if (n > m) Console.WriteLine("Первое число больше второго. Введите другие числа");
else
{
    int result = n;
    Console.WriteLine("Таблица кубов между числами:");
    while (n <= m)
    {
        Console.WriteLine(Math.Pow(result, 3));
        n++;
        result++;
    }
}