// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2      -> 2
// 1, -7, 567, 89, 223  -> 4 

 
void foo(){
   Console.Write("Вводите любые числа. Как надосет - жми 777 ");

   int count = 0;
   int num = 0;
 

   while( num != 777){

     Console.WriteLine("Введи число: ");  
      num = Convert.ToInt32(Console.ReadLine()) ;

     if(num > 0 && num != 777){
      count++ ;
 
     }else if(num == 777){
     Console.WriteLine($"Выход, введено стоп-слово 777. \n"+
                        $"Всего введено {count} значение больше нуля ");
     break ;
     }

   }

}

foo();
 


 //=================

  // Задача 43: Напишите программу, которая найдёт точку
  // пересечения двух прямых,
  // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
  // значения b1, k1, b2 и k2 задаются пользователем.

  // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 
void Line(double b1, double k1, double b2, double k2){

  if(k1 != k2){
    double x = (b1-b2) / (k2 - k1) ;
    double y = k1*x + b1; 

      Console.Write($" Точка пересечения ({x}; {y}) ");
  }else{
     Console.Write($" Точки пересечения отсутствуют! ");
  }

}

     Console.WriteLine("Введи b1: ");  
     double b1 = Convert.ToInt32(Console.ReadLine()) ;

     Console.WriteLine("Введи k1: ");  
    double  k1 = Convert.ToInt32(Console.ReadLine()) ;

     Console.WriteLine("Введи b2: ");  
    double  b2 = Convert.ToInt32(Console.ReadLine()) ;

     Console.WriteLine("Введи k2: ");  
    double  k2 = Convert.ToInt32(Console.ReadLine()) ;

 Line(b1, k1, b2, k2);

 