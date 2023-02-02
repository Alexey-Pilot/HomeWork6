int fibo(int n)
{
  int mult = 1;
  for( int i = 2; i <= n; i ++) mult *= i;
  return mult;
}

string[] DelElem(string[] array, int ind)
{
  string[] newArray = array.Where((e, i) => i != ind).ToArray();
  return newArray;
}

string ReturnStr(string[] chars, int iteration) 
{
  int len = chars.Length;
  if (len == 1) return Convert.ToString(chars[0]);
  else
  {
    int n = fibo(len);

    string comb = chars[iteration * len / n] + ReturnStr(DelElem(chars, iteration * len / n), iteration % (n / len )); 

    return comb;
  }
}

Console.Clear();
Console.Write("Введите слово: ");
string word = Console.ReadLine();
char[] Chars = word.ToCharArray();
string [] StrChars = new string[Chars.Length];
for(int i = 0; i < Chars.Length; i++)
{
  StrChars[i] = Convert.ToString(Chars[i]);
}

string[] result = new string[fibo(Chars.Length)];
for(int i = 0; i < fibo(Chars.Length); i++)
{
  result[i] = ReturnStr(StrChars, i);
}
Console.WriteLine(string.Join("\n", result));


