using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Library
{
    public class StudentGradesDataBase
    {
        //simulating a database of students
        internal static List<Student> students = 
            new List<Student>()
        {
            new Student {First="Svetlana",
                Last="Omelchenko",
                ID=111,
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire",
                Last="O’Donnell",
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Sergiu",
                Last="Ungureanu",
                ID=114,
                Street="153 Second Street",
                City="Renton",
                Scores= new List<int> {97, 92, 81, 99}},
            new Student {First="John",
                Last="Clay",
                ID=115,
                Street="1163 Sunset bvld",
                City="Auburn",
                Scores= new List<int> {75, 65, 91, 39}},
            new Student {First="Steven",
                Last="Pals",
                ID=116,
                Street="3215 Vecotr Street",
                City="Lake City",
                Scores= new List<int> {100, 94, 65, 10}},
            new Student {First="Nadia",
                Last="Poroshenko",
                ID=117,
                Street="135 45th Street",
                City="Renton",
                Scores= new List<int> {97, 89, 81, 60}},
            new Student {First="Gordon",
                Last="Ramses",
                ID=118,
                Street="17596 James Street",
                City="Kent",
                Scores= new List<int> {75, 26, 91, 39}},
            new Student {First="Roman",
                Last="Goose",
                ID=119,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Alex",
                Last="Petrovitski",
                ID=120,
                Street="6584 Lina Dr",
                City="Seattle",
                Scores= new List<int> {97, 92, 81, 99}},
            new Student {First="Ruala",
                Last="Sirbu",
                ID=121,
                Street="996 Main Street",
                City="Auburn",
                Scores= new List<int> {75, 84, 77, 39}},
            new Student {First="Kathling",
                Last="Davis",
                ID=122,
                Street="651 Zorro Street",
                City="Tacoma",
                Scores= new List<int> {88, 59, 65, 91}},
        };

    }
}
