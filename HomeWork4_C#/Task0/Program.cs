// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
Console.Write("Введите число B: ");
string ib = Console.ReadLine();
int b = int.Parse(ib);
int i = 0;
long c = 1;
for (i = 1; i <= b; i++)
{
    c = c * a;
}
Console.Write($"{a} в степени {b} равно {c}");

