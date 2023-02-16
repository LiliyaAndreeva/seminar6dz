// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + 
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.	b1 = 2, k1 = 5, b2 = 4, k2 = 9 
// -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите значение b1: ");
double B1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
double K1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double B2 = int.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
double K2 = int.Parse(Console.ReadLine());

if (K1==K2 && B1==B2)
{
  Console.WriteLine("Прямые совпадают");}
  if (K1==K2)
  {
  Console.WriteLine("Прямые параллельны");}



double [] FindIntersectionPoint(double B1, double K1,double B2,double K2){
double []coord = new double[2];
double x = (B2 - B1)/(K1 - K2);
coord [0] = x;
double y = K2 * ((B2 - B1)/(K1 - K2)) + B2;
coord [1] = y;
return coord;
}
Console.WriteLine(String.Join(" ",  FindIntersectionPoint(B1,K1,B2,K2)));