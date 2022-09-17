// Additional task 2
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if ((a < 1000) && (a > 99))
{
   Console.WriteLine("Последняя цифра числа: "+b[2]); 
}
else
{
    Console.WriteLine("Введите трехзначное число");
}