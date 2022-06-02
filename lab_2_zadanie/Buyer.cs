using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Buyer : Person
	{
		protected List<Product>tasks = new List<Product>();

		public Buyer(string name, int age) : base(name, age)
		{
			this.Name = name;
			this.Age = age;
		}
		
		public void AddProduct(Product product)
		{
			tasks.Add(product);
		}

		public void RemoveProduct(int index)
		{
			tasks.RemoveAt(index);
		}

		public override void Print(string prefix)
		{
			Console.WriteLine($"{prefix}Buyer: {Name} ({Age} y.o.)");
			if (this.tasks.Count > 0)
			{
				Console.WriteLine(prefix + prefix + "-- Products: --");
				foreach (var task in this.tasks)
				{
					task.Print(prefix+prefix);
				}
			}
		}
	}
}
