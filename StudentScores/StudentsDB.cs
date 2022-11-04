using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
    public static class StudentsDB
    {
        private const string Path = @"..\..\..\Students.txt";
        private const string Separator = "|";

        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();

            StreamReader textIn =
                new StreamReader(
                    new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(Separator);
                Students student = new Students();
                student.Name = Convert.ToString(columns[0]);
                foreach (var score in student.Scores)
                {
                    Convert.ToInt32(columns[1]);
                }
                students.Add(student);
            }

            textIn.Close();

            return students;
        }

        public static void SaveStudent(List<Students> students)
        {
            StreamWriter textOut =
                new StreamWriter(
                    new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Students student in students)
            {
                textOut.Write(student.Name + Separator);
                foreach (var score in student.Scores)
                {
                    textOut.Write(score + Separator);
                }
            }
        }
    }
}
