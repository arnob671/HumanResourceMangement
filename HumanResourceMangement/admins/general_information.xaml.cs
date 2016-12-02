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
    /// Interaction logic for general_information.xaml
    /// </summary>
    public partial class general_information : Page
    {
        public general_information()
        {
            InitializeComponent();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void frame1_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[gene_info]
([name],[tax_id],[num_of_emp])
     VALUES('" + textBox4.Text + "','" + textBox8.Text + "','" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
          
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[gene_info]
      WHERE (name= '" + textBox4.Text + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value deleted");
            con.Close();
        }
    }
}
