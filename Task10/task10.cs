 /*
 Задача 10: Напишите программу, которая принимает на вход трёхзначное число
  и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

 
 int ShowSecond(int num){  

 int res = num % 100 / 10;  
 
 return res; 
 
 } ;


 int randNum = new Random().Next(100, 1000);  
 int res = ShowSecond(randNum);  

 
 Console.WriteLine($"Вторая цифра из рандомного трехзначного числа {randNum} равна {res}"); 

 


