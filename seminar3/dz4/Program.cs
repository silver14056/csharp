int number = new Random().Next(1, 100000);
Console.WriteLine("Сгенерированное число: " + number);


int count = 0;
int num = number;

while (true)
{
    num = num / 10;
    count++;
    
    if (num == 0)
    { break; }
    
}
num = number;

int[] array = new int[count];

for (int i = array.Length -1; i >= 0; i--)
{
    array[i] = num % 10;
    num = num / 10;
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}