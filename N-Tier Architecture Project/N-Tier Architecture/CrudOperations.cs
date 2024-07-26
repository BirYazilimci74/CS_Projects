using BusinessLayer.Concrate;
using System;
using System.Linq;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using BusinessLayer.FluentValidation;
using FluentValidation.Results;
using BusinessLayer.Abstract;

namespace N_Tier_Architecture
{
    public class CrudOperations
    {
        ILocationService locationService = new LocationManager(new EFLocationDAL());
        IMemberService memberService = new MemberManager(new EFMemberDAL());
        ICommentService commentService = new CommentManager(new EFCommentDAL());

        //Eğer new MemberManager() içine başka bir veri tabanı Kodları girersen o veri tavanı için çalışır. (Bu örnekte Entity Framework ile MSSQL)

        public void JoinForComments()
        {
            var comments = commentService.TCommentListWithLocationAndMember();

            foreach (var comment in comments)
            {
                Console.WriteLine($"{comment.Id} - {comment.MemberName} - {comment.LocationName} - {comment.CommentTitle}");
            }
        }

        public void MemberCrud()
        {
            while (true)
            {
                List();

                Console.WriteLine("Member = Quit:0 Delete:1 Insert:2 Update:3");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        DeleteMember();
                        break;
                    case 2:
                        InsertMember();
                        break;
                    case 3:
                        UpdateMember();
                        break;
                }

            }
        }

        public void LocationCrud()
        {
            while (true)
            { 
                List();

                Console.WriteLine("Location = Quit:0 Delete:1 Insert:2 Update:3");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        DeleteLocation();
                        break;
                    case 2:
                        InsertLocation();
                        break;
                    case 3:
                        UpdateLocation();
                        break;
                }
            
            }
        }

        public void UpdateMember()
        {
            Console.WriteLine("Enter a member name to update:");
            string memberNameToUpdate = Console.ReadLine();

            Member memberToUpdate = memberService
                                        .TGetList()
                                        .FirstOrDefault(member => member.Name.ToLower().Contains(memberNameToUpdate.ToLower()));

            Console.WriteLine($"\nEnter new name for {memberToUpdate.Name}:");
            Member updatedMember = new Member(); 
            updatedMember.Name = Console.ReadLine();

            MemberValidator validationRules = new MemberValidator();
            ValidationResult validation = validationRules.Validate(updatedMember);
            if (validation.IsValid)
            {
                memberToUpdate.Name = updatedMember.Name;
                memberService.TUpdate(memberToUpdate);
                Console.Clear();
                Console.WriteLine("Member added successfuly.\n\n");
            }
            else
            {
                Console.Clear();
                foreach (var failure in validation.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
                Console.ReadLine();
            }
        }
        public void DeleteMember()
        {
            Console.WriteLine("Enter a member name to delete:");
            string memberNameToDelete = Console.ReadLine();

            Member memberToDelete = memberService
                                        .TGetList()
                                        .Find(member => member.Name.ToLower() == memberNameToDelete.ToLower());

            memberService.TDelete(memberToDelete);
            Console.Clear();
        }
        public void InsertMember()
        {
            Member newMember = new Member();
            Console.WriteLine("Enter a member name to insert:");
            newMember.Name = Console.ReadLine();

            MemberValidator validationRules = new MemberValidator();
            ValidationResult validation = validationRules.Validate(newMember);
            if (validation.IsValid)
            {
                memberService.TInsert(newMember);
                Console.Clear();
                Console.WriteLine("Member added successfuly.\n\n");
            }
            else
            {
                Console.Clear();
                foreach (var failure in validation.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                    Console.ReadLine();
                }
            }
        }


        public void UpdateLocation()
        {
            Console.WriteLine("Enter a Location name to update:");
            string locationNameToUpdate = Console.ReadLine();

            Location locationToUpdate = locationService
                                        .TGetList()
                                        .FirstOrDefault(location => location.Name.ToLower() == locationNameToUpdate.ToLower());

            Console.WriteLine($"\nEnter new name for {locationToUpdate.Name}:");
            Location updatedLocation = new Location();
            updatedLocation.Name = Console.ReadLine();

            LocationValidator validationRules = new LocationValidator();
            ValidationResult validation = validationRules.Validate(updatedLocation);
            if (validation.IsValid)
            {
                locationToUpdate.Name = updatedLocation.Name;
                locationService.TUpdate(locationToUpdate);
                Console.Clear();
                Console.WriteLine("Location updated successfully!!!");
            }
            else
            {
                Console.Clear();
                foreach(var failure in validation.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
                Console.ReadLine();
            }
        }
        public void DeleteLocation()
        {
            Console.WriteLine("Enter a Location name to delete:");
            string locationNameToDelete = Console.ReadLine();

            Location locationToDelete = locationService
                                        .TGetList()
                                        .Find(location => location.Name.ToLower() == locationNameToDelete.ToLower());

            locationService.TDelete(locationToDelete);
            Console.Clear();
        }
        public void InsertLocation()
        {
            Location newLocation = new Location();
            Console.WriteLine("Enter a Location name to insert:");
            newLocation.Name = Console.ReadLine();

            LocationValidator validationRules = new LocationValidator();
            ValidationResult validation = validationRules.Validate(newLocation);
            if (validation.IsValid)
            {
                locationService.TInsert(newLocation);
                Console.Clear();
                Console.WriteLine("Location added successfuly.\n\n");
            }
            else
            {
                Console.Clear();
                foreach (var failure in validation.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
            }
        }


        public void List()
        {
            var locations = locationService.TGetList();
            var members = memberService.TGetList();
            var comments = commentService.TGetList();

            foreach (var location in locations)
            { 
                Console.WriteLine(location.Name);
            }

            Console.WriteLine("\n------------------------------\n");
            
            foreach (var member in members)
            {
                Console.WriteLine(member.Name);
            }

            Console.WriteLine("\n------------------------------\n");

            foreach (var comment in comments)
            {
                Console.WriteLine(comment.Title);
            }
            
            Console.WriteLine("\n******************************************\n");
        }
    }
}
