 //Seminary homework #1

 //Task #2
 /*Напишите программу, которая на вход принимает два числа и выдаёт, 
 какое число большее, а какое меньшее.*/

 Console.Write("Введи ПЕРВОЕ  число: ");
int num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введи ВТОРОЕ  число: ");
int num2 = Convert.ToInt32( Console.ReadLine() );

if(num1 > num2){
Console.WriteLine($"{num1} Большее число");  
}else{
Console.WriteLine($"{num2} Большее число ");
};


//===========================================

//Task #4
/*Напишите программу, которая принимает на вход три числа и
 выдаёт максимальное из этих чисел */

Console.Write("Введи ПЕРВОЕ  число: ");
int numb1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введи ВТОРОЕ  число: ");
int numb2 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введи ТРЕТЬЕ  число: ");
int numb3 = Convert.ToInt32( Console.ReadLine() );

int maxInt = numb1;

if(numb2 >= maxInt && numb2 >= numb3){
 maxInt = numb2;
}else if(numb3 >= maxInt && numb3 >= numb2){
  maxInt = numb3 ;
} ;

Console.WriteLine($"{maxInt} наибольшее число из {numb1}, {numb2}, {numb3}");



//===========================================

//Task #6
/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

Console.Write("Введи число для проверки на четность: ");
int number = Convert.ToInt32( Console.ReadLine() );

if(number % 2 == 0){
Console.WriteLine($"{number} является ЧЁТНЫМ (Even)");
}else{
 Console.WriteLine($"{number} НЕЧЁТНОЕ (Odd)");
} ;


//===========================================



//Task #8
/*Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.*/


Console.Write("Enter number: ");
int integer = Convert.ToInt32( Console.ReadLine() );

int count = 1 ;

while(count <= integer){
  if(count %2 == 0){
     Console.WriteLine($" this {count} is even out of {integer} numbers in a row");
  };
  count++ ;
};