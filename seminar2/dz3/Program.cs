System.Console.WriteLine("Введите положительное двухзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <=99)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine(firstNumber);
    }
    else
    {
        System.Console.WriteLine(secondNumber);
    }
}
else
{
    System.Console.WriteLine("Вы ввели неверное число!");
}