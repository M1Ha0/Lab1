try
{
        Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine());
int c = x % 10;
Console.WriteLine($"Число N=:{(x - c) / 10 + c * 100}");
}
catch
{
    Console.WriteLine("Правильно введите данные");
}
