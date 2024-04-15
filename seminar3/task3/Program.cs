System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "\t");
}

for (int i = 0;i < array.Length; i++)
{
    array[i] *= -1;
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}