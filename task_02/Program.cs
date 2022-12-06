// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int [3];
Console.WriteLine($"Введите координаты точки A:");
A[0] = Convert.ToInt32(Console.ReadLine());
A[1] = Convert.ToInt32(Console.ReadLine());
A[2] = Convert.ToInt32(Console.ReadLine());

int[] B = new int [3];
Console.WriteLine($"Введите координаты точки B:");
B[0] = Convert.ToInt32(Console.ReadLine());
B[1] = Convert.ToInt32(Console.ReadLine());
B[2] = Convert.ToInt32(Console.ReadLine());

double q = Math.Round(Math.Sqrt(Math.Pow((B[0]-A[0]), 2) + Math.Pow((B[1]-A[1]), 2) + Math.Pow((B[2]-A[2]), 2)), 2);

Console.WriteLine($"Длина отрезка: {q}");
