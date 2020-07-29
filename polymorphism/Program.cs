using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
	using System;

	namespace PolymorphismApplication
	{
		abstract class Shape
		{
			public double length;
			public double width;

			public Shape(double a = 0, double b = 0)
			{
				length = a;
				width = b;
			}

			public abstract void area();
		}

		class Rectangle : Shape
		{

			public Rectangle(double a = 0, double b = 0) : base (a,b)
			{
				
			}
			public override void area()
			{
				double area = Math.Round(width * length, 2);
				Console.WriteLine($"Rectangle class area : {area}");
			}
		}

		class RightAngledTriangle : Shape
		{
			public RightAngledTriangle (double a = 0, double b = 0) : base(a,b)
			{

			}

			public override void area()
			{
				double area = Math.Round((width * length) / 2, 2);
				Console.WriteLine($"Right-angled triangle  class area : {area}");
			}
		}

		class RectangleTester
		{
			static void Main(string[] args)
			{
				Console.Write("Shape Size[a ... ; b ...] : ");
				string[] input = Console.ReadLine().Split(' ');

				Rectangle rectangle = new Rectangle(double.Parse(input[0]), double.Parse(input[1]));
				RightAngledTriangle r_a_triangle = new RightAngledTriangle(double.Parse(input[0]), double.Parse(input[1]));
				
				rectangle.area();
				r_a_triangle.area();

				Console.ReadKey();
			}
		}
	}
}

