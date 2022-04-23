using System;

namespace OOP
{
	class Pen
	{
		// Поля класса
		public string color;
		public int cost;

		// Метод класса
		public void PenCost()
		{
			Console.WriteLine("В наличии есть ручка цвета: {0}, стоимостью: {1} рублей", color, cost);
		}
		// Конструктор 2
		public Pen()
		{
			color = "Черный";
			cost = 100;
		}
		// Конструктор 3
		public Pen(string penColor, int penCost)
		{
			color = penColor;
			cost = penCost;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Pen pen = new Pen();
			pen.PenCost();

			pen = new Pen("Красный", 150);
			pen.PenCost();

			
		}
	}
}
