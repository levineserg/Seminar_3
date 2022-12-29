// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Веедите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count <= number)
// {
//     Console.Write(Math.Pow(count, 2)+" ");
//     count++;
// }
Console.Write("Веедите число ");
int number = Convert.ToInt32(Console.ReadLine());
for(int count = 1; count <= number; count++)
{
    Console.Write(Math.Pow(count, 2)+" ");
}