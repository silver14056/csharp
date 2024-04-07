Console.Write("Введите большее число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите меньшее число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}