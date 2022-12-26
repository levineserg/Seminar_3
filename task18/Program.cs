// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Веедите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 1)
{
    Console.WriteLine("Х>0;y>0");
}
else if(a==2)
{
    Console.WriteLine("Х<0;y>0");
}
else if(a==3)
{
    Console.WriteLine("Х<0;y<0");
}
else if(a==4)
{
    Console.WriteLine("Х>0;y<0");
}
else
{
    Console.WriteLine("Такой четверти нет");
}
