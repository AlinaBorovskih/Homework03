
Console.WriteLine ( "Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
int origin = N;
int rev = 0;
int dig = 0;
while( N > 0)
{
   dig = N % 10;
   rev = rev * 10 + dig;
   N = N /10 ;  
}  
if (origin == rev)

Console.WriteLine ($"{origin} является полиндромом");

else 

Console.WriteLine ($"{origin} Не является полиндромом");