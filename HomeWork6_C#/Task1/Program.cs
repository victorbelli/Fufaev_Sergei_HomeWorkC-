// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int prompt(string message)
{
Console.WriteLine(message);
string NumberStr = Console.ReadLine();
int Number = int.Parse(NumberStr);
return Number;
} 

double k1 = prompt("Введите число k1=> ");
double k2 = prompt("Введите число k2=> ");
double b1 = prompt("Введите число b1=> ");
double b2 = prompt("Введите число b2=> ");

double x = (b2 - b1)/(k1-k2);
double y = k1 * (b2 - b1)/(k1 - k2) + b1;

Console.WriteLine($"Точка пересечения двух прямых равна - ({x:f2}, {y:f2})"); 