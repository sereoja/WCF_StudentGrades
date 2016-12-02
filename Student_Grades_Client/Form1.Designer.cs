namespace Student_Grades_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnStudentAverage = new System.Windows.Forms.Button();
            this.lblInfoID = new System.Windows.Forms.Label();
            this.btnStudentSmallestGrade = new System.Windows.Forms.Button();
            this.btnClassAverageGrade = new System.Windows.Forms.Button();
            this.btnDisplayStudentsBelowAvgGrade = new System.Windows.Forms.Button();
            this.btnDisplayAllStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFName,
            this.colLName,
            this.colStreet,
            this.colCity});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(9, 10);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(494, 166);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colFName
            // 
            this.colFName.Text = "FirstName";
            this.colFName.Width = 100;
            // 
            // colLName
            // 
            this.colLName.Text = "Last Name";
            this.colLName.Width = 100;
            // 
            // colStreet
            // 
            this.colStreet.Text = "Address (Street)";
            this.colStreet.Width = 120;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 100;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Green;
            this.txtID.Location = new System.Drawing.Point(181, 188);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnStudentAverage
            // 
            this.btnStudentAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAverage.ForeColor = System.Drawing.Color.Green;
            this.btnStudentAverage.Location = new System.Drawing.Point(287, 182);
            this.btnStudentAverage.Name = "btnStudentAverage";
            this.btnStudentAverage.Size = new System.Drawing.Size(216, 30);
            this.btnStudentAverage.TabIndex = 3;
            this.btnStudentAverage.Text = "Student\'s Average Grade";
            this.btnStudentAverage.UseVisualStyleBackColor = true;
            this.btnStudentAverage.Click += new System.EventHandler(this.btnStudentAverage_Click);
            // 
            // lblInfoID
            // 
            this.lblInfoID.AutoSize = true;
            this.lblInfoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoID.ForeColor = System.Drawing.Color.Green;
            this.lblInfoID.Location = new System.Drawing.Point(12, 191);
            this.lblInfoID.Name = "lblInfoID";
            this.lblInfoID.Size = new System.Drawing.Size(163, 16);
            this.lblInfoID.TabIndex = 4;
            this.lblInfoID.Text = "Input Student ID to get:";
            // 
            // btnStudentSmallestGrade
            // 
            this.btnStudentSmallestGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSmallestGrade.ForeColor = System.Drawing.Color.Green;
            this.btnStudentSmallestGrade.Location = new System.Drawing.Point(287, 218);
            this.btnStudentSmallestGrade.Name = "btnStudentSmallestGrade";
            this.btnStudentSmallestGrade.Size = new System.Drawing.Size(216, 30);
            this.btnStudentSmallestGrade.TabIndex = 5;
            this.btnStudentSmallestGrade.Text = "Student\'s Smallest Grade";
            this.btnStudentSmallestGrade.UseVisualStyleBackColor = true;
            this.btnStudentSmallestGrade.Click += new System.EventHandler(this.btnStudentSmallestGrade_Click);
            // 
            // btnClassAverageGrade
            // 
            this.btnClassAverageGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassAverageGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClassAverageGrade.Location = new System.Drawing.Point(9, 254);
            this.btnClassAverageGrade.Name = "btnClassAverageGrade";
            this.btnClassAverageGrade.Size = new System.Drawing.Size(494, 30);
            this.btnClassAverageGrade.TabIndex = 6;
            this.btnClassAverageGrade.Text = "Class Average Grade";
            this.btnClassAverageGrade.UseVisualStyleBackColor = true;
            this.btnClassAverageGrade.Click += new System.EventHandler(this.btnClassAverageGrade_Click);
            // 
            // btnDisplayStudentsBelowAvgGrade
            // 
            this.btnDisplayStudentsBelowAvgGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStudentsBelowAvgGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDisplayStudentsBelowAvgGrade.Location = new System.Drawing.Point(9, 290);
            this.btnDisplayStudentsBelowAvgGrade.Name = "btnDisplayStudentsBelowAvgGrade";
            this.btnDisplayStudentsBelowAvgGrade.Size = new System.Drawing.Size(494, 30);
            this.btnDisplayStudentsBelowAvgGrade.TabIndex = 7;
            this.btnDisplayStudentsBelowAvgGrade.Text = "Display Students Below Average Grade";
            this.btnDisplayStudentsBelowAvgGrade.UseVisualStyleBackColor = true;
            this.btnDisplayStudentsBelowAvgGrade.Click += new System.EventHandler(this.btnDisplayStudentsBelowAvgGrade_Click);
            // 
            // btnDisplayAllStudents
            // 
            this.btnDisplayAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllStudents.ForeColor = System.Drawing.Color.Maroon;
            this.btnDisplayAllStudents.Location = new System.Drawing.Point(9, 218);
            this.btnDisplayAllStudents.Name = "btnDisplayAllStudents";
            this.btnDisplayAllStudents.Size = new System.Drawing.Size(272, 30);
            this.btnDisplayAllStudents.TabIndex = 8;
            this.btnDisplayAllStudents.Text = "Display All Students";
            this.btnDisplayAllStudents.UseVisualStyleBackColor = true;
            this.btnDisplayAllStudents.Click += new System.EventHandler(this.btnDisplayAllStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(511, 326);
            this.Controls.Add(this.btnDisplayAllStudents);
            this.Controls.Add(this.btnDisplayStudentsBelowAvgGrade);
            this.Controls.Add(this.btnClassAverageGrade);
            this.Controls.Add(this.btnStudentSmallestGrade);
            this.Controls.Add(this.lblInfoID);
            this.Controls.Add(this.btnStudentAverage);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colFName;
        private System.Windows.Forms.ColumnHeader colLName;
        private System.Windows.Forms.ColumnHeader colStreet;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnStudentAverage;
        private System.Windows.Forms.Label lblInfoID;
        private System.Windows.Forms.Button btnStudentSmallestGrade;
        private System.Windows.Forms.Button btnClassAverageGrade;
        private System.Windows.Forms.Button btnDisplayStudentsBelowAvgGrade;
        private System.Windows.Forms.Button btnDisplayAllStudents;
    }
}

