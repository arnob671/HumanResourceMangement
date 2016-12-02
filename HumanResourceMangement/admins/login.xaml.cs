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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
       
         public login()
        {
            InitializeComponent();
        }
        

        private void button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Count(*)
  FROM logadmin where (username='" + textBox.Text + "'and password='" + textBox1.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.NavigationService.Navigate(new Uri("/tree.xaml", UriKind.Relative));


           }
            else
            {
                MessageBox.Show("Wrong user name or password");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new Uri("/tree.xaml", UriKind.Relative));

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
