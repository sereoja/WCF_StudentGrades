using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Grades_Client.ServiceReference;

namespace Student_Grades_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayAllStudents_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            StudentGradeServiceClient sgsc = new StudentGradeServiceClient();
            List<Student> listOfStudents = new List<Student>();
            listOfStudents = sgsc.GetStudentList().ToList();
            foreach (Student s in listOfStudents)
            {
                ListViewItem lvi = new ListViewItem(s.ID.ToString());
                lvi.SubItems.Add(s.First);
                lvi.SubItems.Add(s.Last);
                lvi.SubItems.Add(s.Street);
                lvi.SubItems.Add(s.City);
                listView.Items.Add(lvi);
            }
           
        }

        private void btnStudentAverage_Click(object sender, EventArgs e)
        {
            StudentGradeServiceClient sgsc = new StudentGradeServiceClient();
            int id;
            if (int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Student ID: " + id + "\nAverage Grade is " + sgsc.GetStudentAvgGrade(id));
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void btnStudentSmallestGrade_Click(object sender, EventArgs e)
        {
            StudentGradeServiceClient sgsc = new StudentGradeServiceClient();
            int id;
            if (int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Student ID: " + id + "\nSmalles Grade is " + sgsc.GetStudentMinGrade(id));
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }


        private void btnClassAverageGrade_Click(object sender, EventArgs e)
        {
            StudentGradeServiceClient sgsc = new StudentGradeServiceClient();
            MessageBox.Show("Average Grade of the Class is: " + sgsc.GetClassAvgGrade());
        }


        private void btnDisplayStudentsBelowAvgGrade_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            StudentGradeServiceClient sgsc = new StudentGradeServiceClient();
            List<Student> listOfStudents = new List<Student>();
            listOfStudents = sgsc.GetFStudentBelowAvgGrade().ToList();
            if (listOfStudents != null)
            {
                foreach (Student s in listOfStudents)
                {
                    ListViewItem lvi = new ListViewItem(s.ID.ToString());
                    lvi.SubItems.Add(s.First);
                    lvi.SubItems.Add(s.Last);
                    lvi.SubItems.Add(s.Street);
                    lvi.SubItems.Add(s.City);
                    listView.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("No Students are below average!");
            }
            
        }

        
    }
}
