//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int number;
int counter=0;
string endTest="";

Console.WriteLine("Введите ваши числа или введите стоп -> ");
while(true)
{
    endTest=Console.ReadLine();
    if(endTest=="стоп" || endTest=="СТОП") break;

    number=int.Parse(endTest);
    if(number>0) counter++;
}

Console.WriteLine($"Количество чисел больше ноля -> {counter}");




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент k1 -> ");
double k1=double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 -> ");
double b1=double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 -> ");
double k2=double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 -> ");
double b2=double.Parse(Console.ReadLine());

if(k1==k2)
{
    Console.WriteLine("Прямые, описанные данными уравнениями, параллельны");
}
else
{
   Console.WriteLine($"Точка перечечения -> [{(b2-b1)/(k1-k2)} ; {k1*((b2-b1)/(k1-k2))+b1}]");
}