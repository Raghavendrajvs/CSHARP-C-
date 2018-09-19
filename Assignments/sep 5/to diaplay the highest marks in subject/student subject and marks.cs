using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_5_2018
{
    class studentmarks
    {
        static studenttotal[] studentList = new studenttotal[264];
        static void Main(string[] args)
        {
            subjects sub = new subjects();
            Console.WriteLine("Enter the subject Names");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("subject\t" + (i + 1) + ":");
                sub.subject[i] = Console.ReadLine();
            }
            int studcnt = 0;
            int[] grade = new int[12];
            Console.WriteLine("---------------Welocme To Student Application---------------");
            while (true)
            {
                Console.WriteLine("Press 1.Add Student Details \t 2.Show Student Count Per Grade \t 3.Display Rank  \tPress Any key to exit");

                switch (Console.ReadLine())
                {
                    case "1":

                        bool flag = true;
                        studenttotal s = new studenttotal();
                        Console.WriteLine("Enter Roll No");

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
                                Console.WriteLine("Grade" + s.grade + " is full!!!. Cannot add student");
                                break;
                            }
                            grade[s.grade - 1]++;
                            flag = true;
                            Console.WriteLine("Enter First Name");
                            s.firstname = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            s.lastname = Console.ReadLine();
                           
                            //Console.WriteLine("Subject 1 :");
                            //sub.subject[0] = Console.ReadLine().Trim();
                            //Console.WriteLine("Subject 2 :");
                            //sub.subject[1] = Console.ReadLine().Trim();
                            //Console.WriteLine("Subject 3 :");
                            //sub.subject[2] = Console.ReadLine().Trim();
                            //Console.WriteLine("Subject 4 :");
                            //sub.subject[3] = Console.ReadLine().Trim();
                            //Console.WriteLine("Subject 5 :");
                            //sub.subject[4] = Console.ReadLine().Trim();
                            //Console.WriteLine("Subject 6 :");
                            //sub.subject[5] = Console.ReadLine().Trim();


                            double total = 0;
                            s.percentage = 0;
                            for (int i = 0; i < 6; i++)
                            {
                                s.marks[i] = 0;
                                Console.WriteLine("Enter marks for " + sub.subject[i]);
                                rollcheck = int.TryParse(Console.ReadLine(), out s.marks[i]);

                                total += s.marks[i];


                            }

                            double per = Convert.ToDouble((total / 600) * 100);

                            s.percentage = per;
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
                            Console.WriteLine("Grade :" + s.grade + "\tRollNo :" + s.rollno + " \t First Name :" + s.firstname + "\t Last Name :" + s.lastname + "\t Percentage " + s.percentage + "%");
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

                    case "3":
                        Console.WriteLine("Rank\t\tName\t\tPercent");

                        //double maxpercent = 0;
                        if (studentList.Length > 0)
                        {
                            studenttotal sd = new studenttotal();
                            sd = null;

                            for (int i = 0; i < studentList.Length - 1; i++)
                            {
                                bool f = false;
                                for (int j = 0; j < studentList.Length - 1; j++)
                                {
                                    if (studentList[j] != null && studentList[j + 1] != null)
                                    {
                                        if (studentList[j + 1].percentage > studentList[j].percentage)
                                        {
                                            sd = studentList[j];
                                            studentList[j] = studentList[j + 1];
                                            studentList[j + 1] = sd;
                                            flag = true;
                                        }
                                    }
                                }
                                //if (studentList[i] != null)
                                //{
                                //    if (studentList[i].percentage < temp.percentage)
                                //    {
                                //        StudentDetails sdi = new StudentDetails();
                                //        temp = studentList[i];

                                //    }
                                //}
                            }
                        }

                        Console.WriteLine("Rank\t\t Name\t\t Percentage");
                        int iterator = 1;
                        foreach (studenttotal sdet in studentList)
                        {
                            if (sdet != null)
                                Console.WriteLine(iterator + "\t\t" + sdet.firstname + "\t\t" + sdet.percentage);
                            iterator++;
                        }



                        //}
                        break;

                    case "4":


                        break;

                }

                Console.ReadKey();

            }



            

        }

        

    }   
    
}
