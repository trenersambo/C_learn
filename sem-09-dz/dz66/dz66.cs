// See https://aka.ms/new-console-template for more information
Console.WriteLine("Домашняя работа. Задача 66");

// =========== Задача 66 =============
//  Задайте значения M и N.
//  Напишите программу, которая найдёт 
//  сумму натуральных элементов в промежутке от M до N.

//Пример: 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Сначала ввести натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("А сейчас введи натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int end)
{
    if (start != end + 1){
      return start + Sum(start + 1, end) ;
    }  
    else return 0;
}
Console.WriteLine($"Cумма натуральных значений в промежутке от M ({m})  до N ({n}) = {Sum(m, n)} ");
// Console.WriteLine(Sum(m, n));


 

