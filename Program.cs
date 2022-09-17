// Task 8
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int N = 0;
while (N < a-3)
{
   Console.Write($"{N+=2},"); 
}
Console.Write($"{N+2}");