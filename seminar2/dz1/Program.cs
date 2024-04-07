System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Некратно");
}