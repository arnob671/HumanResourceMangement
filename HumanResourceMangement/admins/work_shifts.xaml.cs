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
    /// Interaction logic for work_shifts.xaml
    /// </summary>
    public partial class work_shifts : Page
    {
        public work_shifts()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string startTime = comboBox.Text;
            string endTime = comboBox1.Text;

            TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));

            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[shift]
([shift_name],[from],[to],[duration])
     VALUES('" + textBox.Text + "','" + comboBox.Text + "','" + comboBox1.Text + "','"+duration+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
            show();
        }
        void show()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from shift", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("shift");
            sdp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            sdp.Update(dt);
            con.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNOB;Initial Catalog=admin_module;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[shift]
      WHERE (shift_name= '" + textBox.Text + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Value deleted");
            con.Close();
            show();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            show();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
