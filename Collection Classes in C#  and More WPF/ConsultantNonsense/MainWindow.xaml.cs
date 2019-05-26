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

namespace ConsultantNonsense
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

        private void btnGenerateNonsense_Click(object sender, RoutedEventArgs e)
        {
            string verb, adjective, noun, sentence;

            // Create a Random object with time dependent seed.
            Random r = new Random();

            // Choose random verb.
            switch (r.Next(1, 11))
            {
                case 1: verb = "architect"; break;
                case 2: verb = "e-enable"; break;
                case 3: verb = "facilitate"; break;
                case 4: verb = "harness"; break;
                case 5: verb = "incentivize"; break;
                case 6: verb = "leverage"; break;
                case 7: verb = "optimize"; break;
                case 8: verb = "synergize"; break;
                case 9: verb = "unleash"; break;
                default: verb = "whiteboard"; break;
            }

            // Choose random adjective.
            switch (r.Next(1, 11))
            {
                case 1: adjective = "24/7"; break;
                case 2: adjective = "collaborative"; break;
                case 3: adjective = "cutting-edge"; break;
                case 4: adjective = "dynamic"; break;
                case 5: adjective = "end-to-end"; break;
                case 6: adjective = "granular"; break;
                case 7: adjective = "intuitive"; break;
                case 8: adjective = "mission-critical"; break;
                case 9: adjective = "plug-and-play"; break;
                default: adjective = "seamless"; break;
            }

            // Choose random noun.
            switch (r.Next(1, 11))
            {
                case 1: noun = "action items"; break;
                case 2: noun = "applications"; break;
                case 3: noun = "bandwidth"; break;
                case 4: noun = "deliverables"; break;
                case 5: noun = "infrastructures"; break;
                case 6: noun = "markets"; break;
                case 7: noun = "products"; break;
                case 8: noun = "niches"; break;
                case 9: noun = "schemas"; break;
                default: noun = "synergies"; break;
            }

            // Compose final sentence.
            sentence = "Our consultants can help you " +
                verb + " " + adjective + " " + noun + ".";

            // Display final sentence.
            txtNonsense.Text = sentence;
        }
    }
}
