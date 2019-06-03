using _13._05._2019_Task.View;
using _13._05._2019_Task.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _13._05._2019_Task.Command
{
    public class Ok : ICommand
    {
        public event EventHandler CanExecuteChanged;
        SqlViewModel sqlViewModel;
        public Ok(SqlViewModel sqlViewModel)
        {
            this.sqlViewModel = sqlViewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            sqlViewModel.Sqllist.Add(sqlViewModel.Currentsql);
            string json = JsonConvert.SerializeObject(sqlViewModel.Sqllist);
            System.IO.File.WriteAllText("Sql.json", json);
            sqlViewModel.MainWindow.Close();
        }
    }
}
