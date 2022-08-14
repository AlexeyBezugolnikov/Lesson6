Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");

int[] array = new int[n];
for (int i=0; i < n; i++)
    array[i]=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = 0;
for (int i=0; i < n; i++)
{
    if (array[i] > 0)
    count++;
}
Console.WriteLine("Количество чисел больше нуля: " + count);