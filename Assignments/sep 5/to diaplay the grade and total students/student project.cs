using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_5_2018
{
    class studentlist
    {
        static void Main(string[] args)
        {
            studentdetails[] studentList = new studentdetails[264];
            int studcnt = 0;
            int[] grade = new int[12];

            while (true)
            {
                Console.WriteLine("Press 1.Add Student Details \t 2.Show Student Count Per Grade \tPress Any key to exit");

                switch (Console.ReadLine())
                {
                    case "1":

                        bool flag = true;
                        studentdetails s = new studentdetails();
                        Console.WriteLine("Enter Roll No");
                        //s.rollNo = Int32.Parse(Console.ReadLine());
                        s.rollno = 0;
                        bool rollcheck = int.TryParse(Console.ReadLine(), out s.rollno);
                        while (!rollcheck)
                        {
                            Console.WriteLine("Enter a valid roll number");
                            rollcheck = int.TryParse(Console.ReadLine(), out s.rollno);
                        }
                        Console.WriteLine("Enter Grade");

                        s.grade = 0;
                        rollcheck = int.TryParse(Console.ReadLine(), out s.grade);

                        while (!rollcheck)
                        {
                            Console.WriteLine("Enter a valid Grade Between 1 to 12");
                            rollcheck = int.TryParse(Console.ReadLine(), out s.grade);
                        }

                        if (s.grade >= 1 && s.grade <= 12)
                        {
                            if (grade[s.grade - 1] >= 22)
                            {
                                Console.WriteLine("grade" + s.grade + " is full!!!. Cannot add student");
                                break;
                            }
                            grade[s.grade - 1]++;
                            flag = true;
                            Console.WriteLine("Enter First Name");
                            s.firstname = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            s.lastname = Console.ReadLine();
                        }
                        else
                        {
                            flag = false;
                        }

                        int ln = studentList.Length;
                        if (flag)
                        {
                            if (studcnt <= 264)
                            {
                                studentList[studcnt] = s;
                                studcnt++;
                            }
                            Console.WriteLine("The Information Entered");
                            Console.WriteLine("Grade :" + s.grade + "\tRollNo :" + s.rollno + " \t First Name :" + s.firstname + "\t Last Name :" + s.lastname);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Data");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Students Per Grade");

                        Console.WriteLine("---------------------------Student Details-------------------------------");
                        Console.WriteLine("Grade\t\t Total Students");
                        int ct = 1;
                        foreach (int gr in grade)
                        {

                            Console.WriteLine(ct + "\t\t" + gr);
                            ct++;
                        }


                        break;







                }
            }
        }
    }
}
