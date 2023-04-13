/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());
int count = 1;

int PrintNumber()
{
  if (count > num)
  {
    return count;
  }

  Console.Write(num + "|");
  num -= 0.5;

  return PrintNumber();
}
PrintNumber();



/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int sum = 0;

int PrintNumber()
{
  if (M > N)
  {
    return M;
  }
  sum += M;
  M++;

  return PrintNumber();
}
PrintNumber();
Console.Write(sum);



/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
  }
}
Console.Write(Akkerman(m, n));