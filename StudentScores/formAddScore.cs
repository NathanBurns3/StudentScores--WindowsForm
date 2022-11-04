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
    public partial class formAddScore : Form
    {
        private Students student = null;

        public formAddScore(Students selectedStudent)
        {
            InitializeComponent();
            student = selectedStudent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int score = Int32.Parse(tbScore.Text);
                student.Scores.Add(score);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(tbScore) &&
                Validator.IsInt32(tbScore) && (int.Parse(tbScore.Text) >= 0 || int.Parse(tbScore.Text) <= 100);
        }

        public Students GetNewScore()
        {
            this.ShowDialog();
            return student;
        }
    }
}
