using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Fruit : Product
	{
		private int _count;
		public int Count { get; set; }
		public Fruit(string name, int count) : base(name)
		{
			this.Count = count;
		}
		public override void Print(string prefix)
		{
			Console.WriteLine($"{prefix}{Name} ({Count} fruits)");
		}
	}
}
