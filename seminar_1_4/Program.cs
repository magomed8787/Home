void Zadanie1(int number)
{
    System.Console.WriteLine(number/10%10);
}
Zadanie1(int.Parse(Console.ReadLine()));


void Zadanie2(string number)
{
    {
    if (number.Length >= 3)
        System.Console.WriteLine(number[2]);
    else
        System.Console.WriteLine("Третьей цифры нет");
    }
}
Zadanie2(Console.ReadLine());

void Zadanie3(int number)
{
    {
    if (number >= 6)
        System.Console.WriteLine("Да");
    else
        System.Console.WriteLine("Нет");
    }
}
Zadanie3(int.Parse(Console.ReadLine()));
