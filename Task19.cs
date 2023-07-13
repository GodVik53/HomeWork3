//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да






Console.WriteLine("Введите пятизначное число: ") ;
int number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(number) ;
 if (NumberText.Length == 5) {
      if (NumberText[0] == NumberText[4]) {
            if (NumberText[1] == NumberText[3]) {
            Console.WriteLine("Да");
            }
             else Console.WriteLine("Нет");
         }
      else Console.WriteLine("Нет");

 }
 else {
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число:");
    }
