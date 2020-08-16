using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ContactBook
{
    class Program
    {
        // utilize IContactManager here

        static void Main(string[] args)
        {
            string input;

            input = Console.ReadLine().ToLower();
            if (input == "add")
            {
                ContactModel newcontact = new ContactModel();

                StreamWriter contactfile = new StreamWriter(@"C:\Users\Angela Egerega\Desktop\ContactBookTest\ContactBookTest\ContactDB.txt", true);


                Console.Write("Enter Name: ");
                newcontact.name = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
               newcontact.emailAddress = Console.ReadLine();

                Console.Write("Enter Email Address: ");
                newcontact.phoneNumber = Console.ReadLine();

                var contact = new List<ContactModel>()
                {
                    new ContactModel { name = "", emailAddress = "", phoneNumber = ""}
                };

                contactfile.WriteLine($"" + $"{newcontact.name}|" + $"{newcontact.emailAddress} | " + $"{newcontact.phoneNumber}|");
                contactfile.Close();
                Console.WriteLine("Saved Successfuly");
                // add new contact here

                // accept all parameters to fit model here using Console.ReadLine() for each property one by one
                // save contact
            }
            else if (input.StartsWith("get")) // e.g: get 1 (retrieves contact with ID=1)
            {
                // get contact by ID here
                string str = input.Split(' ')[1]; // retrieve ID of contact from command

                // get contact info and print in the below format

                // ID: 1
                // Name: James Khan
                // Phone: 09099999999
                // Email: james.khan@gmail.com
            }
            else if (input == "detall")
            {
                // get all contact and print them in the below format
                // ID: 1, Name: James Khan, Phone: 09099999999, Email: james.khan@gmail.com

                // print here
            }
            else if (input.StartsWith("delete")) // e.g: get 1 (delete contact with ID=1)
            {
                // get contact by ID here
                string str = input.Split(' ')[1]; // retrieve ID of contact to delete


                // delete here
            }
        }
    }
}
