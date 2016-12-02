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
    /// Interaction logic for currencyPage.xaml
    /// </summary>
    public partial class currencyPage : Page
    {
        public currencyPage()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[currency]
            ([currency_name],[min_sal],[max_sal],[grade_id])
             VALUES('" + textBox.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')", con);
            SqlCommand result = new SqlCommand(@"select currency_name from currency", con);
            result.ExecuteNonQuery();
            if (textBox.Text==result.CommandText)
            {
                MessageBox.Show("Currency name already exists ! ");
            }
            else {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert");
            }
            
            con.Close();
            show();
        }

        private void frame1_Navigated(object sender, NavigationEventArgs e)
        {
            show();
            shows();
        }

        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from currency", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("currency");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        
              
            
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
           
        }
        void shows()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from grade", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("grade");
            sdp.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
