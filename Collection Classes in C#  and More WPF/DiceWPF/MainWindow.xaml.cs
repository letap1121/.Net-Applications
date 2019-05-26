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

namespace DiceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Use Dice object to obtain results of dice rolls.
        private Dice dice = new Dice();

        // Create an array of face to contain images.
        // Only the indices 1, 2, 3, 4, 5, 6 are used (not 0).
        BitmapImage[] face = new BitmapImage[7];

        public MainWindow()
        {
            
            InitializeComponent();

            for (int i = 1; i <= 6; i++)
            {
                face[i] = new BitmapImage(new Uri("Images/" + i.ToString() +".jpg", UriKind.Relative));
            }

            imgDie1.Source = face[1];
            imgDie2.Source = face[1];
        }

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            // Roll dice.
            dice.Roll();

            // Display values of dice in Image Control.
            imgDie1.Source = face[dice.Face1];
            imgDie2.Source = face[dice.Face2];
        }
    }
}
