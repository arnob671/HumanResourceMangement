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
using System.Data;
using System.Data.SqlClient;

namespace admins
{
    /// <summary>
    /// Interaction logic for languages.xaml
    /// </summary>
    public partial class languages : Page
    {
        public languages()
        {
            InitializeComponent();
        }
        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[language]
([language_type])  VALUES('" + textBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }

        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from language", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("language");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[language]
      WHERE (language_type= '" + textBox.Text + "' )", con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }


    }
}
