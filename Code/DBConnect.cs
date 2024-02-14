﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Driving_School
{
    /*
     * In this class Create the connection between application and mysql database
     * we need to install xampp and mysql connector to this project
     * we need to create the student database
     */

    class DBconnect
    {
        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=drivingschool;");

        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}