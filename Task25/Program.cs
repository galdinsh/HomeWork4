// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int s = 1;
// for(int i = 1; i <= m; i++)
// {
// s = s * n;
// }
// Console.WriteLine($"Результат = {s}");

Console.Clear(); 
Console.WriteLine("Введите два числа: "); 
int A = int.Parse(Console.ReadLine()!); 
int B = int.Parse(Console.ReadLine()!); 
int result = A; 
for (int i = 1; i < B; i++) 
{ result = result * A; } 
 Console.WriteLine(result);