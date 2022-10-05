/////////////////////////////// Задача 25. Возведение числа A в натуральную степень B.////////////////////////////////////////
// int ReadData(string msg) //Метод получения данных от пользователя
// {
// System.Console.WriteLine(msg);
// int number = int.Parse(Console.ReadLine());
// return number;
// }

// int degree(int a, int b) //возведение (a) в степень (b)
// {
//     int num = 1;
//     for (int i = 0; i < b; i++)
//     {
//         num *= a;
//     }
//     return num;
// }

// void PrintData(string msg, int num) //вывод
// {
//     System.Console.WriteLine(msg+num);
// }

// int numA = ReadData("Введите число A: ");
// int numB = ReadData("Введите число B: ");
// int num = degree(numA, numB);
// PrintData("Число A в степени B равно: ", num);

////////Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе./////////////////////////////////

// int ReadData(string msg) //Метод получения данных от пользователя
// {
// System.Console.WriteLine(msg);
// int number = int.Parse(Console.ReadLine());
// return number;
// }

// int sum(int number)
// {
//     int tot = 0;
//     while (number > 0)
//     {
//         tot = tot + (number % 10);
//         number = number / 10;
//     }
//     return tot;
// }

// void PrintData(string msg, int num) //вывод
// {
//     System.Console.WriteLine(msg+num);
// }

// int numA = ReadData("Введите число A: ");
// int num = sum(numA);
// PrintData("Сумма цифр в числе A: ", num);


//////////////////Задача 29. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран./////////////


int ReadData(string msg) //Метод получения данных от пользователя
{
System.Console.WriteLine(msg);
int number = int.Parse(Console.ReadLine());
return number;
}

int[] Fill1DArr(int len, int low, int high)
{
    int[] array = new int[len];
    for(int i=0; i < len; i++)
    {
        array[i] = new System.Random().Next(low, high);
    }
    return array;
}

void Print1Darr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int[] arr = Fill1DArr(arrLen, 0, 1);
Print1Darr(arr);
