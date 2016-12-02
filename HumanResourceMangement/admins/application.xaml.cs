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
    /// Interaction logic for application.xaml
    /// </summary>
    public partial class application : Page
    {
        public application()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[application]
([application_name],[application_email])
     VALUES('" + textBox1.Text + "','" + textBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }
        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select application_name,application_email  from application", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("subscription");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[application]
      WHERE (application_name= '" + textBox1.Text + "' )", con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
    }
}
