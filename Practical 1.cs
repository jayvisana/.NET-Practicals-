using System;

namespace Practical1
{
    class Student
    {
        private int grNo;
        private string name;
        private string course;
        private int semester;
        private double fees;
        private bool scholarship;

        private const double ScholarshipRate = 0.10;

        public Student()
        {
            Console.WriteLine("Student Admission Object Created\n");
        }

        public int GRNo
        {
            get { return grNo; }
            set { grNo = value; }
        }

        public void AcceptDetails()
        {
            Console.Write("Enter GR Number: ");
            grNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Course: ");
            course = Console.ReadLine();

            Console.Write("Enter Semester: ");
            semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course Fees: ");
            fees = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateFees()
        {
            if (fees > 50000)
            {
                scholarship = true;
                return fees - (fees * ScholarshipRate);
            }

            scholarship = false;
            return fees;
        }

        public void DisplayDetails()
        {
            double finalFees = CalculateFees();

            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine("GR Number      : " + grNo);
            Console.WriteLine("Name           : " + name);
            Console.WriteLine("Course         : " + course);
            Console.WriteLine("Semester       : " + semester);
            Console.WriteLine("Scholarship    : " + (scholarship ? "10% Applied" : "Not Eligible"));
            Console.WriteLine("Final Fees     : " + finalFees);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();

            st1.AcceptDetails();

            st1.DisplayDetails();

            Console.ReadKey();
        }
    }
}