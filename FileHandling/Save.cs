using  WinFormsApp_MainProjectFile.PresentationLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_MainProjectFile.LogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp_MainProjectFile.FileHandling
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

        public void ChangeLog(List<Student> students, int id ,string process)
        {
            DateTime dateTime = DateTime.Now;
            string now = dateTime.ToString("yyyy-mm-dd hh-mm-ss");

            string name = "", age = "", course = "";

            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    name = student.Name;
                    age = student.Age.ToString();
                    course = student.Course;
                }
            }

            string fileName ="ChangeLog.txt";
            FileStream myStream = new FileStream(fileName, FileMode.Append);
            StreamWriter myWriter = new StreamWriter(myStream);

            switch (process)
            {
                case "Add":
                    myWriter.WriteLine($"{now} = Added new student: ID={id}, Name={name}, Age={age}, Course={course}");
                    break;

                case "Update":
                    myWriter.WriteLine($"{now} = Updated student ID={id}, Name={name}, Age={age}, Course={course}");
                    break;

                case "Delete":
                    myWriter.WriteLine($"{now} = Deleted student ID={id}, Name={name}, Age={age}, Course={course}");
                    break;
            }

            myWriter.Close();
            myStream.Close();
        }
    }
}
