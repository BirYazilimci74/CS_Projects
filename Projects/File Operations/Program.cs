using System;
using System.IO;

namespace Deneme
{
    class Program
    {

        public static string FirstLatterUpper(string? str)
        {
            return str.Substring(0,1).ToUpper() + str.Substring(1).ToLower();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students: ");
            int nbr_students = Convert.ToInt32(Console.ReadLine());
            
            if (nbr_students <= 0) {return;}

            Student[] students = new Student[nbr_students];

            for (int i = 0; i < nbr_students; i++)
            {
                students[i] = new Student(); // We need to create a new Student object for each student.

                Console.WriteLine("Enter {0}.Student's name: ", i+1);
                students[i].Name = Console.ReadLine();                // to get the name of the student.

                Console.WriteLine("Enter {0}.Student's surname: ", i+1);
                students[i].Surname = Console.ReadLine();             // to get the surname of the student.

                Console.WriteLine("Enter {0}.Student's id: ", i+1);
                students[i].Id = Convert.ToInt32(Console.ReadLine()); // to get the id of the student.

                string? grades_str;
                string[] grades_arr = new string[3];
                do
                {
                    Console.WriteLine("Enter {0}.Student's 3 grades: ", i+1);
                    grades_str = Console.ReadLine();       // to get the grades as string.
                    grades_arr = grades_str.Split(' ');    // to split the string like 34 56 78 ---> {'34','56','78'}
                    
                    if (grades_arr.Length == 3)
                    {
                        for (int j = 0; j < grades_arr.Length; j++)
                        {
                            students[i].Grades[j] = Convert.ToInt32(grades_arr[j]); // to convert each string grades to int.
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter exactly 3 grades!");
                    }

                } while (grades_arr.Length != 3);

                var avrg = (students[i].Grades.Sum()) / 3; // to calculate average of grades.
            //    if (avrg >= 50)
            //        students[i].is_Passed = true;
            //    else
            //        students[i].is_Passed = false;
                students[i].isPassed = avrg >= 50 ? true : false; // this has same meaning with above if statement.
            }

            Console.Clear();
            string[] lines = new string[nbr_students*6]; // we need to create an stringBuilder. 

            // Her satırı array içine atıcaz ve her satırı tek tek yazdırıcaz.
            for (int i = 0; i < nbr_students; i++)
            {
                int row = i * 6;
                lines[row] = "----------"+ (i+1) +".Student----------";
                lines[row+1] = FirstLatterUpper(students[i].Name) + " " + students[i].Surname.ToUpper();
                lines[row+2] = "Id: " + students[i].Id;
                lines[row+3] = "Grades:" + string.Join(" ", students[i].Grades);

                string isPassed = students[i].isPassed ? "Student has passed!" : "Student has NOT passed!";
                lines[row+4] = isPassed;
                lines[row+5] = "";
            }
            File.WriteAllLines("Dosya.txt",lines);
        }
    }
}