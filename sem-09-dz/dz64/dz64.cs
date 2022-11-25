// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ======== Задача 64 ============ 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string List(int begin, int end){
    if (begin <= end) return $" {begin} |" + List(begin + 1, end);
    else return String.Empty;
}


Console.WriteLine("Способ №64-1");
Console.WriteLine(List(m, n));

*/



//=========== ver-002 =========

Console.Write("Введите конечное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

 
int Print(int fromN ) {
    if (fromN >= 1) {
        Console.Write($"{fromN} | "); 
        return Print(fromN - 1);
    }
    else return 0;
}

Console.WriteLine("Натуральные числа в промежутке от N до 1: ");

Print(n);     // 8 | 7 | 6 | 5 | 4 | 3 | 2 | 1 |
Console.WriteLine();

