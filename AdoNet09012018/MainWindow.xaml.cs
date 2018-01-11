using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace AdoNet09012018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sqlconnect = "";
        private string oledbconnect = "";
        private string odbcconnect = "";
        public MainWindow()
        {
            InitializeComponent();
            sqlconnect = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            oledbconnect = ConfigurationManager.ConnectionStrings["Oldb"].ConnectionString;
            odbcconnect = ConfigurationManager.ConnectionStrings["Odbc"].ConnectionString;
        }

        private void SqlClient_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(sqlconnect))
            {
                try
                {
                    conn.Open();
                    SqlClientLabel.Text = "Подключился";
                }
                catch(Exception ex)
                {
                    SqlClientLabel.Text = " Ne Подключился";
                }

               
            }
            using (SqlConnection conn = new SqlConnection("Data Source=85.29.128.138;Initial Catalog=AF_Exam; User ID=sa;Password=Shag1115;"))
            {
                try
                {
                    conn.Open();
              
                    SqlClientLabel.Text = "Подключился";
                    SqlClientLabel.Text += conn.ConnectionString;
                    SqlClientLabel.Text += conn.Database;
                    SqlClientLabel.Text += conn.ServerVersion;
                    SqlClientLabel.Text += conn.ConnectionString;
                    SqlClientLabel.Text += conn.State.ToString();
                    SqlClientLabel.Text += conn.ConnectionTimeout.ToString();
                }
                catch (Exception ex)
                {
                    SqlClientLabel.Text = " Ne Подключился";
                }

            }       

        }

       
        private void OleClientButton_Click(object sender, RoutedEventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(oledbconnect))
            {
                try
                {
                    conn.Open();
                    OleClientLabel.Text = "Подключился";
                    OleClientLabel.Text += conn.ConnectionString;
                    OleClientLabel.Text += conn.Database;
                    OleClientLabel.Text += conn.ServerVersion;
                    OleClientLabel.Text += conn.ConnectionString;
                    OleClientLabel.Text += conn.State.ToString();
                    OleClientLabel.Text += conn.ConnectionTimeout.ToString();
                }
                catch (Exception ex)
                {
                    OleClientLabel.Text = " Ne Подключился";
                }
            }
        }
        private void OdbcClientButton_Click(object sender, RoutedEventArgs e)
        {
            using (OdbcConnection conn = new OdbcConnection(odbcconnect))
            {
                try
                {
                    conn.Open();
                    OdbcClientLabel.Text = "Подключился";
                    OdbcClientLabel.Text += conn.ConnectionString;
                    OdbcClientLabel.Text += conn.Database;
                    OdbcClientLabel.Text += conn.ServerVersion;
                    OdbcClientLabel.Text += conn.ConnectionString;
                    OdbcClientLabel.Text += conn.State.ToString();
                    OdbcClientLabel.Text += conn.ConnectionTimeout.ToString();
                }
                catch (Exception ex)
                {
                    OdbcClientLabel.Text = " Ne Подключился";
                }
            }
        }
    }
}
