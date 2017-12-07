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
using System.Net;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Net.Mime;
using System.Drawing;
using System.Device.Location;
using System.Data;
using Plugin.Geolocator;
using System.Data.SqlClient;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-VKHJA5S7\SQLEXPRESS;Initial Catalog=UserLoginProject1;Integrated Security=True");
        
        private GeoCoordinateWatcher Watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);

        public Window1()
        {
            InitializeComponent();
            Watcher.Start();
                        

        }


        private void Update_Contacts_Click(object sender, RoutedEventArgs e)
        {
          EmergencyContacts emergencycontacts = new EmergencyContacts();
            this.Hide();
            emergencycontacts.Show();
        }

       
              

                
       
        
        
        

        public void HelpButton_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                SqlCommand SelectCommand = new SqlCommand("SELECT EmailAddress FROM EmergencyContacts", sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();

                myreader = SelectCommand.ExecuteReader();

                List<String> lstEmails = new List<String>();
                while (myreader.Read())
                {
                    lstEmails.Add(myreader[0].ToString());
                    //strValue=myreader["email"].ToString();
                    //strValue=myreader.GetString(0);
                }
               sqlcon.Close();

                for (int n = 0; n < lstEmails.Count; n++)
                {
                    var whereat = Watcher.Position.Location;
                    var Latitude = whereat.Latitude.ToString("0.000000");
                    var Longitude = whereat.Longitude.ToString("0.000000");



                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;

                    client.EnableSsl = true;
                    client.Timeout = 1000000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("chetanahelpapp@gmail.com", "helpapp123");
                    MailMessage Message = new MailMessage();
                    Message.To.Add(lstEmails[n]);
                    Message.From = new MailAddress("chetanahelpapp@gmail.com");
                    Message.Subject = "HELP!!!!!";
                    Message.Body = "I am in a suspicious area and need help. The Latitude is: " + Latitude + " and The Longitude is: " + Longitude + "Please come and help me.";
                    client.Send(Message);
                    MessageBox.Show("Your Emergency Contacts Have Been Notified With Your Coordinates. Longitude " + Longitude + " Lattitude: " + Latitude + ".");

                };

                sqlcon.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
                         
               

        private void CurrentLocation_Click(object sender, RoutedEventArgs e)
        {
            var whereat = Watcher.Position.Location;
            var Latitude = whereat.Latitude.ToString("0.000000");
            var Longitude = whereat.Longitude.ToString("0.000000");

            sqlcon.Open();
            string query1 = "INSERT INTO GeoPoint (Longitude, Latitude) Values('" + Longitude + "', '" + Latitude + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query1, sqlcon);
            DataTable dtb1 = new DataTable();
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Congratulations!Your Location Has Been Updated!" +"Logitude = " + Longitude + "Lattitdue = " + Latitude);
        }
    }
}
