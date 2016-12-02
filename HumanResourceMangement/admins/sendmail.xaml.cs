using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace admins
{
    /// <summary>
    /// Interaction logic for sendmail.xaml
    /// </summary>
    public partial class sendmail : Page
    {
        public sendmail()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            show();
            textBox.IsEnabled = false;
            textBox1.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.IsEnabled = true;
            textBox1.IsEnabled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[mail]
([mail_sent_as],[path_to_send_mail])
     VALUES('" + textBox.Text + "','" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from mail", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mail");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[mail]
      WHERE (mail_sent_as= '" + textBox.Text + "' )", con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
    }
}
