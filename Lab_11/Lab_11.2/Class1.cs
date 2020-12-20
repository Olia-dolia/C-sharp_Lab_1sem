using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11._2
{
    static class Extention
    {
        // 5
        public static List<Student> FindStudent(this List<Student> List, StudentPredicateDelegate del)
        {
            // 6
            List<Student> temp = new List<Student>();

            foreach (Student i in List)
            {
                if (del(i))
                {
                    temp.Add(i);
                }
            }

            return temp;
        }
    }
}
