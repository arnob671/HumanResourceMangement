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

namespace admins
{
    /// <summary>
    /// Interaction logic for job_titles.xaml
    /// </summary>
    public partial class job_titles : Page
    {
        public job_titles()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[job_titles]
([job_title],[job_description])
     VALUES('" + textBox.Text + "','" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
            show();

        }
        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from job_titles", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("job_titles");
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
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[job_titles]
      WHERE (job_title= '" + textBox.Text + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value deleted");
            con.Close();
            show();
        }
    }
}
