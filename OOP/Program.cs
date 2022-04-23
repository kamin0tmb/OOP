using System;

namespace OOP
{
	class Rectangle
	{
		// Поля класса
		public int a;
		public int b;
		public int c;

		// Метод класса
		public void Square()
		{
			c = a * b;
			Console.WriteLine("У прямоугольника со сторонами {0} и {1} площадь равна {2}", a, b, c);
		}
		// Конструктор 1
		public Rectangle()
		{
			a = 6;
			b = 4;
		}
		// Конструктор 2
		public Rectangle(int aNew)
		{
			a = aNew;
			b = a;
		}
		public Rectangle(int aNew, int bNew)
		{
			a = aNew;
			b = bNew;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle();
			rectangle.Square();

			rectangle = new Rectangle(4);
			rectangle.Square();

			rectangle = new Rectangle(2, 4);
			rectangle.Square();


		}
	}
}
