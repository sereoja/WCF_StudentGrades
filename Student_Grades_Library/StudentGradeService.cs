using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Library
{
    public class StudentGradeService : IStudentGradeService
    {
        public float GetStudentAvgGrade(int id) {
            //get the account object with the specified accountNumber
            Student student = StudentGradesDataBase.students.Find(
                a => a.ID == id);
            return (float)student.Scores.Average(); }
        

        public int GetStudentMinGrade(int id)
        { //get the account object with the specified accountNumber
            Student student = StudentGradesDataBase.students.Find(
                a => a.ID == id);
            return student.Scores.Min();
        }
        public float GetClassAvgGrade() {
            float count = 0;
            float sum = 0;
            foreach (Student s in StudentGradesDataBase.students)
            {
                sum += GetStudentAvgGrade(s.ID);
                count++;
            }
            return sum/count; }

        public Student[] GetFStudentBelowAvgGrade() {
           
            float clAvg = GetClassAvgGrade();
            List<Student> students = new List<Student>();

             foreach (Student s in StudentGradesDataBase.students)
                {
                    float stAvg = GetStudentAvgGrade(s.ID);
                    if (stAvg < clAvg)
                    {
                    students.Add(s);
                    }
                }
            if (students.Count == 0)
            {
                return null;
            }else
            return students.ToArray() ;
        }


        public List<Student> GetStudentList()
        {
            List<Student> listOfStudents = new List<Student>();
            foreach (Student s in StudentGradesDataBase.students)
            {
                listOfStudents.Add(s);
            }
            
            return listOfStudents;
        }
    }
}
