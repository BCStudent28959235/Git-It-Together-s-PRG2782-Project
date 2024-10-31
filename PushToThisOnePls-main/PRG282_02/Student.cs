using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_02
{
	internal class Student
	{
		string name, course;
		int id, age;

		public string Name { get => name; set => name = value; }
		public string Course { get => course; set => course = value; }
		public int Id { get => id; set => id = value; }
		public int Age { get => age; set => age = value; }

		public Student() { }

		public Student(int id, string name, int age, string course)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.course = course;
		}
	}
}
