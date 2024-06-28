using CodeFirst.DAL;
using CodeFirst.Entities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class EFCodeFirst
    {
        public void CodeFirstOperations()
        {
            Context context = new Context();

            List(context);
            
            //Add(context);
            //Delete(context);
            Update(context);

            List(context);
        }

        private void List(Context context)
        {
            var students = context.Students.ToList();

            Console.WriteLine("********************");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.ID} - {student.Name} - {student.Age}");
            }
        }

        private void Add(Context context)
        {
            Student student = new Student();
            
            Console.WriteLine("\nEnter the Name to Update with: ");
            student.Name = Console.ReadLine();

            Console.WriteLine($"\nEnter the age of {student.Name}: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine($"{student.Name} added... \n");
        }

        private void Delete(Context context)
        {
            Console.WriteLine("\nEnter a Name to Delete: ");
            string nameToDelete = Console.ReadLine();
            var studentToDelete = context.Students.Where(std => std.Name.ToLower() == nameToDelete.ToLower()).FirstOrDefault();

            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
                Console.WriteLine($"{studentToDelete.Name} Deleted... \n");
            }
        }

        private void Update(Context context)
        {
            Console.WriteLine("\nEnter a Name to Update: ");
            string nameToUpdate = Console.ReadLine();
            var studentToUpdate = context.Students.Where(std => std.Name.ToLower() == nameToUpdate.ToLower()).FirstOrDefault();

            if (studentToUpdate != null)
            {
                Console.WriteLine("\nEnter Name to add: ");
                studentToUpdate.Name = Console.ReadLine();

                Console.WriteLine($"\nEnter the age of {studentToUpdate.Name}: ");
                studentToUpdate.Age = Convert.ToInt32(Console.ReadLine());

                context.SaveChanges();
                Console.WriteLine($"{studentToUpdate.Name} Updated... \n");
            }

        }
    }
}
