// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string number2 = Console.ReadLine();
Console.WriteLine("Введите третье число ");
string number3 = Console.ReadLine();
int numberInt1 = int.Parse(number1);
int numberInt2 = int.Parse(number2);
int numberInt3 = int.Parse(number3);
int max = 0;
if (max < numberInt1)
{
    max = numberInt1;
}
if (max < numberInt2)
{
    max = numberInt2;
}
if (max < numberInt3)
{
    max = numberInt3;
}
System.Console.WriteLine($"Самое большое число: {max}");