 

double[,] addMatrix(int row, int column){

// созд. хранилище
double[,] twoDimArray = new double[row, column];

Random rnd = new Random();

 for (int i = 0; i < row; i++){ 
    for (int j = 0; j < column; j++){ 
      twoDimArray[i,j] = Convert.ToDouble(rnd.Next(0, 11));
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




void Average(double[,] arr){ // 

    double[] average = new double[arr.Length]; //для 3х3 это = [9]

    for (int i=0,k=0;i<arr.GetLength(0);i++) { // для 3х3  {arr.GetLength(0) = 3

        double summa=0;

        for (int j=0;j<arr.GetLength(1);j++) {  // для 3х3  {arr.GetLength(1) = 3
            summa+=arr[j,i]; // переворот на сумму  по столбцам [j , i]
            //Console.WriteLine($" Нарастающая по столбцам summa = {summa}") ; 

        }

        average[k]=summa/arr.GetLength(1);

        Console.WriteLine("Среднее арифметическое столбца "+(i+1)+" равно: "+average[k]);
        k++;
    }

    Console.Write("Следуй за Белым Кроликом ... ");
    Console.ReadKey(true);

}


Console.WriteLine("Указать кол-во строк двумерного массива:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Указать кол-во столбцов, равное кол-ву строк:");
int column = Convert.ToInt32(Console.ReadLine());


// переменной newArr присвоить итоги работы (return) из addMatrix(ряды, колонки)
double[,] newArr = addMatrix(row, column); 

//в печать переменную newArr
PrintArray (newArr) ;  

//Расчет ср.арифм (argument = сгенерирован. массив внутри addMatrix())
Average(newArr) ;

 //можно уже и поспать

