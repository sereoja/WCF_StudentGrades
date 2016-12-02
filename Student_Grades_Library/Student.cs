using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add reference for data contract
using System.Runtime.Serialization;

namespace Student_Grades_Library
{
    [DataContract]
    public class Student
    {       
            [DataMember]
            public string First { get; set; }
            [DataMember]
            public string Last { get; set; }
            [DataMember]    
            public int ID { get; set; }
            [DataMember]
            public string Street { get; set; }
            [DataMember]
            public string City { get; set; }
            [DataMember]
            public List<int> Scores;
      
    }
}
