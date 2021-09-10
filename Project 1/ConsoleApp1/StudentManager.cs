using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StudentManager
    {

        public static void StudentRecord()
        {

            string name;
            string[] StudentName = new string[100];
            string[] StudentGrades = new string[100];
            int count = 0;
            do
            {
                Console.WriteLine("Enter student Name");
                 name = Console.ReadLine();
                if(name=="")
                {
                    break;
                }

                Console.WriteLine("Enter Student Grade");
                var grades = Console.ReadLine();
                StudentName[count] = name;
                StudentGrades[count] = grades;
                count++;


            } while (name != "");

            for(int i=0;i<count; i++)
            {
                Console.WriteLine("The {0} has scored {1} grades", StudentName[i], StudentGrades[i]);
            }
            
        }

        public static void StudentRecord1()
        {
            List<string> StudentNames = new List<string>();
            List<int> StudentGrades = new List<int>();

        }
       
    }
}
