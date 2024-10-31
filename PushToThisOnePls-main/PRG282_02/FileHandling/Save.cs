using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_02
{
	internal class Save
	{
		private string fileName;

		public string FileName { get => fileName; set => fileName = FileName; }
		public Save() { }

		public Save(string fileName)
		{
			this.fileName = fileName;
		}

		public void streamWrite(List<Student> students)
		{

			string[] text = new string[students.Count];

			for (int k = 0; k < students.Count; k++)
			{
				text[k] = students[k].Id.ToString() + "," + students[k].Name + "," + students[k].Age.ToString() + "," + students[k].Course;
			}
			//Create a filestream with filemode set to create as to override the existing file
			FileStream fs = new FileStream(FileName, FileMode.Create);

			StreamWriter writer = new StreamWriter(fs);

			for (int k = 0; k < students.Count; k++)
			{
				writer.WriteLine(text[k]);
			}

			writer.Close();
			fs.Close();
		}

		public void GenerateSummary(int students, float age)
		{
			string fileName = "Summary.txt";

			FileStream myStream = new FileStream(fileName, FileMode.Create);

			StreamWriter myWriter = new StreamWriter(myStream);

			myWriter.WriteLine($"Number of students: {students}");
			myWriter.WriteLine($"Average age of students: {age}");

			myWriter.Close();
			myStream.Close();
		}
	}
}
