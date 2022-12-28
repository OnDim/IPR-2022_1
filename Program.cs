// Итоговая проверочная работа за 1 четверть 2022-2023 учебный год.

// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.

// Ввод первоначального массива строк

string[] ArrayString(int n)
{
    string[] arr;
    arr = new string[n];
    for(int i=0;i<n;i++)
        arr[i]=Console.ReadLine();
        return arr;
}        

// Печать двумерного массива (из подпрограммы) на экран

void PrintArray(int[] a, int n)
{
    for(int i=0;i<n;i++)
        System.Console.WriteLine($"{a[i],4}");
            System.Console.WriteLine();
}