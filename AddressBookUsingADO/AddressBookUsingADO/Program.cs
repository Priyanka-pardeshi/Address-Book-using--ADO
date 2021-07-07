using System;
using System.Data.SqlClient;

namespace AddressBookUsingADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book using ado .net");
            AddressBook AddressObj = new AddressBook();
            AddressObj.CreareConnection();
            Console.ReadKey();
        }

    }
}
