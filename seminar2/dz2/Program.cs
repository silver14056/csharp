System.Console.WriteLine("Введите X: ");
int pointX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите Y: ");
int pointY = Convert.ToInt32(Console.ReadLine());

if (pointX != 0 && pointY != 0)
{
    if(pointX > 0)
    {
        if(pointY > 0)
        {
            System.Console.WriteLine("Координатная четверть №1");
        }
        else
        {
            System.Console.WriteLine("Координатная четверть №4");
        }
    }
    else
    {
        if(pointY > 0)
        {
            System.Console.WriteLine("Координатная четверть №2");
        }
        else
        {
            System.Console.WriteLine("Координатная четверть №3");
        }
    }
}
else
{
    System.Console.WriteLine("Краями ходите товарищ!");
}
