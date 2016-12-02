using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add references
using System.ServiceModel;
using System.ServiceModel.Description;


namespace Student_Grades_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1:
            //create a uri to serve as the base address of 
            //this service
            try
            {
                Uri baseAddress =
                    new Uri("http://localhost:15000/StudentGrades");
                //step 2:
                //create a servicehost
                ServiceHost selfHost = new ServiceHost(typeof(Student_Grades_Library.StudentGradeService), baseAddress);

                //step 3
                selfHost.AddServiceEndpoint(typeof(Student_Grades_Library.IStudentGradeService), new BasicHttpBinding(), "AccountsService");

                //step 4 Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                //step 5: set to host to listen
                selfHost.Open();
                Console.WriteLine("\nAccounts Service Host is Listening...");

                Console.ReadLine();//pause
                selfHost.Close();

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("\n\n" + ce.Message);
            }
        }
    }
}
