using System;

namespace OOP_Project.Models
{
	public class Person
	{
		public string Name { get; set; }
		public int Age {get; set; }
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
		public void Introduce()
		{
			Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
		}
	}
}