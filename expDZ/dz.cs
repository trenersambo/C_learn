
//===================================

// Задача 34. 
//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

//Пример: [345, 897, 568, 234] -> 2


 
int SearchEven(int [] array){
int countEven = 0;

for (int i = 0;  i < array.Length; i++){
   if(array[i]%2 ==0){
    countEven++ ;
   }
}

 return countEven ;

}
 
int [] array = {345, 897, 568, 234} ;

Console.Write( $" Количестов четных чисел: {SearchEven(array)} \n" ) ;

 


//===================================

// Задача 36.
// Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//пример: [3, 7, 23, 12] -> 19 ;  [-4, -6, 89, 6] -> 0

 
int [] GetRandomArray(int size, int min, int max ){

 
int [] array = new int[size]  ;
 
for (int i = 0;  i < size; i++){
    array[i] = new Random().Next(min, max+1) ;  
  }

  return array ;

}

 
void ShowArr(int [] array){

for (int i = 0;  i < array.Length; i++){
  Console.Write($"{array[i]} ") ;
}

Console.WriteLine() ;

}
 

int  Odd(int [] array){
int accumSum = 0; 

for(int i=0; i < array.Length; i++){

  if( i % 2 > 0){
    accumSum +=array[i] ;
  }
  
}

return accumSum ;
}

 
int size = new Random().Next(5, 21) ;
 
int min = -100;
int max = 100;
 
int [] NewArray = GetRandomArray(size, min, max);
 
ShowArr(NewArray);

 
Console.Write($"сумма чисел (на нечетных позициях) = { Odd(NewArray)} \n") ;


 

//===================================

// Задача 38.

// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//Пример: [3.0, 7.2 ,22.7, 2.1, 78.3] -> 76.2


double RealNumber(double [] arr){

  double min =  arr[0];
  double max =  arr[0];

  for(int i =0; i < arr.Length; i++){

  if(arr[i] <= min){
    min =  arr[i];
    
  } ;

   if(arr[i] >= max){
    max =  arr[i];
  
  } ;

  }

  return (max - min) ;

}

double [] arr = {3.0, 7.2 ,22.7, 2.1, 78.3} ;

Console.Write($"Разница = {RealNumber(arr)} ") ;

   
