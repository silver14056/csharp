
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

Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    { 
        numberIsFinded = true;
        break;
    }
}

if (numberIsFinded)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}