using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
	internal class Person : IThing
	{
		private string _name;
		private int _age;
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			this._name = name;
			this._age = age;
		}
		public virtual void Print(string prefix)
		{
		}
	}
}
