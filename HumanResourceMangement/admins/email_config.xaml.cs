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

namespace admins
{
    /// <summary>
    /// Interaction logic for email_config.xaml
    /// </summary>
    public partial class email_config : Page
    {
        SqlConnection con = new SqlConnection();
        public email_config()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            MessageBox.Show("Connect to database");
            con.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con.Open();
            MessageBox.Show("Connect to database");
            con.Close();

        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            con.Open();
            MessageBox.Show("Connect to database");
            con.Close();

        }
    }
}
