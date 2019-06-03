using _13._05._2019_Task.Command;
using _13._05._2019_Task.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05._2019_Task.ViewModel
{
   public class SqlViewModel:BaseViewModel
    {
      public  MainWindow MainWindow;
        public Ok ok { get; set; }
        public SqlViewModel(MainWindow mainWindow)
        {
            Currentsql = new SqlEntity();
            Sqllist = new List<SqlEntity>();
     
            ok = new Ok(this);
            MainWindow = mainWindow;
        }
        SqlEntity currentsql;
        public SqlEntity Currentsql
        {
            get
            {
                return currentsql;
            }
            set
            {
                currentsql = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Currentsql)));
            }
        }

        List<SqlEntity> sqllist;
        public List<SqlEntity> Sqllist
        {
            get
            {
                return sqllist;
            }
            set
            {
                sqllist = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Sqlist"));
            }
        }




    }
}
