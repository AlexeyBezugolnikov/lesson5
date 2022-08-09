int[] array = new int[10];
for (int i= 0; i < 10; i++)
    array[i] = new Random().Next(-10, 11);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int sum_l = 0;

for (int i = 0; i < 10; i++)
{
    if (i%2 != 0)
    sum_l=array[i]+sum_l;

}
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum_l);