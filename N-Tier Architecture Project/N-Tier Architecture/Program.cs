using System;
namespace N_Tier_Architecture
{
    public class Program
    {
        static void Main(string[] args)
        {
            CrudOperations crudOperations = new CrudOperations();

            crudOperations.LocationCrud();
            //crudOperations.MemberCrud();

            //crudOperations.JoinForComments();
            Console.ReadLine();
        }
    }
}
