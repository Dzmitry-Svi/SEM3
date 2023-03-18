//Напишите программу, которая по заданному номеру четверти, показывает диапазон координат точек в этой четверти(х и у)//

Console.Clear();
Console.WriteLine("Введите номер четврти от 1 до 4: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n == 1)
  Console.WriteLine("x > 0 y > 0");
else if(n == 2)
  Console.WriteLine("x < 0 y > 0"); 
else if(n == 3)
  Console.WriteLine("x < 0 y < 0");  
else 
  Console.WriteLine("x > 0 y < 0");   
