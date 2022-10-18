  /*
  Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
  или сообщает, что третьей цифры нет.

  645 -> 5
  78 -> третьей цифры нет
  32679 -> 6
  */
 
void ShowThird(int num){

  // для работы с индексами числа
  string numStr = num.ToString() ;   
  int numLength = numStr.Length ;  
 

  if(numLength <=2){

    Console.WriteLine($"No third number");  

  }else if(numLength >2){

    Console.WriteLine($" This is the third number: {numStr[2]} from {num}") ;

  } ;

}


Console.WriteLine("Enter a number greater than zero:") ;  
int num = Convert.ToInt32(Console.ReadLine() ) ; 

ShowThird(num);



