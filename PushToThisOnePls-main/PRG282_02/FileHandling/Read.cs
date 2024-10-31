using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_02
{
	internal class Read
	{
		private string fileName;

		public string FileName { get => fileName; set => fileName = FileName; }
		public Read() { }

		public Read(string fileName)
		{
			this.fileName = fileName;
		}

		public List<Student> streamRead()
		{
			List<Student> students = new List<Student>();
			using (StreamReader streamReader = new StreamReader(fileName))
			{
				string txt;
				while ((txt = streamReader.ReadLine()) != null)
				{
					Student student = new Student();
					//get the id from the text
					int pos = txt.IndexOf(',');
					student.Id = int.Parse(txt.Substring(0, pos));
					txt = txt.Substring(pos + 1);
					//get the name from the text
					pos = txt.IndexOf(',');
					student.Name = txt.Substring(0, pos);
					txt = txt.Substring(pos + 1);
					//get the age from the text
					pos = txt.IndexOf(',');
					student.Age = int.Parse(txt.Substring(0, pos));
					txt = txt.Substring(pos + 1);
					//get the course from the text
					student.Course = txt;
					//add the student to the list of students
					students.Add(student);
				}
				return students;
			}
		}
	}
}
