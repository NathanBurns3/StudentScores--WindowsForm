using InventoryMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class formUpdateScore : Form
    {
        private Students student = null;
        private int score;
        private int index;

        public formUpdateScore(int selectedScore, int i, Students selectedStudent)
        {
            InitializeComponent();
            score = selectedScore;
            index = i;
            student = selectedStudent;
            tbScore.Text = score.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            student.Scores[index] = Int32.Parse(tbScore.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Students GetUpdateScore()
        {
            this.ShowDialog();
            return student;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(tbScore) && Validator.IsInt32(tbScore);
        }
    }
}