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
    public partial class formAddNewStudent : Form
    {
        public formAddNewStudent()
        {
            InitializeComponent();
        }

        private Students student = null;
        List<string> scoresStrings = new List<string>();

        public Students GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidDataAdd())
            {
                scoresStrings.Add(tbScore.Text);
            }

            tbScores.Clear();

            tbScores.Text = String.Join(" ", scoresStrings);

            tbScore.Clear();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            tbScores.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidDataOK())
            {
                List<int> scoresList = new List<int>();
                string scoresString = tbScores.Text;
                string[] scoresStringSplit = scoresString.Split(" ");
                foreach (string s in scoresStringSplit)
                {
                    scoresList.Add(Int32.Parse(s));
                }

                student = new Students(
                    tbName.Text,
                    scoresList
                );
            }
            this.Close();
        }

        private bool IsValidDataOK()
        {
            return
                Validator.IsPresent(tbName) &&
                Validator.IsPresent(tbScores);
        }

        private bool IsValidDataAdd()
        {
            return Validator.IsInt32(tbScore);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
