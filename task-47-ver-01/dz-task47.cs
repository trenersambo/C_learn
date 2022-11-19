 //===== Семинар 7, Задача 47 ======
 // Задать 2мерный массив m x n,
 // заполнение - вещественные числа

//===================================


// double[,] a = new double[3, 4];

// Random random = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//  NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         a[i, j] = random.NextDouble() * 100; 
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

double[,] addMatrix(){

Console.WriteLine("Указать кол-во строк двумерного массива:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Указать кол-во столбцов двумерного массива:");
int column = Convert.ToInt32(Console.ReadLine());

// созд. хранилище
double[,] twoDimArray = new double[row, column];

Random rnd = new Random();

 for (int i = 0; i < row; i++){ 
    for (int j = 0; j < column; j++){ 
      twoDimArray[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
      }
  }
 return twoDimArray ;
}

void PrintArray(double[,] arr)
{ for (int i = 0; i < arr.GetLength(0); i++){ 
    for (int j = 0; j < arr.GetLength(1); j++){
      Console.Write($"{arr[i, j]} ");
      }
      Console.WriteLine();
  }
}

// переменной newArr присвоить итоги работы (return) из addMatrix
double[,] newArr = addMatrix(); 

//в печать переменную newArr
PrintArray (newArr) ;



