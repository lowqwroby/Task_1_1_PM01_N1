using System;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите координаты вершин треугольника: ");
			try
			{
				Console.Write("x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
				Console.Write("y2: "); int y2 = Convert.ToInt32(Console.ReadLine());
				Console.Write("x3: "); int x3 = Convert.ToInt32(Console.ReadLine());
				Console.Write("y3: "); int y3 = Convert.ToInt32(Console.ReadLine());

				double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
				double B = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
				double C = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

				double P = A + B + C;
				Console.Write("Периметр треугольника равен: {0,4:f2}", P);
			}
			catch
			{
				Console.WriteLine("Координаты должны содержать только цифры!");
			}
			
		}
	}
}