 //===== Семинар 7, Задача 50 ======

 // указать позицию элемента [m, n]
 // вывести значение найденного элемента
 // или сообщить об его отсутствии

 // решал с 21 до 2 ночи, на JS решено за 10 минут

//===================================

  // Console.Clear() ; // очистить терминал

//метод по созд 2-х мерного массива
int[,] Create2dArr(){

  // запрос данных
  Console.Write("введите кол-во строк: ");
  int row = Convert.ToInt32(Console.ReadLine()) ;

  Console.Write("введи кол-во колонок: ");
  int column = Convert.ToInt32(Console.ReadLine()) ;
 

  // созд. хранилище
  int[,] CreatArr= new int[row, column] ;

  //проходка по строкам - столбцам
  for(int i = 0; i<row; i++){

    for(int j=0; j < column; j++){
      CreatArr[i, j] = new Random().Next(0, 20);

    } 
  }

return CreatArr; 

}

  //2. Расчет массив по условию задачи
 
  int[,] FillMatrix(int[,] arr ){
 

  Console.Write("Номер искомой строки (отсчет с нуля): ");
  int rowNum = Convert.ToInt32(Console.ReadLine()) ;

  Console.Write("Номер искомого столбца (отсчет с нуля): ");
  int colNum = Convert.ToInt32(Console.ReadLine()) ;

  Console.WriteLine($"Ищем число с позицией [{rowNum}, {colNum}]") ;


  for (int i = 0; i < arr.GetLength(0); i++){

    
      if(  arr.GetLength(0)< rowNum){
       Console.Write($"чисел с индексом [ {rowNum}, {colNum} ] нет \n");
       break; 
      }

      for(int j = 0; j <= arr.GetLength(1); j++){

        if(  arr.GetLength(1)-1 < colNum){
          Console.Write($"чисел с индексом [ {rowNum}, {colNum} ] нет \n");
          break; 
        }
    

        if(i == rowNum && j == colNum){
          Console.Write($"В {i} ряду найдено число: {arr[i, j]} \n") ;
          break;
        } else if ( j== arr.GetLength(1) ){ // подстраховка
            Console.Write($"В {i} ряду числа с индексом [ {rowNum}, {colNum} ] нет \n ") ;
            break;
        } 

    }

  }
 
     return arr ;
  
  }

  //3. Печать массива на экран 

 // метод вывод на экран
void show2Arr(int[,] arr){

    // (0) - это для строк, 0- номер измерения   
  for(int i = 0; i < arr.GetLength(0); i++){

    // (1) - это для столбцов ,1- номер измерения  
    for(int j=0; j < arr.GetLength(1) ; j++){
      Console.Write(arr[i, j] + " ");
    }

      Console.WriteLine(); 
  }

      Console.WriteLine(); 
}


  // вывод на экран сгенерированного массива
  int[,] addArray = Create2dArr() ;
  show2Arr(addArray) ;

  int[,] calcArray = FillMatrix(addArray);


 