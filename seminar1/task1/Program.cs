Console.Write("Введите переменную a: ");
int aNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите переменную b: ");
int bNumber = Convert.ToInt32(Console.ReadLine());

if (aNumber == bNumber * bNumber)
{
    Console.WriteLine("a = " + aNumber + ", b = " + bNumber + " => да");
}
else
{
    Console.WriteLine("a = " + aNumber + ", b = " + bNumber + " => нет");
}