Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0; 
for(int m = 1; m > 0; n /=10)
{
    m = n % 10;
    s = s + m;
}
Console.WriteLine($"Результат = {s}");

// Console.Clear();
// Console.Write("Введите число: ");
// string s = Console.ReadLine()!;
// int sum = 0;
// for (int i = 0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine($"сумма цифр числа- {sum}");