using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSkool.Logistics
{
    public class Algorithms
    {
        public static string generateStudentUsername(string Name,string FatherName ,string Roll,int Class)
        {
            string username = Name.Split(" ")[0];
            username += FatherName[0];
            username += Roll;
            username += "C" + Class;
            username += "S" + DateTime.Now.Year.ToString()[2]+ DateTime.Now.Year.ToString()[3];

            return username;
        }

        public static string generateTeacherUsername(string email)
        {
            string username;

            string[] temp=email.Split("@");
            username = temp[0];

            return username;
        }
    }
}
