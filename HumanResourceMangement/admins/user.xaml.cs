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
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page
    {
         

        public user()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [user_name]
      ,[employee_name]
      ,[user_role]
      ,[user_status]
  FROM [dbo].[user_info] where (user_name='"+textBox.Text+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Search result...");
            con.Close();
            show();

        }
        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [user_name]
      ,[employee_name]
      ,[user_role]
      ,[user_status]
  FROM [dbo].[user_info] where (user_name='" + textBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("user_info");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            comboBox.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[user_info]
([user_name],[employee_name],[user_role],[user_status])
     VALUES('"+textBox.Text+"','"+textBox1.Text+"','"+comboBox.Text+"','"+comboBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
            display();

           

        }

        void display()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from user_info",con );
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("user_info");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
           
           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[user_info]
      WHERE (user_name= '" + textBox.Text + "' )",con );
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value deleted");
            con.Close();
            display();




        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            display();
        }
    }
}
