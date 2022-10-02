void Zadanie7(int number)
{
    var digits = new List<int>();
    int count = 5;
    for (int i = 0; i <= count; i ++)
    {
        digits.Add(number % 10);
        number = number / 10;
    }
    if (digits[0]==digits[4] && digits[1] == digits[3])
    {
    System.Console.WriteLine("Это палиндром");
    }
    else
    {
    System.Console.WriteLine("Это не палиндром");
    }
}
Zadanie7(12321);

void Zadanie8(int[] a, int[] b)
{
    double distance1 = Math.Pow(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2), 0.5);
    Console.WriteLine(distance1);
    //Console.WriteLine(b[0]);
    //Console.WriteLine(a[0]);
    //Console.WriteLine(Math.Pow((b[0] - a[0]), 2));
    //Console.WriteLine(Math.Pow(16, 0.5));
}

int[] A = new int [3];
int[] B = new int [3];
for (int k = 0; k < 3; k++)
    A[k] = Convert.ToInt32(Console.ReadLine());
for (int k = 0; k < 3; k++)
    B[k] = Convert.ToInt32(Console.ReadLine());
Zadanie8(A, B);

void Zadanie9(int number)
{
    for (int i = 1; i <= number; i ++)
    {
        int x = i * i * i;
        System.Console.WriteLine(x);
    }
}
Zadanie9(3);


   
    