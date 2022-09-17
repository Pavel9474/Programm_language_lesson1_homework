//Additional task 1
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int N = a * -1;
while (N < a-1)
{
   Console.Write($"{N+=1},"); 
}
Console.Write($"{N+1}");
