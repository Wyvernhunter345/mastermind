using System;
using System.Windows;
using System.Windows.Media;
namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* "According to all known laws of aviaton, there is no way that a bee should be able to fly. 
        It's wings are too small to get its fat little body off the ground. 
        The bee, of course, flies anyways. Because bees don't care what humans think is impossible." */
        public static class HistoryColour
        {
            public static int guess1c;
            public static int guess2c;
            public static int guess3c;
            public static int guess4c;
            public static int guess21c;
            public static int guess22c;
            public static int guess23c;
            public static int guess24c;
            public static int guess31c;
            public static int guess32c;
            public static int guess33c;
            public static int guess34c;
            public static int guess41c;
            public static int guess42c;
            public static int guess43c;
            public static int guess44c;
        }
        public static class GuessHistory
        {
            public static int guess1inthistory;
            public static int guess2inthistory;
            public static int guess3inthistory;
            public static int guess4inthistory;
            public static int guess1inthistory2;
            public static int guess2inthistory2;
            public static int guess3inthistory2;
            public static int guess4inthistory2;
            public static int guess1inthistory3;
            public static int guess2inthistory3;
            public static int guess3inthistory3;
            public static int guess4inthistory3;
        }
        static Random thing = new Random();
        public static class numbersGenerated
        {
            public static int number1 = thing.Next(1, 10);
            public static int number2 = thing.Next(1, 10);
            public static int number3 = thing.Next(1, 10);
            public static int number4 = thing.Next(1, 10);
        }
        public static class otherGuessThing
        {
            public static int g = 0;
        }
        int guesses = 0;
        int guess1int;
        int guess2int;
        int guess3int;
        int guess4int;
        int points;
        public MainWindow()
        { 
            InitializeComponent();
            result1.Visibility = Visibility.Hidden;
            result2.Visibility = Visibility.Hidden;
            result3.Visibility = Visibility.Hidden;
            result4.Visibility = Visibility.Hidden;
            int diff = Window1.difficultyvariable.difficulty;
            if (diff == 1)
            {
                guesses = 10;
                points = 75;
                sickMovesBoi.Text = "Moves Remaining: " + guesses;
                PointBox.Text = "Points Remaining: " + points;
            }
            else if (diff == 2)
            {
                guesses = 6;
                points = 50;
                sickMovesBoi.Text = "Moves Remaining: " + guesses;
                PointBox.Text = "Points Remaining: " + points;
            }
            else if (diff == 3)
            {
                guesses = 4;
                points = 30;
                sickMovesBoi.Text = "Moves Remaining: " + guesses;
                PointBox.Text = "Points Remaining: " + points;
            }
        }
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            result1.Visibility = Visibility.Visible;
            result2.Visibility = Visibility.Visible;
            result3.Visibility = Visibility.Visible;
            result4.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Hidden;
            guesses = guesses - 1;
            otherGuessThing.g = otherGuessThing.g + 1;
            sickMovesBoi.Text = "Moves Remaining: " + guesses;
            
            Int32.TryParse(guess1.Text, out guess1int);
            Int32.TryParse(guess2.Text, out guess2int);
            Int32.TryParse(guess3.Text, out guess3int);
            Int32.TryParse(guess4.Text, out guess4int);
            if (guess1int == numbersGenerated.number1)
            {
                result1.Background = Brushes.Green;
                result1.Text = guess1int.ToString();
                HistoryColour.guess1c = 1;
            }
            else if (guess1int == numbersGenerated.number2 || guess1int == numbersGenerated.number3 || guess1int == numbersGenerated.number4)
            {
                result1.Background = Brushes.Orange;
                result1.Text = guess1int.ToString();
                HistoryColour.guess1c = 2;
                points = points - 2;
            }
            else
            {
                result1.Background = Brushes.Red;
                result1.Text = guess1int.ToString();
                HistoryColour.guess1c = 3;
                points = points - 5;
            }
            if (guess2int == numbersGenerated.number2)
            {
                result2.Background = Brushes.Green;
                result2.Text = guess2int.ToString();
                HistoryColour.guess2c = 1;
            }
            else if (guess2int == numbersGenerated.number1 || guess2int == numbersGenerated.number3 || guess2int == numbersGenerated.number4)
            {
                result2.Background = Brushes.Orange;
                result2.Text = guess2int.ToString();
                HistoryColour.guess2c = 2;
                points = points - 2;
            }
            else
            {
                result2.Background = Brushes.Red;
                result2.Text = guess2int.ToString();
                HistoryColour.guess2c = 3;
                points = points - 5;
            }
            if (guess3int == numbersGenerated.number3)
            {
                result3.Background = Brushes.Green;
                result3.Text = guess3int.ToString();
                HistoryColour.guess3c = 1;
            }
            else if (guess3int == numbersGenerated.number2 || guess3int == numbersGenerated.number1 || guess3int == numbersGenerated.number4)
            {
                result3.Background = Brushes.Orange;
                result3.Text = guess3int.ToString();
                HistoryColour.guess3c = 2;
                points = points - 2;
            }
            else
            {
                result3.Background = Brushes.Red;
                result3.Text = guess3int.ToString();
                HistoryColour.guess3c = 3;
                points = points - 5;
            }

            if (guess4int == numbersGenerated.number4)
            {
                result4.Background = Brushes.Green;
                result4.Text = guess4int.ToString();
                HistoryColour.guess4c = 1;
            }
            else if (guess4int == numbersGenerated.number2 || guess4int == numbersGenerated.number1 || guess4int == numbersGenerated.number3)
            {
                result4.Background = Brushes.Orange;
                result4.Text = guess4int.ToString();
                HistoryColour.guess4c = 2;
                points = points - 2;
            }
            else
            {
                result4.Background = Brushes.Red;
                result4.Text = guess4int.ToString();
                HistoryColour.guess4c = 3;
                points = points - 5;
            }
            if (guess1int == numbersGenerated.number1 && guess2int == numbersGenerated.number2 && 
                guess3int == numbersGenerated.number3 && guess4int == numbersGenerated.number4) //This sets the condition for the win scenario.
            {
                Win w = new Win();
                w.Show();
                Close();
            }
            else if (points < 0) //This sets first condition for lose scenario
            {
                GameOver go = new GameOver();
                go.Show();
                Close();
                points = 50;
            }
            else if (guesses == 0) //Second condition for lose
            {
                GameOver go = new GameOver();
                go.Show();
                Close();
            }
            //Configuring history
            HistoryColour.guess41c = HistoryColour.guess31c;
            HistoryColour.guess42c = HistoryColour.guess32c;
            HistoryColour.guess43c = HistoryColour.guess33c;
            HistoryColour.guess44c = HistoryColour.guess34c;
            GuessHistory.guess1inthistory3 = GuessHistory.guess1inthistory2;
            GuessHistory.guess2inthistory3 = GuessHistory.guess2inthistory2;
            GuessHistory.guess3inthistory3 = GuessHistory.guess3inthistory2;
            GuessHistory.guess4inthistory3 = GuessHistory.guess4inthistory2;
            HistoryColour.guess31c = HistoryColour.guess21c;
            HistoryColour.guess32c = HistoryColour.guess22c;
            HistoryColour.guess33c = HistoryColour.guess23c;
            HistoryColour.guess34c = HistoryColour.guess24c;
            GuessHistory.guess1inthistory2 = GuessHistory.guess1inthistory;
            GuessHistory.guess2inthistory2 = GuessHistory.guess2inthistory;
            GuessHistory.guess3inthistory2 = GuessHistory.guess3inthistory;
            GuessHistory.guess4inthistory2 = GuessHistory.guess4inthistory;
            HistoryColour.guess21c = HistoryColour.guess1c;
            HistoryColour.guess22c = HistoryColour.guess2c;
            HistoryColour.guess23c = HistoryColour.guess3c;
            HistoryColour.guess24c = HistoryColour.guess4c;
            GuessHistory.guess1inthistory = guess1int;
            GuessHistory.guess2inthistory = guess2int;
            GuessHistory.guess3inthistory = guess3int;
            GuessHistory.guess4inthistory = guess4int;
            guess1.Text = "";
            guess2.Text = "";
            guess3.Text = "";
            guess4.Text = "";
            PointBox.Text = "Points Remaining: " + points;
        }
        private void history_Click(object sender, RoutedEventArgs e)
        {
            History hist = new History();
            hist.Show();
        }
    }
}