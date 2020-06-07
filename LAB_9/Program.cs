using System;

namespace LAB_9
{
	class Program
	{
		static void Main(string[] args)
		{
			// Длины сторон:
			Console.WriteLine("Введите стороны треуголника");
			double a, b, c;
			Console.Write("Введите первую сторону: ");
			a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите вторую сторону: ");
			b = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите третью сторону: ");
			c = Convert.ToDouble(Console.ReadLine());

			Triangle triangle = new Triangle(a, b, c);

			Console.WriteLine(Triangle.IsExist(triangle));

			// Часть 2:
			Console.WriteLine("Вычислить площадь треугольника через (-): ");
			Console.WriteLine(-triangle);

			Console.WriteLine("Вычисление периметра треугольника");
			double perim = triangle;
			Console.WriteLine(perim);

			Console.WriteLine("Найти, существует ли треугольник: ");
			Console.WriteLine((bool)triangle);

			Triangle triangleN = new Triangle(6, 8, 10);

			Console.WriteLine($"triangle > triangle1 = {triangle > triangleN}");
			Console.WriteLine($"triangle1 > triangle = {triangleN > triangle}");
			Console.WriteLine($"triangle < triangle1 = {triangle < triangleN}");
			Console.WriteLine($"triangle1 < triangle = {triangleN < triangle}");


			// Часть 3:
			TriangleArray triangleArray = new TriangleArray(3); //заполнение с ДСЧ
			triangleArray.ShowElements();
			triangleArray.ShowMinSquare();

			TriangleArray triangleArrayN = new TriangleArray(3, false); // заполнение вручную
			triangleArrayN.ShowElements();
			triangleArrayN.ShowMinSquare();

			Console.ReadKey();


		}
	}
}
