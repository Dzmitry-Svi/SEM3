//Напишите программу, которая на вход принимает число N и выдаёт таблицу квадратов чисел от 1 до N//

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= N; i++)
  Console.Write($"{i*i} ");