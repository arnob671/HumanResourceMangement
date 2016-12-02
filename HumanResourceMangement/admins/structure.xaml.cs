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

namespace admins
{
    /// <summary>
    /// Interaction logic for structure.xaml
    /// </summary>
    public partial class structure : Page
    {
        public structure()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           /* TreeViewItem treeItem = null;
            treeItem = new TreeViewItem();
            treeItem.Header = "North America";

            treeItem.Items.Add(new TreeViewItem() { Header = "USA" });
            treeItem.Items.Add(new TreeViewItem() { Header = "Canada" });
            treeItem.Items.Add(new TreeViewItem() { Header = "Mexico" });

            tvMain.Items.Add(treeItem);*/
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //TreeViewItem item = new TreeViewItem();
            //item.Header = textBox.Text;
          
         //   treeView.Items.Add(textBox.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           // treeView.Items.Add();
        }
    }
}
