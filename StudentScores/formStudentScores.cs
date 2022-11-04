namespace StudentScores
{
    public partial class formStudentScores : Form
    {
        public formStudentScores()
        {
            InitializeComponent();
        }

        private List<Students> studentsList = null;

        private void formStudentScores_Load(object sender, EventArgs e)
        {
            //studentsList = StudentsDB.GetStudents();
            studentsList = new List<Students> 
            {
                new Students { Name = "Jim", Scores = new List<int> { 100, 90, 88 } },
                new Students { Name = "Nathan", Scores = new List<int> { 100, 99, 85, 93 } },
                new Students { Name = "Emily", Scores = new List<int> { 98, 91, 89 } }
            };
            FillStudentListBox();
        }

        private void FillStudentListBox()
        {
            lbStudentScores.Items.Clear();
            foreach (Students student in studentsList)
            {
                lbStudentScores.Items.Add(student.DisplayText);
            }
        }

        //Nathan Burns
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            formAddNewStudent newStudentForm = new formAddNewStudent();
            Students student = newStudentForm.GetNewStudent();
            if (student != null)
            {
                studentsList.Add(student);
                StudentsDB.SaveStudent(studentsList);
                FillStudentListBox();
            }
        }

        //Nathan Burns
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Students student1 = lbStudentScores.SelectedItem as Students;
            //Students student1Clone = student1.Clone() as Students;

            int i = lbStudentScores.SelectedIndex;
            Students selectedStudent = studentsList[i];

            formUpdateStudentScores newStudentForm = new formUpdateStudentScores(selectedStudent, studentsList, i);
            Students student = newStudentForm.GetUpdateStudent();
            if (student != null)
            {
                StudentsDB.SaveStudent(studentsList);
                FillStudentListBox();
            }
        }
        
        //Nathan Burns
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lbStudentScores.SelectedIndex;
            if (i != -1)
            {
                Students student = studentsList.FirstOrDefault(x => x.DisplayText.Equals(lbStudentScores.SelectedItem.ToString()));
                string message = $"Are you sure you want to delete {student.Name}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    studentsList.Remove(student);
                    FillStudentListBox();
                }
            }
        }

        private void lbStudentScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbStudentScores.SelectedIndex;

            if (index != -1)
            {
                Students selectedStudent = studentsList[index];
                if (selectedStudent.Scores.Count() == 0 || studentsList.Capacity == 0)
                {
                    tbScoreTotal.Text = "N/A";
                    tbScoreCount.Text = "0";
                    tbAverage.Text = "N/A";
                }
                else
                {
                    int total = 0;
                    int count = 0;
                    double average = 0.0;

                    foreach (var score in selectedStudent.Scores)
                    {
                        total += score;
                    }
                    count = selectedStudent.Scores.Count();
                    average = (Convert.ToDouble(total)) / (Convert.ToDouble(count));

                    tbScoreTotal.Text = Convert.ToString(total);
                    tbScoreCount.Text = Convert.ToString(count);
                    tbAverage.Text = average.ToString("#.##");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}