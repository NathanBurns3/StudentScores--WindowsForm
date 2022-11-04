namespace StudentScores
{
    partial class formStudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudents = new System.Windows.Forms.Label();
            this.lbStudentScores = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tbScoreTotal = new System.Windows.Forms.RichTextBox();
            this.tbScoreCount = new System.Windows.Forms.RichTextBox();
            this.tbAverage = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(41, 42);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(81, 25);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students";
            // 
            // lbStudentScores
            // 
            this.lbStudentScores.FormattingEnabled = true;
            this.lbStudentScores.ItemHeight = 25;
            this.lbStudentScores.Location = new System.Drawing.Point(41, 88);
            this.lbStudentScores.Name = "lbStudentScores";
            this.lbStudentScores.Size = new System.Drawing.Size(487, 279);
            this.lbStudentScores.TabIndex = 1;
            this.lbStudentScores.SelectedIndexChanged += new System.EventHandler(this.lbStudentScores_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(582, 88);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddNew.Size = new System.Drawing.Size(112, 34);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(582, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(582, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(335, 407);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(101, 25);
            this.lblScoreTotal.TabIndex = 5;
            this.lblScoreTotal.Text = "Score total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(326, 475);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(110, 25);
            this.lblScoreCount.TabIndex = 6;
            this.lblScoreCount.Text = "Score count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(355, 540);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(81, 25);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average:";
            // 
            // tbScoreTotal
            // 
            this.tbScoreTotal.Location = new System.Drawing.Point(442, 404);
            this.tbScoreTotal.Name = "tbScoreTotal";
            this.tbScoreTotal.Size = new System.Drawing.Size(86, 40);
            this.tbScoreTotal.TabIndex = 8;
            this.tbScoreTotal.Text = "";
            // 
            // tbScoreCount
            // 
            this.tbScoreCount.Location = new System.Drawing.Point(442, 472);
            this.tbScoreCount.Name = "tbScoreCount";
            this.tbScoreCount.Size = new System.Drawing.Size(86, 40);
            this.tbScoreCount.TabIndex = 9;
            this.tbScoreCount.Text = "";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(442, 537);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(86, 40);
            this.tbAverage.TabIndex = 10;
            this.tbAverage.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(582, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 625);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbScoreCount);
            this.Controls.Add(this.tbScoreTotal);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lbStudentScores);
            this.Controls.Add(this.lblStudents);
            this.Name = "formStudentScores";
            this.Text = "Nathan Burns Student Scores";
            this.Load += new System.EventHandler(this.formStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudents;
        private ListBox lbStudentScores;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private RichTextBox tbScoreTotal;
        private RichTextBox tbScoreCount;
        private RichTextBox tbAverage;
        private Button btnExit;
    }
}