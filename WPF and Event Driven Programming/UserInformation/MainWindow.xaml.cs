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

namespace UserInformation
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            String message;
            if(IsValidated())
            {
                message = txtFirstName.Text + " " + txtLastName.Text;
                foreach (CheckBox chk in lstInterests.Items)
                {
                    if (chk.IsChecked.Value)
                    {
                        if(i==0)
                            { message = message + " is interested in " + chk.Content; }
                        else
                            { message = message +", " + chk.Content;}
                        i++;
                    }
                }

                foreach (RadioButton button in stkGender.Children)
                {
                    if (button.IsChecked.Value)
                    {
                        if (button.Content.ToString() == "Prefer not to say")
                            message = message + " and would prefer not to identify gender.";
                        else
                            message = message + " is " + button.Content +".";
                    }
                }

                message = message + " They are " + txtAge.Text + " years old.";

                MessageBox.Show(message,"Confirmation");
            }
        }

        private bool IsValidated()
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderBrush = new SolidColorBrush(Colors.Red);
                return false;
            }
            else
                txtFirstName.BorderBrush = new SolidColorBrush(Colors.Black);

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderBrush = new SolidColorBrush(Colors.Red);
                return false;
            }
            else
                txtLastName.BorderBrush = new SolidColorBrush(Colors.Black);
          

            int age;
            if (String.IsNullOrEmpty(txtAge.Text) || !Int32.TryParse(txtAge.Text, out age))
            {
                txtAge.BorderBrush = new SolidColorBrush(Colors.Red);
                return false;
            }
            else
                txtAge.BorderBrush = new SolidColorBrush(Colors.Black);
            return true;
        }
    }
}
