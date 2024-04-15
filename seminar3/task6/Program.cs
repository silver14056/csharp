
// чтобы сгенерировать вещественное(double) число, нужно сложить сгенерированное целое со сгенерированным вещественным
// потому что сгенерированное вещественное число может быть от 0 до 1

Random rand = new Random();
double number = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
System.Console.WriteLine("Сгенерированное число: " + number);
