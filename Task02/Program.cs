// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату точки А по оси Х:");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Y:");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Z:");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату точки B по оси Х:");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Y:");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Z:");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine(Math.Round(result, 2)); 