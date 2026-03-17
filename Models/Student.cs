using System;
namespace OOP_Project.Models
{
	public class Student : Person
	{
		public string StudentId { get; set; }
		public Student(string name, int age, string studentId)
			: base(name, age)
		{
			StudentId = studentId;
		}
		public void ShowStudentInfo()
		{
			Console.WriteLine($"Student Id : {StudentId}");
		}
	}
}