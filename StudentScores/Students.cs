using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
    public class Students : ICloneable
    {
        public Students() { }

        public Students(string name, List<int> scores)
        {
            Name = name;
            Scores = scores;
        }

        public Students Cloneof;

        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public string displayScores(List<int> Scores)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var score in Scores) {
                sb.Append(score + " ");
            }

            return sb.ToString();
        }

        public string DisplayText => $"{Name} {displayScores(Scores)}";

        
        public object Clone()
        {
            Students student = (Students)this.MemberwiseClone();
            return student;
        }


        public static void AddScore(Students student)
        {

        }
    }
}