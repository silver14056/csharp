System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine($"{firstNumber}, {secondNumber} => да");
}
else
{
    System.Console.WriteLine($"{firstNumber}, {secondNumber} => нет");
}
