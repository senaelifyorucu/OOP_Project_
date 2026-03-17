using System;
using OOP_Project.Models;

class Program
{
	static void Main(string[] args)
	{
		Person p1 = new Person("Sena", 26);
		p1.Introduce();
		Console.WriteLine();
		Student s1 = new Student("Elif", 20, "s34737");
		s1.Introduce();
		s1.ShowStudentInfo();
	}
}
