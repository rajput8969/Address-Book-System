using System;

namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AddressBook\n");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    AddressBookImplementation.DriverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
