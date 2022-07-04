// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int prompt(string message)
{
Console.WriteLine(message);
string NumberStr = Console.ReadLine();
int Number = int.Parse(NumberStr);
return Number;
} 

int M = prompt("Какое количество чисел будете вводить? ");
int sum = 0;
for(int i = 0; i < M; i++)
{
int a = prompt("Введите число=> ");
if(a > 0)
	{
		sum++;
	}

}
Console.WriteLine($"Количество чисел больше нуля - {sum}");