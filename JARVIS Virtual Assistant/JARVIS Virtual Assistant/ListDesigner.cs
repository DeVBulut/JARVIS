using Eco.Persistence.Connection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JARVIS_Virtual_Assistant
{
    internal class ListDesigner
    {
        public void createList(string tableName, string columnName, string dataType)
        {
            KeyVaultManager keyVaultManager = new KeyVaultManager();
            SqlConnection _serverConnection = new SqlConnection(keyVaultManager.GetSecret("UserInfoConnString"));
            String querryForCreation = "CREATE TABLE "  + tableName + " (\r\n    " + columnName + " " + dataType + " );";
            try
            {
                _serverConnection.Open();
                Console.WriteLine(" Connection established successfully.");
            }catch (Exception ex) { Console.WriteLine(" Could not create a connection " + ex); }
            SqlCommand _command = new SqlCommand(querryForCreation, _serverConnection);
            _command.ExecuteNonQuery();
            Console.WriteLine(" Command Executed Successfully.");
        }

        public void deleteList(string tableName)
        {
            KeyVaultManager keyVaultManager = new KeyVaultManager();
            SqlConnection _serverConnection = new SqlConnection(keyVaultManager.GetSecret("UserInfoConnString"));
            try
            {
                _serverConnection.Open();
                Console.WriteLine(" Connection established successfully.");
            }
            catch (Exception e) { Console.WriteLine(" Could not create a connection " + e.Message); }

            try
            {
                SqlCommand _command = new SqlCommand("DROP TABLE " + tableName, _serverConnection);
                _command.ExecuteNonQuery();
                Console.WriteLine(" Command Executed Successfully.");
            }
            catch (Exception e) { Console.WriteLine(" Error code is " + e.Message); }

        }
    }
}
