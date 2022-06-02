using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Meat : Product
	{
		private double _weight;
		public double Weight
		{
			get
			{
				return _weight;
			}
			set
			{
				_weight = value;
			}
		}

		public Meat(string name, double weight) : base(name)
		{
			this._weight = weight;
		}

		public override void Print(string prefix)
		{
			Console.WriteLine($"{prefix}{Name} ({Weight} kg)");
		}

	}
}
