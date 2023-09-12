using Eco.Persistence.Connection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARVIS_Virtual_Assistant
{
    internal class ListDesigner
    {
        private SqlConnection getServerConnection()
        {
            KeyVaultManager keyVaultManager = new KeyVaultManager();
            SqlConnection _serverConnection = new SqlConnection(keyVaultManager.GetSecret("UserInfoConnString"));
            return _serverConnection;
        }
        public void createList(string tableName, string columnName, string dataType)
        {
            
            String querryForCreation = "CREATE TABLE "  + tableName + " (\r\n    " + columnName + " " + dataType + " );";
            SqlCommand _command = new SqlCommand(querryForCreation, getServerConnection());
            _command.ExecuteNonQuery();
        }

        public void deleteList()
        {

        }
    }
}
