// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 68");

// ======== Задача 68 =========== 

// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

//  Пример: 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

long Ak (long m, long n) {
    if (m == 0) {
        return n + 1;
    }

    if (m > 0 && n == 0)  {
        return Ak(m - 1, 1); // m-1
    } 
    
    if (m > 0 && n > 0)  {
        return Ak(m - 1, Ak(m, n - 1)); // n-1
    } 
    
    return Ak(m,n);

  }


Console.Write($"Введите M: ");
long m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите N: ");
long n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0) {
Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {Ak(m,n)} \n");
    Console.WriteLine(" ");
} else{
Console.Write($"Одно или оба числа < 0");
    Console.WriteLine(" ");
}
