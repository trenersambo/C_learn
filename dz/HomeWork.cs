// See https://aka.ms/new-console-template for more information
Console.WriteLine("Решение трех домашних задач для Семинара №8");

// ===========Задача 54================
// Задайте 2мерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 2мерного массива.
/*
9   0   7   6
6   3   9   3
0   5   4   8
8   3   9   0

 массив  после сортировки:
9   7   6   0
9   6   3   3
8   5   4   0
9   8   3   0
*/

//=========решение 54 ===============

/*
// 1. Метод создания 2х мерного массива
int[,] Create2dArray(int row, int column){
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++){
    for (int j = 0; j < column; j++){
      array[i, j] = new Random().Next(0, 20);
    }
  }
  return array;
}

// 2. Вывода в консоль 2х мерного массива
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      Console.Write($"{array[i, j], 3} |  ");
    }
    Console.WriteLine();
  }
}

// 3.Ф-ция сортировки от большего к меньшему (за 1 проходку меняю местами большие значения)
int[,] ArrSort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1) - 1; j++){
      int temp = array[i, j]; // временно храню, чтоб вернуть
      if (array[i, j] < array[i, j + 1]){ // условие - если меньше
 
        temp = array[i, j + 1];
        array[i, j + 1] = array[i, j]; // перемена мест
        array[i, j] = temp; // верну значение

      }
    }
  }
  return (array);
}


Console.Write("Сколько строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Сколько столбцов массиве: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(row, col);

Console.WriteLine("Сгенерированный массив:");
PrintArray(myArray);

//ArrSort(myArray); // ?
// вызов по кол-ву столбцов
for (int i = 0; i < myArray.GetLength(1) - 1; i++) {
ArrSort(myArray);
}

Console.WriteLine("Массив после автосортировки:");
PrintArray(myArray);

*/

// =========== Задача 56: ==================
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* // Пример
6   2   7
0   3   0
6   9   1
4   8   5
Сумма элементов 1-ой строки: 15
Сумма элементов 2-ой строки: 3
Сумма элементов 3-ой строки: 16
Сумма элементов 4-ой строки: 17
Номер строки с наименьшей суммой элементов: 2
*/

// 1. Метод создания 2х мерного массива
int[,] CreateArray(int row, int col) {
    int[,] newArray = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}

// Метод вывода в консоль 2х мерного массива
void ShowArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3} |  ");
        }
        Console.WriteLine();
    }
}
// 3.Cформируем массив с суммами элементов по кажд. строчке  
int[] SummRows(int[,] array) {
    int[] calcArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма значений в {i + 1} строчке: {sum} ");
        calcArr[i] = sum;
    }
    return calcArr;
}

// void indx(){ 
// }

Console.Write("Сколько строк: ");
int lenArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Сколько столбцов  в массиве: ");
int widthArray = Convert.ToInt32(Console.ReadLine());

int[,] addArray = CreateArray(lenArray, widthArray);
ShowArray(addArray);


int[] sumArray = SummRows(addArray);
int min = sumArray[0];

// найти индекс  минимального элемента
int minIdx = 0;
for (int i = 1; i < sumArray.Length; i++){
    if (sumArray[i] < min)
    {
        min = sumArray[i];
        minIdx = i;
    }
}

Console.Write($"Номер строки,где сумма значений наименьшая: {minIdx + 1} \n");