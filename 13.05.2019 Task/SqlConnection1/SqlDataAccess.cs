using _13._05._2019_Task.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace _13._05._2019_Task.SqlConnection1
{
    public class SqlDataAccess
    {

         string Connectionstring{get;set;}
        public SqlDataAccess ()
        {

            string json = File.ReadAllText("Sql.json");
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            List<SqlEntity> list = new List<SqlEntity>();
               list = JsonConvert.DeserializeObject<List<SqlEntity>>(json);
            sqlConnectionStringBuilder.DataSource = list[0].Servername;
            sqlConnectionStringBuilder.InitialCatalog = list[0].Databasename;
            if(list[0].ServerAuthentication)
            {
            sqlConnectionStringBuilder.UserID = list[0].Username;
            sqlConnectionStringBuilder.Password = list[0].Password;
            }
            else
            {
            sqlConnectionStringBuilder.IntegratedSecurity = true;

            }
            Connectionstring = sqlConnectionStringBuilder.ToString();
        }
        public bool Connection()
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(Connectionstring))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception )
            {
            return false;
            }
        }


    }
}
