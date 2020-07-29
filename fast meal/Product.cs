using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_meal
{
	class Product
	{
		public string _product_name { get; set; }
		public string _ingredients { get; set; }
		public double _price { get; set; }
	}

	class Salad : Product
	{
		
		/////////	WRITE Discount code HERE	/////////

		public Salad(string name, string ingredients, double cost)
		{
			_product_name = name;
			_ingredients = ingredients;
			_price = cost;
		}

		/*public DateTime Calc_delivery_time()
		{
			DateTime date;


			return date;
		}*/
	}
}
