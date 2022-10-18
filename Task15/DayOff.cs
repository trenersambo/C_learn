/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

  bool showDay(int day){
 
  if(day ==6 || day ==7){

    return true ;
  
  }else {

    return false;

  }

} ;

 
Console.WriteLine("Write the day of the week: " ) ;  
int day = Convert.ToInt32(Console.ReadLine() ) ; 

 
bool dayOff = showDay(day) ;

if(dayOff){
  Console.WriteLine($" {day} day of the week - relax day");
}else{
  Console.WriteLine($" {day} day of the week - Go & working");
}