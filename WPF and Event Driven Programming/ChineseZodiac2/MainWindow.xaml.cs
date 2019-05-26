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

namespace ChineseZodiac2
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

        private void btnShowAnimal_Click(object sender, RoutedEventArgs e)
        {
            int year;
            string animal;

            if (int.TryParse(txtYearBorn.Text, out year) && year >= 1)
            {
                switch (year % 12)
                {
                    case 0: animal = "Monkey"; imgAnimalSymbol.Source=  new BitmapImage(new Uri("/Images/Monkey.gif",UriKind.Relative));break;
                    case 1: animal = "Rooster"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Rooster.gif", UriKind.Relative)); break;
                    case 2: animal = "Dog"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Dog.png", UriKind.Relative)); break;
                    case 3: animal = "Pig"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Pig.png", UriKind.Relative)); break;
                    case 4: animal = "Rat"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Rat.png", UriKind.Relative)); break;
                    case 5: animal = "Ox"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Ox.png", UriKind.Relative)); break;
                    case 6: animal = "Tiger"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Tiger.jpg", UriKind.Relative)); break;
                    case 7: animal = "Rabbit"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Rabbit.gif", UriKind.Relative)); break;
                    case 8: animal = "Dragon"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Dragon.jpg", UriKind.Relative)); break;
                    case 9: animal = "Snake"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Snake.png", UriKind.Relative)); break;
                    case 10: animal = "Horse"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Horse.jpg", UriKind.Relative)); break;
                    default: animal = "Sheep"; imgAnimalSymbol.Source = new BitmapImage(new Uri("/Images/Sheep.gif", UriKind.Relative)); break;
                }
                txtAnimalName.Content = animal;
            }
        }
    }
}
