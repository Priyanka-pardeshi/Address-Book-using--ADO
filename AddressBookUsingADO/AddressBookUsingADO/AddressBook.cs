using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AddressBookUsingADO
{
    class AddressBook
    {
        public void CreareConnection()
        {
            try
            {
                string conStr = @"Data Source=PARDESHI-PC;Initial Catalog=Address;Integrated Security=True;Pooling=False";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
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
