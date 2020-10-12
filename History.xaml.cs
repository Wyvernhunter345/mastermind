using System.Windows;
using System.Windows.Media;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Window
    {
        int guess21 = MainWindow.GuessHistory.guess1inthistory2;
        int guess22 = MainWindow.GuessHistory.guess2inthistory2;
        int guess23 = MainWindow.GuessHistory.guess3inthistory2;
        int guess24 = MainWindow.GuessHistory.guess4inthistory2;
        int guess31 = MainWindow.GuessHistory.guess1inthistory3;
        int guess32 = MainWindow.GuessHistory.guess2inthistory3;
        int guess33 = MainWindow.GuessHistory.guess3inthistory3;
        int guess34 = MainWindow.GuessHistory.guess4inthistory3;
        int g31c = MainWindow.HistoryColour.guess31c;
        int g32c = MainWindow.HistoryColour.guess32c;
        int g33c = MainWindow.HistoryColour.guess33c;
        int g34c = MainWindow.HistoryColour.guess34c;
        int g41c = MainWindow.HistoryColour.guess41c;
        int g42c = MainWindow.HistoryColour.guess42c;
        int g43c = MainWindow.HistoryColour.guess43c;
        int g44c = MainWindow.HistoryColour.guess44c;
        public History()
        {
            InitializeComponent();
            if (guess21 == 0 && guess22 == 0 && guess23 == 0 && guess24 == 0)
            {
                _2num1.Text = "";
                _2num2.Text = "";
                _2num3.Text = "";
                _2num4.Text = "";
                _2num1.Background = Brushes.White;
                _2num2.Background = Brushes.White;
                _2num3.Background = Brushes.White;
                _2num4.Background = Brushes.White;
            }
            else
            {
                _2num1.Text = guess21.ToString();
                _2num2.Text = guess22.ToString();
                _2num3.Text = guess23.ToString();
                _2num4.Text = guess24.ToString();
            }
            if (guess31 == 0 && guess32 == 0 && guess33 == 0 && guess34 == 0)
            {
                _3num1.Text = "";
                _3num2.Text = "";
                _3num3.Text = "";
                _3num4.Text = "";
                _3num1.Background = Brushes.White;
                _3num2.Background = Brushes.White;
                _3num3.Background = Brushes.White;
                _3num4.Background = Brushes.White;
            }
            else
            {
                _3num1.Text = guess31.ToString();
                _3num2.Text = guess32.ToString();
                _3num3.Text = guess33.ToString();
                _3num4.Text = guess34.ToString();
            }
            if (g31c == 3)
            {
                _2num1.Background = Brushes.Red;
            }
            else if (g31c == 2)
            {
                _2num1.Background = Brushes.Orange;
            }
            else if (g31c == 1)
            {
                _2num1.Background = Brushes.Green;
            }
            if (g32c == 3)
            {
                _2num2.Background = Brushes.Red;
            }
            else if (g32c == 2)
            {
                _2num2.Background = Brushes.Orange;
            }
            else if (g32c == 1)
            {
                _2num2.Background = Brushes.Green;
            }
            if (g33c == 3)
            {
                _2num3.Background = Brushes.Red;
            }
            else if (g33c == 2)
            {
                _2num3.Background = Brushes.Orange;
            }
            else if (g33c == 1)
            {
                _2num3.Background = Brushes.Green;
            }
            if (g34c == 3)
            {
                _2num4.Background = Brushes.Red;
            }
            else if (g34c == 2)
            {
                _2num4.Background = Brushes.Orange;
            }
            else if (g34c == 1)
            {
                _2num4.Background = Brushes.Green;
            }
            if (g41c == 3)
            {
                _3num1.Background = Brushes.Red;
            }
            else if (g41c == 2)
            {
                _3num1.Background = Brushes.Orange;
            }
            else if (g41c == 1)
            {
                _3num1.Background = Brushes.Green;
            }
            if (g42c == 3)
            {
                _3num2.Background = Brushes.Red;
            }
            else if (g42c == 2)
            {
                _3num2.Background = Brushes.Orange;
            }
            else if (g42c == 1)
            {
                _3num2.Background = Brushes.Green;
            }
            if (g43c == 3)
            {
                _3num3.Background = Brushes.Red;
            }
            else if (g43c == 2)
            {
                _3num3.Background = Brushes.Orange;
            }
            else if (g43c == 1)
            {
                _3num3.Background = Brushes.Green;
            }
            if (g44c == 3)
            {
                _3num4.Background = Brushes.Red;
            }
            else if (g44c == 2)
            {
                _3num4.Background = Brushes.Orange;
            }
            else if (g44c == 1)
            {
                _3num4.Background = Brushes.Green;
            }
        }

        
        private void game_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
