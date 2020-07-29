using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_set
{
	class GetSeconds
	{
		public double Seconds;
		public double Hours
		{
			get { return Seconds / 3600; }
			set
			{
				Seconds = value * 3600;
			}
		}
	}
}
