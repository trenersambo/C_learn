# Репозиторий "C_learn" 

*Изучение языка С# (9 уроков по основам)*

![Логотип C#](logoC.jpg)

**Начало обучения: октябрь 2022**

# Семинар №1 : 
##  Знакомство с языком программирования С#

<br><br>

# Семинар №2 : 
##  Массивы и функции в программировании в С#
(в реальности до массивов не добрались)

<br><br>

# Семинар №3 : 
## Массивы и функции в программировании в С#
(в реальности до массивов еще не добрались)

 <br>
 
Пример кода для Семинара №3:

```C#

void Polidrom(int number){
  int numberOld = number; //копия
  int numberNew = 0;

while (number > 0){
    numberNew = (number % 10) + (numberNew * 10 ); //разбиваю разряды
    number = number / 10;
}

if (numberNew != numberOld){
  Console.Write($" Число {numberOld} НЕ палиндром числа {numberNew} ") ;
   
} else{
  Console.Write($" Число {numberNew} палиндром числа {numberOld} :-) ") ;
}

};


//цикл, пока не введет 5-знак
while( true){
  Console.Write("Бро, введи пятизначное число: ");
  int number = Convert.ToInt32(Console.ReadLine() );

  if(number>=10000 && number<=99999){
    Polidrom(number);
    break;
  }else{
    Console.Write($"Друг, надо ввести ПЯТИЗНАЧНОЕ число! ") ;
  };

}
```

Для решения Задачи 21 такой код на C#

```C#
double Dist
(
int xa, int xb, 
int ya, int yb, 
int za, int zb
){
 double abz = Math.Sqrt
 (
 ( (xb-xa) * (xb-xa) ) +
 ( (yb-ya) * (yb-ya) ) +
 ( (zb-za) * (zb-za) )
 ) ;

 return abz;

}

Console.Write("Введите координату xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату za: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());


double accum = Dist(n1, n2, n3, n4, n5, n6);

Console.Write($"Расстояние между точками A ({n1}, {n3}, {n5}) и B ({n2}, {n4}, {n6}) = {accum} ");
```

Для решения Задачи 23 такой код на C#

```C#
void FindCube(int num){
int result = 0;

for(int i = 1; i <=num; i++){
 result = i*i*i; 
} ;
Console.Write($"Куб числа {num} равен {result} ");
} 

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindCube(num);
```
 
_______


# Семинар №4 (07.11.2022): 
## Функции продолжение

```C#
//Задача №25. Возвести в степень число
 
int ShowPow(int a, int b){
  int count = 1 ;
  int accumPow = 1 ;

  while( count <= b ){

  if( b==0 ){
    accumPow  = 1;
    break ; 
      }else{
        accumPow = accumPow * a ;
        count++ ;
      }
  
  }

  return accumPow ;

}


Console.WriteLine("Друг, пиши тут число: ");
int numOne = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("А здесь укажи его степень: ");
int numTwo = Convert.ToInt32( Console.ReadLine() );


if(numOne==0 && numTwo==0){
Console.WriteLine($"Ну и зачем Ноль в степени Ноль?");
 
}else{
Console.WriteLine($" Число {numOne} в степени {numTwo} = {ShowPow(numOne, numTwo)}");
}


//===========================================

// Задача 27. Найти сумму всех цифр в числе. 

int Count(int num){
  int acc = 0;

  while( num > 0 ){
    acc = acc + (num%10) ;
    num  = num/10 ;
  }
    return acc ;

}

while(true){
  Console.Write("Введи число, больше НУЛЯ: ");
  int number = Convert.ToInt32( Console.ReadLine() );

  if(number <=0){
    Console.Write($"Что-то пошло не так или приложение закрывается. ") ;
    break;
  }else{
    Console.WriteLine($"Сумма цифр в числе {number} = {Count(number)}");
    Console.WriteLine($"Для выхода из программы введи 0");
  }
}


//===========================================

int [] GetArray(int n){

  int [] arr = new int[n] ;

  for (int i = 0; i < n; i++){
    arr[i] = new Random().Next(1 , 100) ;

  }

  return arr ;

} ;

void ShowArray(int [] arr){

    Console.Write($"Ваш массив: [") ;

  for( int i = 0; i < arr.Length; i++){

     Console.Write($"{arr[i]}, ") ;
  }
    Console.Write($"\b\b] ") ;

} ;

 Console.Write("Введи число (Задай размерность массива): ");
  int volue = Convert.ToInt32( Console.ReadLine() );

ShowArray( GetArray(volue) ) ;


```

 
