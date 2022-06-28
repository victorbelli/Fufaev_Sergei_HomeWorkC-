// // Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] MassivRandom(int ChisloElementov)
{
    double[] massiv = new double[ChisloElementov];
    for(int i = 0; i < ChisloElementov; i++)
    {
        massiv[i] = new Random().NextDouble()*1000;
    }
    return massiv;
}

void PrintMassiv(double[] massiv)
{
    foreach(double i in massiv)
    {
        Console.Write($"{i:f3} ");
    }
}

double FoundMaxMin(double[] massiv, string bolsheMen)
{
	double rez = massiv[0];
	foreach(double element in massiv)
	if(bolsheMen == "max")
	{
		if(element > rez ) rez = element;
	}
	else 
	{
		if(element < rez ) rez = element;
	}
	return rez;
}

double[] array = MassivRandom(8);
PrintMassiv(array);
Console.WriteLine();
double min = FoundMaxMin(array, "min");
double max = FoundMaxMin(array, "max");
Console.WriteLine($"Разница между максимальным {max:f3} и минимальным элементов массива {min:f3} равна {(max - min):f3}");