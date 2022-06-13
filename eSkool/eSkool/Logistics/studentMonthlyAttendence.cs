using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSkool.Logistics
{
    public class studentMonthlyAttendence
    {
       public string studentName;
       public string fatherName;
       public int[] days = new int[31];

       public studentMonthlyAttendence()
        {
            studentName = "boot";
            for(int i=0; i < 31; i++)
            {
                days[i] = -10;
            }
        }

    }
}