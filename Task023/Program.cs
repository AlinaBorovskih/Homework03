Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int index = 1;

while (index <= N)
{
    Console.WriteLine(Math.Pow(index,3));
    index++;
}