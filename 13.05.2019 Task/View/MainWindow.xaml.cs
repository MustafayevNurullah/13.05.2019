using _13._05._2019_Task.Entity;
using _13._05._2019_Task.SqlConnection1;
using _13._05._2019_Task.View;
using _13._05._2019_Task.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _13._05._2019_Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object filials;

        public MainWindow()
        {
            if (File.Exists("Sql.json"))
            {
                SqlDataAccess sqlDataAccess = new SqlDataAccess();
               if( sqlDataAccess.Connection()==false)
                {
                 InitializeComponent();
                SqlViewModel sqlViewModel = new SqlViewModel(this);
                DataContext = sqlViewModel;
                }
                else
                {
                    Welcome welcome = new Welcome();
                    welcome.Show();
                    this.Close();
                }
            }
            else
            {
                InitializeComponent();
                SqlViewModel sqlViewModel = new SqlViewModel(this);
                DataContext = sqlViewModel;
            }
        }
    }
}
