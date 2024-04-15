
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// System.Console.WriteLine("Введите элементы массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine($"{i}-й элемент массива");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Random rand = new Random();  

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}