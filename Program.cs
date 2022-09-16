// Task 2
Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else if(b > a)
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine("Числа равны");
}

