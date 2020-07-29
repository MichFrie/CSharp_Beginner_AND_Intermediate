using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeUndercovered
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int a1 = int.Parse(Console.ReadLine());
			int a2 = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());

			

			if (a1 >= 65 && a1 < 90 && a2 >= 66 && a2 < 92 && n > 0 && n < 11)
			{
				for (int i = a1; i <= a2 - 1; i++)
				{
					
					char sym1 = Convert.ToChar(i);
					if(i % 2 == 1)
					{
						for (int p = 1; p <= n - 1; p++)
						{
							int sym2 = p;
							for (int o = 1; o <= n / 2 - 1; o++)
							{
								int sym3 = o;

								for (int u = a1; u < a1 + 1; u++)
								{
									int sym4 = i;
									int sum = 0;
									sum = sym2 + sym3 + sym4;
									if (sum % 2 == 1)
									{
										StringBuilder code = new StringBuilder();
										code.Append($"{sym1}-");
										code.Append(sym2);
										code.Append(sym3);
										code.Append(sym4);
										Console.WriteLine(code);
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
