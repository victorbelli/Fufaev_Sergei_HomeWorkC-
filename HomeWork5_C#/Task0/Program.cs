// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] MassivRandom(int ChisloElementov)
{
    int[] massiv = new int[ChisloElementov];
    for(int i = 0; i < ChisloElementov; i++)
    {
        massiv[i] = new Random().Next(100, 1000);
    }
    return massiv;
}

void PrintMassiv(int[] massiv)
{
    foreach(int i in massiv)
    {
        Console.Write($"{i} ");
    }
}

int CountChetn(int[] massiv)
{
	int sum = 0;
	foreach(int element in massiv)
	{
		if(element % 2 == 0)sum++;
	}
	return sum;
}

int[] array = MassivRandom(8);
PrintMassiv(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве равно {CountChetn(array)}");
