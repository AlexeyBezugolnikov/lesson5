double[] array = new double[10];
for (int i = 0; i < 10; i++)
    array[i] = new Random().Next(0, 100);
Console.WriteLine("[" + string.Join(" ", array) + "]");

double max1 = array[0];
double max2 = array[0];

for (int i = 0; i < 10; i++)
{
    if (array[i]>max1)
    max1 = array[i];
}
for (int i = 0; i < 10; i++)
{
    if (array[i] > max2 && array[i] < max1)
    max2 = array[i];
}
Console.WriteLine(max1 - max2);