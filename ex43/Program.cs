Console.Clear();
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] CrossPoint(int k1, int b1, int k2, int b2)
{
  double [] coordinate = new double[2];
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;
  coordinate[0] = x;
  coordinate[1] = y;
  return coordinate;
}



Console.Write("Введите коэффициент наклона первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите смещение первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент наклонавторой прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите смещение второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join("; ", CrossPoint(k1, b1, k2, b2)));