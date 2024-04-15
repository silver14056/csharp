int number = new Random().Next(100, 1000);
Console.WriteLine("Сгенерированное число " + number);

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number = number / 10;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
