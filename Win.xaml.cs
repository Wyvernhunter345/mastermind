using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;


namespace Mastermind
{
    /// <summary>
    /// Interaction logic for Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        
        public Win()
        {
            InitializeComponent();
            _1.Text = MainWindow.numbersGenerated.number1.ToString();
            _2.Text = MainWindow.numbersGenerated.number2.ToString();
            _3.Text = MainWindow.numbersGenerated.number3.ToString();
            _4.Text = MainWindow.numbersGenerated.number4.ToString();
            Random r = new Random();
            int msg = r.Next(1, 10);
            if (msg == 1)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Not bad!";
            }
            else if (msg == 2)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Impressive.";
            }
            else if (msg == 3)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Now that's what I call a good meme.";
            }
            else if (msg == 4)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. That was a pretty good run.";
            }
            else if (msg == 5)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Do you even read this bit?";
            }
            else if (msg == 6)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. That would've been satisfying.";
            }
            else if (msg == 7)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Care to have another go?";
            }
            else if (msg == 8)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Is this innovative? I don't know, I'm just a box.";
            }
            else if (msg == 9)
            {
                Message.Text = "You won with " + MainWindow.otherGuessThing.g + " total guesses. Smart cookie! (Or are you?)";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"Mastermind.exe");
            Application.Current.Shutdown();
        }
        
    }
}
