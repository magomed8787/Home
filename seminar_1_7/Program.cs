// // int ReadData(string msg) //Метод получения данных от пользователя
// // {
// // System.Console.WriteLine(msg);
// // int number = int.Parse(Console.ReadLine());
// // return number;
// // }

// // int SumDigitOneToA(int numA) // сумма чисел от одного до А
// // {
// //     int sum = 0;
// //     for(int i = 1; i <= numA; i++)
// //     {
// //         sum = sum + i;
// //     }
// //     return sum;
// // }

// // int GaussMethod(int numA)
// // {
// //     int sum = ((1 + numA) * numA) / 2;
// //     return sum;
// // }

// // void PrintData(string msg, int value) //вывод
// // {
// //     System.Console.WriteLine(msg+value);
// // }

// // int numA = ReadData("Введите число A: ");

// // //DataTime d1 = DataTime.Now;
// // int sum = SumDigitOneToA(numA);
// // //System.Console.WriteLine(DataTime.Now-d1);

// // PrintData("Сумма чисел от 1 до A: ", sum);

// // //DataTime d2 = DataTime.Now;
// // int sumGaus = GaussMethod(numA);
// // //System.Console.WriteLine(DataTime.Now-d2);

// // PrintData("Сумма чисел от 1 до A(gausse): ", sumGaus);

// // ///Факториал

// // int ReadData(string msg) //Метод получения данных от пользователя
// // {
// // System.Console.WriteLine(msg);
// // int number = int.Parse(Console.ReadLine());
// // return number;
// // }

// // void PrintData(string msg, long value) //вывод
// // {
// //     System.Console.WriteLine(msg+value);
// // }

// // long Fuktor(int num)
// // {
// //     long res = 1;
// //     for(int i = 1; i <= num; i++)
// //     {
// //         res = res*i;
// //     }
// //     return res;
// // }

// // int numN = ReadData("Введите число N: ");
// // long outResult = Fuktor(numN);
// // PrintData("Факториал числа "+ numN+ " равен: ", outResult);

// // Напишите программу, которая выводит массив из 8
// // элементов, заполненный нулями и единицами в
// // случайном порядке.
// // Например:
// // [1,0,1,1,0,1,0,0]

// int ReadData(string msg) //Метод получения данных от пользователя
// {
// System.Console.WriteLine(msg);
// int number = int.Parse(Console.ReadLine());
// return number;
// }

// int[] Fill1DArr(int len, int lowBord, int highBord)
// {
//     int[] array = new int[len];
//     for(int i=0; i < len; i++)
//     {
//         array[i] = new System.Random().Next(lowBord, highBord);
//     }
//     return array;
// }

// void Print1Darr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length -1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
// }

// int arrLen = ReadData("Введите длину массива: ");
// int[] arr = Fill1DArr(arrLen, 0, 1);
// Print1Darr(arr);

///Метод вывода двумерного массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


//Метод заполнения матрицы случайными числами

void FillArray(int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
     }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);