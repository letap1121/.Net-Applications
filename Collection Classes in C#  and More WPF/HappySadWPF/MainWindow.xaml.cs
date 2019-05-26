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

namespace HappySadWPF
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

        private void imgFace_MouseEnter(object sender, MouseEventArgs e)
        {
            imgFace.Source = new BitmapImage(new Uri("/Images/happy.jpg", UriKind.Relative));
        }

        private void imgFace_MouseLeave(object sender, MouseEventArgs e)
        {
            imgFace.Source = new BitmapImage(new Uri("/Images/sad.jpg", UriKind.Relative));
        }

        private void imgFace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("It worked!!");
        }

        private void imgFace_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right mouse button It worked!!");
        }
    }
}
