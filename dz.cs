//Задача №25. Возвести в степень число
/* 

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

*/

//===========================================

// Задача 27. Найти сумму всех цифр в числе. 

/*
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

*/



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





 