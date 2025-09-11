using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public delegate int DelegateMethod(StudentIComarable a, StudentIComarable b);
    public class StudentIComarable : IComparable<StudentIComarable> //inheriting Icomparable interface
    {
        public int StudentId {  get; set; }
        public string StudentName { get; set; }
        public int StudentMarks { get; set; }

        public int CompareTo(StudentIComarable other)          //Implement Interface method
        {
            //if (this.StudentId > other.StudentId)                  //here you can change the logic, if you want to sort according to marks you can do
            //    return 1;
            //else if (this.StudentId < other.StudentId)
            //    return -1;
            //else
            //    return 0;
            return this.StudentId.CompareTo(other.StudentId);
        }
    }
    public  class TestStudent : IComparer<StudentIComarable>
    {
        static void Main(string[] args)
        {
            StudentIComarable s1 = new StudentIComarable()
            {
                StudentId = 105,
                StudentMarks = 590,
                StudentName = "Vikram"
            };
            StudentIComarable s2 = new StudentIComarable()
            {
                StudentId = 109,
                StudentMarks = 500,
                StudentName = "Muruli"
            };
            StudentIComarable s3 = new StudentIComarable()
            {
                StudentId = 102,
                StudentMarks = 450,
                StudentName = "Francis"
            };
            StudentIComarable s4 = new StudentIComarable()
            {
                StudentId = 108,
                StudentMarks = 540,
                StudentName = "Benjamin"
            };
            StudentIComarable s5 = new StudentIComarable()
            {
                StudentId = 101,
                StudentMarks = 420,
                StudentName = "Bhaskar"
            };
            List<StudentIComarable> list = new List<StudentIComarable>() {s1,s2,s3,s4,s5};

            foreach (StudentIComarable s in list)
            {
                Console.WriteLine(s.StudentName+"   "+s.StudentId+ "    " + s.StudentMarks);
            }
            Console.WriteLine("\n");
            list.Sort();                           //sorting wth the help of IComparable
            foreach (StudentIComarable s in list)
            {
                Console.WriteLine(s.StudentName + "   " + s.StudentId + "    " + s.StudentMarks);
            }
            ////// using IComparer if the source code is not available
            ///

            Console.WriteLine("\n");
            TestStudent z = new TestStudent();
            list.Sort(z);  //if i dont pass parameter then it sorts according to id
            foreach (StudentIComarable s in list)
            {
                Console.WriteLine(s.StudentName + "   " + s.StudentId + "    " + s.StudentMarks);
            }


            // if will sort 2 element from the 1st index
            Console.WriteLine("\n");
            list.Sort(1,2,z);   // if will sort 2 element from the 1st index
            foreach (StudentIComarable s in list)
            {
                Console.WriteLine(s.StudentName + "   " + s.StudentId + "    " + s.StudentMarks);
            }


            Console.WriteLine("\n");
            //using Comparision Delegate
            list.Sort(delegate(StudentIComarable a,StudentIComarable b) { return a.StudentName.CompareTo(b.StudentName); });
            foreach (StudentIComarable s in list)
            {
                Console.WriteLine(s.StudentName + "   " + s.StudentId + "    " + s.StudentMarks);
            }

        }


        // override the compare Method
        public int Compare(StudentIComarable x, StudentIComarable y)
        {
            if (x.StudentMarks > y.StudentMarks)
                return 1;
            else if (x.StudentMarks < y.StudentMarks)
                return -1;
            else
                return 0;
        }

        

    }




    //calling in other class

    //public class ComparerStudent : IComparer<StudentIComarable>
    //{
    //    public int Compare(StudentIComarable x, StudentIComarable y)
    //    {
    //        if (x.StudentMarks > y.StudentMarks)
    //            return 1;
    //        else if(x.StudentMarks < y.StudentMarks)
    //            return -1;
    //        else
    //            return 0;
    //    }
    //}
}
