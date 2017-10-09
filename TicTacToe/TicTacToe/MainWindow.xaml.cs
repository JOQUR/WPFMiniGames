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

namespace TicTacToe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool player1 = true;
        public bool player2 = false;

       

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void x1_Click(object sender, RoutedEventArgs e)
        {

            if (player1 == true && player2 == false) 
            {

                x1.Background = Brushes.DeepPink;
                x1.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x1.Background = Brushes.Aqua;
                x1.Content = "O";
                player1 = true;
                player2 = false;
            }
            x1.IsEnabled = false;
            winner();
        }

        private void x2_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x2.Background = Brushes.DeepPink;
                x2.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x2.Background = Brushes.Aqua;
                x2.Content = "O";
                player1 = true;
                player2 = false;
            }
            x2.IsEnabled = false;
            winner();

        }

        private void x3_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x3.Background = Brushes.DeepPink;
                x3.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x3.Background = Brushes.Aqua;
                x3.Content = "O";
                player1 = true;
                player2 = false;
            }
            x3.IsEnabled = false;
            winner();

        }

        private void x4_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x4.Background = Brushes.DeepPink;
                x4.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x4.Background = Brushes.Aqua;
                x4.Content = "O";
                player1 = true;
                player2 = false;
            }
            x4.IsEnabled = false;
            winner();

        }

        private void x5_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x5.Background = Brushes.DeepPink;
                x5.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x5.Background = Brushes.Aqua;
                x5.Content = "O";
                player1 = true;
                player2 = false;
            }
            x5.IsEnabled = false;
            winner();
        }

        private void x6_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x6.Background = Brushes.DeepPink;
                x6.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x6.Background = Brushes.Aqua;
                x6.Content = "O";
                player1 = true;
                player2 = false;
            }
            x6.IsEnabled = false;
            winner();
        }

        private void x7_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x7.Background = Brushes.DeepPink;
                x7.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x7.Background = Brushes.Aqua;
                x7.Content = "O";
                player1 = true;
                player2 = false;
            }
            x7.IsEnabled = false;
            winner();
        }

        private void x8_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x8.Background = Brushes.DeepPink;
                x8.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x8.Background = Brushes.Aqua;
                x8.Content = "O";
                player1 = true;
                player2 = false;
            }
            x8.IsEnabled = false;
            winner();
        }

        private void x9_Click(object sender, RoutedEventArgs e)
        {
            if (player1 == true && player2 == false)
            {

                x9.Background = Brushes.DeepPink;
                x9.Content = "X";

                player1 = false;
                player2 = true;
            }
            else
            {
                x9.Background = Brushes.Aqua;
                x9.Content = "O";
                player1 = true;
                player2 = false;
            }
            x9.IsEnabled = false;
            winner();
        }

        public void winner()
        {
            #region player1
            if(x1.Content == "X" && x5.Content == "X" && x9.Content == "X" )
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x1.Content == "X" && x2.Content == "X" && x3.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x4.Content == "X" && x5.Content == "X" && x6.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x7.Content == "X" && x8.Content == "X" && x9.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x1.Content == "X" && x4.Content == "X" && x7.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x2.Content == "X" && x5.Content == "X" && x8.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x3.Content == "X" && x6.Content == "X" && x9.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
            if (x3.Content == "X" && x5.Content == "X" && x7.Content == "X")
            {
                this.Hide();
                MessageBox.Show("The winner is Player1");
            }
#endregion


            #region player2

            if (x1.Content == "O" && x5.Content == "O" && x9.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x1.Content == "O" && x2.Content == "O" && x3.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x4.Content == "O" && x5.Content == "O" && x6.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x7.Content == "O" && x8.Content == "O" && x9.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x1.Content == "O" && x4.Content == "O" && x7.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x2.Content == "O" && x5.Content == "O" && x8.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x3.Content == "O" && x6.Content == "O" && x9.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            if (x3.Content == "O" && x5.Content == "O" && x7.Content == "O")
            {
                this.Hide();
                MessageBox.Show("The winner is Player2");
            }
            #endregion
        }
    }
}
