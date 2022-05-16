// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число: ");
int NumberA =  int.Parse(Console.ReadLine());
int x = 1;
for (int i = 1; i <= NumberA; i++)
	x = x*i;
Console.WriteLine(x);		

