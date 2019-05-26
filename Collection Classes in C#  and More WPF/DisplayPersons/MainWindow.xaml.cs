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
using System.Collections;

namespace DisplayPersons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

  
    public partial class MainWindow : Window
    {
        // List containing Person Objects
        private List<Person> col = null;
        public MainWindow()
        {
            InitializeComponent();
            col = new List<Person>();
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            int age=0;
            if(!String.IsNullOrEmpty(txtName.Text) && Int32.TryParse(txtAge.Text, out age))
            {
                // Obtain gender.
                char gender;
                if (radF.IsChecked.Value)
                {
                    gender = 'F';
                }
                else
                {
                    gender = 'M';
                }

                // Instantiate new person object with information from form.
                Person p = new Person(txtName.Text,
                    gender, age);

                // Add new Person object to collection.
                col.Add(p);

                // Add name of new Person object to combobox.
                cboPerson.Items.Add(p.Name);

                txtAge.Text = "";
                txtName.Text = "";
                radF.IsChecked = false;
                radM.IsChecked = false;
                cboPerson.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Couldn't add person.  Check values.");
            }
        }

        private void cboPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Find index of selected person in combo box.
            int i = cboPerson.SelectedIndex;

            if (i >= 0)
            {
                // Set reference to selected person in combo box.
                Person p = col[i];

                // Display person data on form.
                txtName.Text = p.Name;
                if (p.Gender == 'M')
                {
                    radM.IsChecked = true;
                }
                else
                {
                    radF.IsChecked = true;
                }
                txtAge.Text = p.Age.ToString();
            }
        }

        private void bthDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            // Find index of selected person in combo box.
            int i = cboPerson.SelectedIndex;

            if (i >= 0)
            {
                // Remove name of selected person from combo box.
                cboPerson.Items.RemoveAt(i);

                // Remove selected person from collection.
                col.RemoveAt(i);

                // Clear person data from form.
                txtName.Clear();
                txtAge.Text = "";
                radF.IsChecked = false;
                radM.IsChecked = false;

                // No name should be selected in combobox.
                cboPerson.SelectedIndex = -1;
            }
        }

        private void btnHaveBirthday_Click(object sender, RoutedEventArgs e)
        {
            // Find index of selected person in combo box.
            int i = cboPerson.SelectedIndex;

            // Exit method if no person is selected.
            if (i < 0)
            {
                return;
            }

            // Set reference to selected person in combo box.
            Person p = col[i];

            // Call HaveBirthday method.
            p.HaveBirthday();

            // Display new person data on form.
            txtName.Text = p.Name;
            if (p.Gender == 'M')
            {
                radM.IsChecked = true;
            }
            else
            {
                radF.IsChecked = true;
            }
            txtAge.Text = p.Age.ToString();
        }
    }
}
