// Итоговая проверочная работа за 1 четверть 2022-2023 учебный год.

// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.

// Ввод первоначального массива строк

string[] ArrayString(int n)
{
    string[] arr;
    Console.WriteLine("Введите массив строк");
    arr = new string[n];
    for(int i=0;i<n;i++)
        arr[i]=Console.ReadLine();
        return arr;
}        

// Печать двумерного массива (из подпрограммы) на экран

void PrintArray(string[] a, int n)
{
    for(int i=0;i<n;i++)
        System.Console.WriteLine($"{a[i],4}");
            System.Console.WriteLine();
}

// Результирующая матрица

string[] MyArrayNew(string[] arr)
{
    string[] rez=new string[arr.Length];
    int count = 0;
    for(int i=0;i<arr.Length;i++)
        {
        if (arr[i].Length<=3)
        {
            rez[count] = arr[i];
            count++;
        }
        }
    return rez;  
}    

// Основная прграмма

int n=5;
string[] arr=ArrayString(n);
System.Console.WriteLine();
string[] rez=MyArrayNew(arr);
PrintArray(rez, n );