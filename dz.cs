// Домашнее задание для семинара №3

//====== ======= ======= =======

// Задача 19 (семинар№3 по C# )

// Напишите программу, которая принимает на вход пятизначное число и
//  проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


/*

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

*/

//====== ======= ======= =======


// Задача 21 (семинар№3 по C# )

// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// Формула: AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

/*

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

*/


//====== ======= ======= =======

// Задача 23 (семинар№3 по C# )

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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


//====== ======= ======= =======