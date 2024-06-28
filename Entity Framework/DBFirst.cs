using Entity_Framework.Model;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class DBFirst
    {
        public void DBFirstOperation()
        {
            DBMSProje1Entities db = new DBMSProje1Entities();

            List(db);

            //AddAuthor(db, 107, "Hamdiye", 11223);
            //DeleteAuthor(db);
            UpdateAuthor(db);

            List(db);
        }

        private void List(DBMSProje1Entities db)
        {
            
            var authors = db.Authors.ToList();

            Console.WriteLine("\nID, Name");
            Console.WriteLine("-----------------------");

            foreach (var author in authors)
            {
                Console.WriteLine($"{author.AUTHOR_ID}, {author.AUTHOR_NAME}");
            }
        }

        private void AddAuthor(DBMSProje1Entities db,int id, string name, int password)
        {
            Author author1 = new Author();
            author1.AUTHOR_ID = id;
            author1.AUTHOR_NAME = name;
            author1.AUTHOR_PASSWORD = password;

            db.Authors.Add(author1);
            db.SaveChanges();
            Console.WriteLine($"\n\n{author1.AUTHOR_NAME} added...\n");
        }

        private void DeleteAuthor(DBMSProje1Entities db)
        {
            Console.WriteLine("Enter the ID you want to delete: ");
            int idToDelete = Convert.ToInt16(Console.ReadLine());
            var author = db.Authors.SingleOrDefault(a => a.AUTHOR_ID == idToDelete);

            db.Authors.Remove(author);
            db.SaveChanges();
        }

        private void UpdateAuthor(DBMSProje1Entities db)
        {
            Console.WriteLine("\nEnter the ID you want to update: ");
            int idToUpdate = Convert.ToInt16(Console.ReadLine());

            var author = db.Authors.SingleOrDefault(a => a.AUTHOR_ID == idToUpdate);

            Console.WriteLine("\nEnter the Name: ");
            author.AUTHOR_NAME = Console.ReadLine();

            Console.WriteLine("\nEnter the Password: ");
            author.AUTHOR_PASSWORD = Convert.ToInt32(Console.ReadLine());

            db.SaveChanges();
        }
    }
}
