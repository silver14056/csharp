System.Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int c = 1;
    while (number / c >= 1)
    {
        System.Console.Write(number / c % 10 + ", ");
        c = c * 10;
    }
}
else
{
    System.Console.WriteLine("Вы ввели не натуральное число!");
}