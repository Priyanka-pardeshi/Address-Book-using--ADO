using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AddressBookUsingADO
{
    class AddressBook
    {
        public void Insert()
        {
            try
            {
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address Name:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();

                Console.WriteLine("Enter State:");
                string state = Console.ReadLine();

                Console.WriteLine("Enter zip:");
                int zip = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter phone:");
                int phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter mail:");
                string mail = Console.ReadLine();

                string QueryStr = "inser into AddressTB values('"+ firstName+"','"+lastName+"','"+address+"','"+city+"','"+state+"',"+zip+","+phone+",'"+mail+"') ";
                Console.WriteLine(QueryStr);

                string conStr = @"Data Source=PARDESHI-PC;Initial Catalog=Address;Integrated Security=True;Pooling=False";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand(QueryStr, con);
                int result = sqlCmd.ExecuteNonQuery();
                Console.WriteLine("reord insered into table");

                Console.WriteLine("connection established");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
   }
    
}
