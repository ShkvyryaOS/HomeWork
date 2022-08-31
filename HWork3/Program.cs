//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
void Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx=x2-x1;
    double dy=y2-y1;
    double dz=z2-z1;
    double dist=Math.Round(Math.Sqrt(Math.Pow(dx, 2) +Math.Pow(dy, 2)+Math.Pow(dz, 2)),2);
    Console.WriteLine($"Расстояние между точками А и В равно {dist}");
}

Console.WriteLine("Введите координаты точки А:");
Console.Write("x1=");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("z1=");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введены координаты точки А:{x1};{y1};{z1};");
Console.WriteLine("Введите координаты точки B:");
Console.Write("x2=");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("z2=");
double z2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введены координаты точки B:{x2};{y2};{z2};");

Dist(x1,y1,z1,x2,y2,z2);

*/
/*
// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int Num)
{ int i=1;
while (i<=Num)
{
   double cube=Math.Pow (i,3);
   Console.WriteLine($"{i} в степени 3 равно {cube}");
   i++;
}}
Console.WriteLine("Введите натуральное число");
int Num= Convert.ToInt32(Console.ReadLine());
Cube (Num);
*/
/*
//Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrome(int num)
{
    if (num/10000==num%10 && (num/10)%10==(num/1000)%10)
    {Console.WriteLine("Число является палиндромом");}
else
{Console.WriteLine("Число НЕ является палиндромом");}
}

Console.WriteLine("Введите натуральное пятизначное число");
int num= Convert.ToInt32(Console.ReadLine());
Palindrome(num);
*/