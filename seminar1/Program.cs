Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    System.Console.WriteLine("max = a");
    System.Console.WriteLine("Число a больше числа b");
}
else if(a < b)
{
    System.Console.WriteLine("max = b");
    System.Console.WriteLine("Число b больше числа a");
}
else if(a == b)
{
    System.Console.WriteLine("Числа a и b равны");
}