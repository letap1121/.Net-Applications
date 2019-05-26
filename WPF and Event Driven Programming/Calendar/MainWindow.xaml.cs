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

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calDatePicker_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            txtDateSelected.Text = calDatePicker.SelectedDate.Value.ToShortDateString();
        }

        private void btnDateSet_Click(object sender, RoutedEventArgs e)
        {

            DateTime dt;
            if (DateTime.TryParse(txtDateSelected.Text, out dt))
            {
                calDatePicker.SelectedDate = dt;
                calDatePicker.DisplayDate = dt;
            }
        }

        
    }
}
