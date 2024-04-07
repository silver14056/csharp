System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(result);
}else
{
    System.Console.WriteLine("Введено не трёхзначное число!");
}