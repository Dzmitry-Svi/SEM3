//Напишите программу, которая находит координаты двух точек и находит расстояние между ними в 2Dпространстве//

Console.Clear();
Console.WriteLine("Введите первую координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату y2: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2,2)));