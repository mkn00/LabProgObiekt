using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Product : IThing
	{
		private string _name;
		public string Name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public Product(string name)
		{
			this._name = name;
		}

		public virtual void Print(string prefix)
		{

		}
	}
}
