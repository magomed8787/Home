Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
if((a > b)&&(a > c))
{
    System.Console.WriteLine("Максимальное число " + a);
}
else if((b > a)&&(b > c))
{
    System.Console.WriteLine("Максимальное число " + b);
}
else if((c > a)&&(c > b))
{
    System.Console.WriteLine("Максимальное число " + c);
}
else if((a == b)&&(a == c))
{
    System.Console.WriteLine("Все переменные равны");
}