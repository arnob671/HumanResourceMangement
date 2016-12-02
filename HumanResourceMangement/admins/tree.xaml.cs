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
    /// Interaction logic for tree.xaml
    /// </summary>
    public partial class tree : Page
    {
        public tree()
        {
            InitializeComponent();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/tree.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/user.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/job_titles.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/pay_grades.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/employment_status.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_4(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/job_categories.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_5(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/work_shifts.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_6(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/skills.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_7(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/education.xaml", UriKind.Relative));

        }

        private void TreeViewItem_PreviewMouseDown_8(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/license.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_9(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/languages.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_10(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/memberships.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_11(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/nationalities.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_12(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/general_information.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_13(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/locations.xaml", UriKind.Relative));
        }

        

        private void TreeViewItem_PreviewMouseDown_15(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/mail_config.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_16(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/subscription.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_17(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/localization.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_18(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/modules.xaml", UriKind.Relative));
        }

        private void TreeViewItem_PreviewMouseDown_14(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/structure.xaml", UriKind.Relative));
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
