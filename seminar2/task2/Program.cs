System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int midleDigit = number / 10 % 10;
    int rightDigit = number % 10;
    int result = 1;

    for(int i = 0; i <rightDigit; i++)
    {
        result *= midleDigit; 
    }
    System.Console.WriteLine(result);
}else
{
    System.Console.WriteLine("Введено не трёхзначное число!");
}
