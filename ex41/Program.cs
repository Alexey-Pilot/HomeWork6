
Console.Clear();
Console.Write("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
  Console.Write($"Введите число {i + 1}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  if (num > 0) count ++;
}
Console.WriteLine($"Колличество чисел больше 0: {count}");