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
    System.Console.Write(array[i] + " ");
}

int[] newArray = new int[array.Length / 2];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length -1 -i];
}

Console.WriteLine();

for (int i = 0;i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
