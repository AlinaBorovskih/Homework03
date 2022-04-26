Console.WriteLine("Введите координаты: ");
int a1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int c1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int c2 = int.Parse(Console.ReadLine());
int length = (int) Math.Pow(a2 - a1,2) + (int)Math.Pow(b2 - b1,2) + (int) Math.Pow(c2 - c1,2);
double result = Math.Round(Math.Sqrt(length),2);

Console.WriteLine($"Расстояние между точками равно {result}");
