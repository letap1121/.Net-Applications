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

namespace StackVsQueueWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<string> localQueue;
        Stack<string> localStack;
        public MainWindow()
        {
            InitializeComponent();
            //Initialize both Collections
            localQueue = new Queue<string>();
            localStack = new Stack<string>();
        }

        private void btnAddToBoth_Click(object sender, RoutedEventArgs e)
        {
            //Add item to Stack
            localStack.Push(txtLetter.Text);
            //Ad item to Queue
            localQueue.Enqueue(txtLetter.Text);
            //Clear the TextBox
            txtLetter.Text = "";
            //Show the contents of the Collections in the Textbox
            RefreshListsView();
        }

        private void RefreshListsView()
        {
            //Grab the contents of the stack
            List<string> stack = localStack.ToList();
            //Grab the contents of the Queue
            List<string> queue = localQueue.ToList();
            //Clear the Textbox that shows the Stack and repopulate
            txtStackContents.Text = "";
            foreach (String s in stack)
            {
                txtStackContents.Text = txtStackContents.Text + s + " ";
            }

            //Clear the Textbox that shows the Queue and repopulate
            txtQueueContents.Text = "";
            foreach (String s in queue)
            {
                txtQueueContents.Text = txtQueueContents.Text + s + " ";
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Check if there is anything in the stack before trying to remove to avoid a crash.
            if (localStack.Count > 0)
            {
                //Remove from the stack
                localStack.Pop();
                //Remove from the Queue
                localQueue.Dequeue();
                RefreshListsView();
            }
            else
            {
                MessageBox.Show("Sorry, nothing to remove.", "Failed Operation");
            }
        }
    }
}
