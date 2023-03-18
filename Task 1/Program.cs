//Напишите программу, которая на вход принимает координаты точки (Х, У). причем Х и У не равны нулю и выдаёт номер четверти плоскости, в которой находится//
Console.Clear();
Console.WriteLine("Введите х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите у: ");
double y = Convert.ToDouble(Console.ReadLine());
if(x > 0 && y > 0)
  Console.WriteLine("1");
else if(x < 0 && y > 0)
  Console.WriteLine("2");
else if(x < 0 && y < 0)
  Console.WriteLine("3");    
else 
  Console.WriteLine("4");
