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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for EmergencyContacts.xaml
    /// </summary>
    public partial class EmergencyContacts : Window
    {
        public EmergencyContacts()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-VKHJA5S7\SQLEXPRESS;Initial Catalog=UserLoginProject1;Integrated Security=True");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sqlcon.Open();
            string query1 = "INSERT INTO EmergencyContacts (LastName, FirstName, EmailAddress) Values('" + LastName1.Text.Trim() + "', '" + FirstName1.Text.Trim() + "','" + EmailAddress.Text.Trim() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Congratulations!You created succesfully updated your emergency contact!");

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Window1 objfromLoggedin = new Window1();
            this.Hide();
            objfromLoggedin.Show();
        }
    }
}
