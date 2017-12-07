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
using System.Data.SqlClient;
using System.Data;
using Plugin.Geolocator;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            sqlcon.Open();
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-VKHJA5S7\SQLEXPRESS;Initial Catalog=UserLoginProject1;Integrated Security=True");
            string query = "select * From Persons where Username ='" + UsernameText.Text.Trim() + "'and Password='" + PasswordText.PasswordChar + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if(dtb1.Rows.Count == 1)
            {
                Window1 objfromLoggedin = new Window1();
                this.Hide();
                objfromLoggedin.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username And LogIn. Please Check Your UserName And PassWord");

            }

            sqlcon.Close();
            

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-VKHJA5S7\SQLEXPRESS;Initial Catalog=UserLoginProject1;Integrated Security=True");
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            sqlcon.Open();  
            string query1 = "INSERT INTO Persons (Username, Password) Values('" + UsernameText.Text.Trim()+"', '"+ PasswordText.PasswordChar + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Congratulations!You created your account succesfully!");
            

        }
    }
}
