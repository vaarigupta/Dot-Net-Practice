using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {
        string name;
        int phone;
        string email;
        string branch;
        int rollNumber;

        public int Phone
        {
            get
            {
                return phone;
            }
            set{ phone = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        public int RollNumber
        {
            get
            {
                return rollNumber;
            }
            set { rollNumber = value; }
        }
        public string Branch
        {
            get
            {
                return branch;
            }
            set { branch = value; }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set { email = value; }
        }
        public static int Count = 0;
   
    public void StudentDetails()
    {
        List<Student> students = new List<Student>();

        bool flag = true;

        while (flag)
        {
            Console.WriteLine("Enter the details :");
            Student student = new Student();
            Console.WriteLine("Enter student Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student Email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter student Phone Number");
            student.Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Roll Number");
            student.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Branch Name");
            student.Branch = Console.ReadLine();
            students.Add(student);
            Student.Count++;
            Console.WriteLine("Do you want to add more students :y/n");
            string input = Console.ReadLine();
            flag = (input == "y") ? true : false;

        }

        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Name: {0}", students[i].Name);
            Console.WriteLine("Student Name: {0}", students[i].Email);
            Console.WriteLine("Student Name: {0}", students[i].Phone);
            Console.WriteLine("Student Name: {0}", students[i].RollNumber);
            Console.WriteLine("Student Name: {0}", students[i].Branch);
        }




    }

    }


}
