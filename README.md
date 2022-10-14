# Репозиторий "C_learn" 

*Изучение языка С# (9 уроков по основам)*

![Логотип C#](logoC.jpg)

**Начало обучения: октябрь 2022**

# Семинар №1 : 
##  Знакомство с языком программирования С#

Пример кода, используемого на лабораторной работе: 

```C#
 Console.Write("Введи ПЕРВОЕ  число: ");
int num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введи ВТОРОЕ  число: ");
int num2 = Convert.ToInt32( Console.ReadLine() );

if(num1 > num2){
Console.WriteLine($"{num1} Большее число");  
}else{
Console.WriteLine($"{num2} Большее число ");
};
```

или

```C#
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
```
