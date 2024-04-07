System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    // System.Console.WriteLine(number %1000 /100);

    while (number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}