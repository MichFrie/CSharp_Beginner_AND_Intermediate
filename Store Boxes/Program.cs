using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
	class Item 
	{
		public string Name { get; set; }
		public decimal Price { get; set; }

		public Item(string name, decimal price)
		{
			Name = name;
			Price = price;
		}
	}

	class Box
	{ 
		public int serialNumber { get; set; }
		public Item Item { get; set; }
		public int ItemQuantity { get; set; }
		public decimal pricePerBox { get; set; }

		public Box(int serialNumber, string itemName, int itemQuantity, decimal itemPrice)
		{
			this.serialNumber = serialNumber;
			Item = new Item(itemName,itemPrice);
			ItemQuantity = itemQuantity;
			pricePerBox = itemQuantity * Item.Price;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			List<Box> boxes = new List<Box>();

			while ((input = Console.ReadLine()) != "end")
			{
				string[] info = input.Split();
				Box newBox = new Box(int.Parse(info[0]), info[1], int.Parse(info[2]), decimal.Parse(info[3]));

				boxes.Add(newBox);
			}

			boxes = boxes.OrderByDescending(box => box.pricePerBox).ToList();

			foreach (var box in boxes)
			{
				Console.WriteLine(box.serialNumber);
				Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
				Console.WriteLine($"-- ${box.pricePerBox:f2}");
			}
		}
	}
}
