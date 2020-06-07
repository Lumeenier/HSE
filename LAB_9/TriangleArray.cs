using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_9
{
	class TriangleArray
	{
		Triangle[] triangleArray = new Triangle[0];

		private int size = 0;
		public int Size
		{
			get
			{
				return size;
			}
			set
			{
				if (value >= 0)
				{
					size = value;
				}
				else
				{
					size = 0;
				}
			}
		}

		public TriangleArray()
		{
			triangleArray = new Triangle[0];
		}

		public TriangleArray(int size, bool RandomFilling = true)
		{
			triangleArray = new Triangle[size];
			if (RandomFilling)
			{
				for (int i = 0; i < size; i++)
				{
					Triangle triangle = new Triangle();
					triangle.SetRandomValues();
					triangleArray[i] = triangle;
				}
			}
			else
			{
				for (int i = 0; i < size; i++)
				{
					Triangle triangle = new Triangle();
					triangle.SetValues();
					triangleArray[i] = triangle;
				}
			}
		}

		// Индексатор:
		public Triangle this[int index]
		{
			get
			{
				if (index >= triangleArray.Length || index < 0)
				{
					Console.WriteLine("Элемент не обнаружен, передан пустой элемент");
					return null;
				}
				else
				{
					return triangleArray[index];
				}
			}
			set
			{
				triangleArray[index] = value;
			}
		}

		public void ShowElements()
		{
			for (int i = 0; i < triangleArray.Length; i++)
			{
				triangleArray[i].Show();
			}
		}

		public void ShowMinSquare()
		{
			int indx = 0;
			double minSquare = double.MaxValue;
			for (int i = 0; i < triangleArray.Length; i++)
			{
				if (-triangleArray[i] < minSquare)
                {
					minSquare = -triangleArray[i];
					indx = i;
				}
			}
			Console.WriteLine($"Минимальная площадь: {minSquare} [{indx+1}]");
		}
	}
}
