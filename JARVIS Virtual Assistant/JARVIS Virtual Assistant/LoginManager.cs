using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JARVIS_Virtual_Assistant
{
    internal class LoginManager
    {
        //logtype : 1 Guest
        //logtype : 2 Admin 
        //logtype : 0 unauthorized
        public short logType;
        private short Login(string Username, string Password)
        {
            //Check the encrypted SQL server for user info


            KeyVaultManager keyVaultManager = new KeyVaultManager();
            SqlConnection _connection = new SqlConnection(keyVaultManager.GetSecret("UserInfoConnString"));

            short loginType = 0;

            if (_connection != null)
            {
                try
                {
                    bool containAdmin = Username.IndexOf("admin", StringComparison.OrdinalIgnoreCase) >= 0;
                    String querry = "SELECT * FROM Login_Information Where Username = '" + Username + "' AND Password = '" + Password + "'";
                    SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(querry, _connection);
                    DataTable dTable = new DataTable();
                    _sqlDataAdapter.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        if (containAdmin == true)
                        {
                            //admin access
                            loginType = 2;
                        }
                        else
                        {
                            //guest access
                            loginType = 1;
                        }
                    }
                    else
                    {
                        //not found
                        loginType = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    _connection.Close();
                }
            }

            return loginType;
        }

        public void Intro()
        {
            //Ask User for Input
            Console.WriteLine();
            Console.WriteLine("enter username and password"); //first line don't loop

            Console.WriteLine();
            string Username = Console.ReadLine();
            string Password = Console.ReadLine();

            //Thread.Sleep(350);
            Console.Clear();
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("\r\n   `7MMF'    db      `7MM\"\"\"Mq.`7MMF'   `7MF'`7MMF' .M\"\"\"bgd \r\n     MM     ;MM:       MM   `MM. `MA     ,V    MM  ,MI    \"Y \r\n     MM    ,V^MM.      MM   ,M9   VM:   ,V     MM  `MMb.     \r\n     MM   ,M  `MM      MMmmdM9     MM.  M'     MM    `YMMNq. \r\n     MM   AbmmmqMA     MM  YM.     `MM A'      MM  .     `MM \r\n(O)  MM  A'     VML    MM   `Mb.    :MM;       MM  Mb     dM \r\n Ymmm9 .AMA.   .AMMA..JMML. .JMM.    VF      .JMML.P\"Ybmmd\" \r\n ");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("connecting...");
            LoginDetection(Username, Password);
        }

        public void LoginDetection(string Username, string Password)
        {
            //Return the type of Login;
            short loginType = Login(Username, Password);
            logType = loginType;

            switch (loginType)
            {
                case 0:
                    //not found any login data
                    Console.WriteLine("login information incorrect");
                    Intro();
                    break;
                case 1:
                    //guest access
                    Console.WriteLine("-guest access authorized");
                    break;
                case 2:
                    //admin acccess
                    Console.WriteLine("-admin access authorized");
                    break;
            }
        }
    }
}
