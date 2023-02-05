using System;
using System.Reflection.Metadata;

namespace Address_Book
{
    internal class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("FirstName");
            Console.ReadLine();
            Console.WriteLine("LastName");
            Console.ReadLine();
            Console.WriteLine("Address");
            Console.ReadLine();
            Console.WriteLine("City");
            Console.ReadLine(); 
            Console.WriteLine("State");
            Console.ReadLine();
            Console.WriteLine("Zip");
            Console.ReadLine();
            Console.WriteLine("PhoneNumber");
            Console.ReadLine();
            Console.WriteLine("EmailAddress");
            Console.ReadLine();
        }
    }
}
