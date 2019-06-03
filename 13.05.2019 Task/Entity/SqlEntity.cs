using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05._2019_Task.Entity
{
   public class SqlEntity
    {
        public string Servername { get; set; }
        public string Databasename { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool ServerAuthentication { get; set; }
    }
}
