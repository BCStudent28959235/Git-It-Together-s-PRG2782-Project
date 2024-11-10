using  WinFormsApp_MainProjectFile.PresentationLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WinFormsApp_MainProjectFile.LogicLayer;
using System.ComponentModel.Design;
using System.Web;


namespace WinFormsApp_MainProjectFile.FileHandling
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

        public List<string> changeLogRead()
        {
            List<string> changeLog = new List<string>();

            string file =Application.StartupPath + @"\\ChangeLog.txt";
            FileStream fs;
            if (File.Exists(file))
            {
				fs = new FileStream(file, FileMode.Open);
			}
            else
            {
                fs = new FileStream(file, FileMode.Create);
            }
            StreamReader sr = new StreamReader(fs);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                changeLog.Add(line);
            }

            sr.Close();
            fs.Close();

            try
            {
				changeLog.RemoveRange(0, changeLog.Count - 3);
			}
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            return changeLog;   
        }

        public List<string> changeLogReadAll()
        {
            List<string> changeLog = new List<string>();

            string file = Application.StartupPath + @"\\ChangeLog.txt";
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                changeLog.Add(line);
            }

            sr.Close();
            fs.Close();

            return changeLog;
        }
    }
}
