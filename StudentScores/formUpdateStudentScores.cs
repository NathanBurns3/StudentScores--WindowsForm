using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class formUpdateStudentScores : Form, ICloneable
    {
        private Students selectedStudent = null;
        private Students selectedStudentClone = null;
        private Students studentClone = null;
        private List<Students> studentList = null;
        private int index = 0;

        public object Clone()
        {
            Students student = (Students)this.MemberwiseClone();
            return student;
        }

        public formUpdateStudentScores(Students student, List<Students> StudentList, int ind)
        {
            InitializeComponent();
            selectedStudent = student;
            selectedStudentClone = student;
            studentList = StudentList;
            index = ind;
            studentClone = (Students)selectedStudent.Clone();
        }

        private void formUpdateStudentScores_Load(object sender, EventArgs e)
        {
            tbName.Clear();
            lbScores.Items.Clear();

            tbName.Text = studentClone.Name;

            foreach (var s in studentClone.Scores)
            {
                lbScores.Items.Add(s + "\n");
            }
        }

        public Students GetUpdateStudent()
        {
            this.ShowDialog();
            return selectedStudent;
        }

        public int CancelSelected()
        {
            return 1;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAddScore addScoreForm = new formAddScore(studentClone);
            Students student = addScoreForm.GetNewScore();
            if (student != null)
            {
                FillScoreListBox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lbScores.SelectedIndex;
            int selectedScore = studentClone.Scores[index];

            formUpdateScore updateScoresForm = new formUpdateScore(selectedScore, index, studentClone);
            Students student = updateScoresForm.GetUpdateScore();
            if (student != null)
            {
                FillScoreListBox();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbScores.SelectedIndex;
            int selectedScore = studentClone.Scores[index];

            studentClone.Scores.RemoveAt(index);

            FillScoreListBox();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            studentClone.Scores.Clear();

            FillScoreListBox();
        }

        //Nathan Burns
        private void btnOK_Click(object sender, EventArgs e)
        {
            //studentList.Remove(selectedStudent);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            studentList.Remove(studentClone);
            CancelSelected();
            this.Close();
        }

        private void FillScoreListBox()
        {
            lbScores.Items.Clear();

            foreach (var s in studentClone.Scores)
            {
                lbScores.Items.Add(s + "\n");
            }
        }
    }
}
