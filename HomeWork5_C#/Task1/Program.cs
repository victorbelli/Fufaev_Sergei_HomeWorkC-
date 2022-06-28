//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int CountNechetnPoz(int[] massiv)
{
	int sum = 0;
	for(int i = 1; i < massiv.Length; i += 2)
	{
		sum += massiv[i];
	}
	return sum;
}

int[] array = MassivRandom(9);
PrintMassiv(array);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {CountNechetnPoz(array)}");
