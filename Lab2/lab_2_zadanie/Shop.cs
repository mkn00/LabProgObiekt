using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Shop : IThing
	{
		private string _name;
		private Person[] _people;
		private Product[] _products;
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
		public Shop(string name, Person[] people, Product[] products)
		{
			this._name = name;
			this._people = people;
			this._products = products;
		}
		public void Print()
		{
			Console.WriteLine($"Shop: {Name}");
			Console.WriteLine("-- People: --");
			foreach (Person p in _people)
			{
				p.Print("\t");
			}
			Console.WriteLine("-- Products: --");
			foreach (Product p in _products)
			{
				p.Print("\t");
			}
		}
	}
}
