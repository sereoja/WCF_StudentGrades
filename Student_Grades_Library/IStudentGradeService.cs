using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add reference
using System.ServiceModel;

namespace Student_Grades_Library
{
    [ServiceContract]
    public interface IStudentGradeService
    {
        [OperationContract]
        float GetStudentAvgGrade(int id);
        [OperationContract]
        int GetStudentMinGrade(int id);
        [OperationContract]
        float GetClassAvgGrade();
        [OperationContract]
        Student[] GetFStudentBelowAvgGrade();
        [OperationContract]
        List<Student> GetStudentList();

    }
}
