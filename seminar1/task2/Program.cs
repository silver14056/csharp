Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int i = -number;
    while (i <= number)
    {
        System.Console.Write(i + " ");
        i++;
    }
}
else
{
    System.Console.WriteLine("Вы ввели некорректное значение!");
}