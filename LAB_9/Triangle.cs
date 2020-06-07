using System;

namespace LAB_9
{
	class Triangle
	{
		Random random = new Random();
		public static int Count;
		private double a;   // 1 сторона
		private double b;   // 2 сторона
		private double c;   // 3 сторона
		private double perim;

		public double A
		{
			get
			{
				return a;
			}
			set
			{
				if (value > 0)
				{
					a = value;
				}
				else
				{
					a = 0;
				}
			}
		}
		public double B
		{
			get
			{
				return b;
			}
			set
			{
				if (value > 0)
				{
					b = value;
				}
				else
				{
					b = 0;
				}
			}
		}
		public double C
		{
			get
			{
				return c;
			}
			set
			{
				if (value > 0)
				{
					c = value;
				}
				else
				{
					c = 0;
				}
			}
		}

		public Triangle()
		{
			a = 0;
			b = 0;
			c = 0;
			perim = 0;
			Count++;
		}
		public Triangle(double y)
		{
			a = 0;
			a = y;
			Count++;
		}
		public Triangle(double x, double y, double z)
		{
			if ((x + y) > z && (x + z) > y && (z + y) > x)
			{
				a = x;
				b = y;
				c = z;
			}
			else
			{
				x = 0;
				y = 0;
				z = 0;
			}
			perim = a + b + c;
			Count++;
		}

		public void SetValues()
		{
			Console.WriteLine("Введите A");
			A = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите B");
			B = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите C");
			C = int.Parse(Console.ReadLine());
			perim = a + b + c;
		}

		public void SetRandomValues()
		{
			A = random.Next(1, 20);
			B = random.Next(1, 20);
			C = random.Next(1, 20);
			perim = a + b + c;
		}

		public void Show()
		{
			Console.WriteLine($"Треугольник со сторонами {A}, {B} и {C}");
		}

		public static bool IsExist(Triangle triangle)    // Проверка на принадлежность точки диапазону
		{
			if ((triangle.a + triangle.b) > triangle.c && (triangle.a + triangle.c) > triangle.b && (triangle.c + triangle.b) > triangle.a)
				return true;
			else
				return false;
		}

		public bool IsExist()
		{
			if ((A + B) > C && (A + C) > B && (C + B) > A)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static implicit operator double(Triangle triangle)
		{
			return triangle.perim;
		}

		// Нахождение площади треугольника
		public static double operator -(Triangle triangle)
		{
            double square = Math.Sqrt(triangle.perim / 2 * (triangle.perim / 2 - triangle.a) * (triangle.perim / 2 - triangle.b) * (triangle.perim / 2 - triangle.c));
            return square;
        }

		// Операции приведения типа:
		public static explicit operator bool(Triangle triangle)
		{
			return triangle.IsExist();
		}

		public static bool operator <(Triangle t1, Triangle t2)
		{
			return -t1 < -t2;
		}

		public static bool operator >(Triangle t1, Triangle t2)
		{
			return -t1 > -t2;
		}
	}
}
