// Math.Sqrt() - нахождение квадратного корня
// Math.Pow(переменная, степень) - возведение в степень
// Math.Round(переменная, количество знаков до которого округлить) - округление числа
// double - числа с запятой
// 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Веедите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите координату y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите координату x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите координату y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
double distans = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine("Расстояние между точками " + Math.Round(distans, 2));
