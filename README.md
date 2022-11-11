# Репозиторий "C_learn" 

*Изучение языка С# (9 уроков по основам)*

![Логотип C#](logoC.jpg)

**Начало обучения: октябрь 2022**

# Семинар №5 (10/11/2022): 
##  Знакомство с языком программирования С#
## Функции продолжение


 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.0 7.2 22.7 2.1 78.3] -> 76.2

____________

```C#
int SearchEven(int [] array){
int countEven = 0;

for (int i = 0;  i < array.Length; i++){
   if(array[i]%2 ==0){
    countEven++ ;
   }
}

 return countEven ;

}

//задаю ручной массив
int [] array = {345, 897, 568, 234} ;

Console.Write( $" Количестов четных чисел: {SearchEven(array)} " ) ;

```

Задача 36.

```C#
// 1. ф-ция по генерации произвольного массива: по Длинне, кол-ву чисел в нем
int [] GetRandomArray(int size, int min, int max ){

//инициализация массива array = 'size' чисел int
//Создать новый целочисленный массив размера size - new int [size]
int [] array = new int[size]  ;

// цик генерации произвольного массива
for (int i = 0;  i < size; i++){
    array[i] = new Random().Next(min, max+1) ; // прав. граница всегда со сдвигом на 1
  }

  return array ;

}

// 2. ф-ция показа полученного массива
void ShowArr(int [] array){

for (int i = 0;  i < array.Length; i++){
  Console.Write($"{array[i]} ") ;
}

Console.WriteLine() ;

}

//3. ф-ция нахождения суммы 

int  Odd(int [] array){
int accumSum = 0; 

for(int i=0; i < array.Length; i++){

  if( i % 2 > 0){
    accumSum +=array[i] ;
  }
  
}

return accumSum ;
}

// рандом размера массива
int size = new Random().Next(5, 21) ;

// границы чисел в массиве
int min = -100;
int max = 100;

// переменная = целая функция
int [] NewArray = GetRandomArray(size, min, max);

// вызов на печать
ShowArr(NewArray);

//на экран итог суммы
Console.Write($"сумма чисел (на нечетных позициях) = { Odd(NewArray)} ") ;


```
Задача № 38 

```C#
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

Console.Write($"Разница = {RealNumber(arr)}") ;

```
