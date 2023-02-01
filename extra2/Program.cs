double[] TriangleSides(int[] Tri)
{
  double[] sides = new double[3];
  for(int i = 0; i < sides.Length; i++)
  {
  if(i == sides.Length - 1)
    {
      sides[i] = Math.Sqrt(Math.Pow(Tri[i*2] - Tri[i*2 + 2 - Tri.Length], 2) + Math.Pow(Tri[i * 2 + 1] - Tri[i * 2 + 3 - Tri.Length], 2));
    }
  else
    {
      sides[i] = Math.Sqrt(Math.Pow((Tri[i*2] - Tri[i*2 + 2]), 2) + Math.Pow((Tri[i*2+1] - Tri[i*2 + 3]), 2));
    }
  }
   return sides;
}
double TriangleSquare(double[] Sides)
{
  double p = (Sides[0] + Sides[1] + Sides[2]) / 2;
  return Math.Round(Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p -Sides[2])), 1);
}


Console.Clear();
int[] triangle = new int[6];


for (int i = 0; i < triangle.Length; i = i + 2)
{
  Console.Write($"Введите кординату х {i / 2 + 1} вершины треугольника: ");
  triangle[i] = Convert.ToInt32(Console.ReadLine());
  Console.Write($"Введите кординату у {i / 2 + 1} вершины треугольника: ");
  triangle[i + 1] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(" ,", TriangleSquare(TriangleSides(triangle))));