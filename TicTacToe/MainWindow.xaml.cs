﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Input.Manipulations;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Properties
        public bool player1 = false;
        public int p1 = 0;
        public int p2 = 0;
        public bool gameOver = false;
        List<Button> buttons;
            
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            buttons = new List<Button>(){
                b1,b2,b3,b4,b5,b6,b7,b8,b9
            };
            foreach (var item in buttons)
            {
                item.IsEnabled = false;
            }
        }

        /// <summary>
        /// Returns the buttons to default 
        /// </summary>
        private void GameRestart()
        {
            b1.Content = b2.Content = b3.Content = b4.Content = b5.Content = b6.Content = b7.Content = b8.Content = b9.Content = null;
            b1.Background = b2.Background = b3.Background = b4.Background = b5.Background = b6.Background = b7.Background = b8.Background = b9.Background =Brushes.White;

            player1 = false;
            gameOver = false;
        }

        /// <summary>
        /// Button click changes the content of the squares between X and O
        /// </summary>
        /// <param name="sender">Object of the button click converted to a button object</param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //represents the button being pressed
            var b = sender as Button;
            //if the button has content within it we return so that the player cannot switch between a current value
            if (b.Content != null)
                return;
            else
            {
                player1 = !player1;
                //depending on whose turn it is the button value will contain an X or O
                b.Content = player1 == true ? "X" : "O";               
            }

            //for when someone wins or everyone loses
            GameOver();
        }

        private void GameOver()
        {
            #region Horizontal Buttons
            if (b1.Content == b2.Content && b2.Content == b3.Content && b1.Content != null && b2.Content != null && b3.Content != null)
            {
                b1.Background = b2.Background = b3.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();
                var result = player1 ? MessageBox.Show("Player 1 wins"): MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                    
                }
            }
            else if (b4.Content == b5.Content && b5.Content == b6.Content && b4.Content != null && b5.Content != null && b6.Content != null)
            {
                b4.Background = b5.Background = b6.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                    

                }
            }
            else if (b7.Content == b8.Content && b8.Content == b9.Content && b7.Content != null && b8.Content != null && b9.Content != null)
            {
                b7.Background = b8.Background = b9.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }

            }
            #endregion

            #region Vertical Buttons
            if (b1.Content == b4.Content && b4.Content == b7.Content && b1.Content != null && b4.Content != null && b7.Content != null)
            {
                b1.Background = b4.Background = b7.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }
            }
            else if (b2.Content == b5.Content && b5.Content == b8.Content && b2.Content != null && b5.Content != null && b8.Content != null)
            {
                b2.Background = b5.Background = b8.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }
            }
            else if (b3.Content == b6.Content && b6.Content == b9.Content && b3.Content != null && b6.Content != null && b9.Content != null)
            {
                b3.Background = b6.Background = b9.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }

            }
            #endregion

            #region Diagonal Buttons
            if (b1.Content == b5.Content && b5.Content == b9.Content && b1.Content != null && b5.Content != null && b9.Content != null)
            {
                b1.Background = b5.Background = b9.Background = Brushes.LightGreen;

                if (player1 == true)
                    p1++;
                else
                    p2++;

                p1Score.Text = p1.ToString();
                p2Score.Text = p2.ToString();

                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }
            }
            else if (b3.Content == b5.Content && b5.Content == b7.Content && b3.Content != null && b5.Content != null && b7.Content != null)
            {
                b3.Background = b5.Background = b7.Background = Brushes.LightGreen;
                var result = player1 ? MessageBox.Show("Player 1 wins") : MessageBox.Show("Player 2 wins");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }
            }
            #endregion

            #region All Buttons
            if (b1.Content != null && b2.Content != null & b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {
                b1.Background = b2.Background = b3.Background = b4.Background = b5.Background = b6.Background = b7.Background = b8.Background = b9.Background = Brushes.Red;

                var result = MessageBox.Show("Game Over");
                if (result == MessageBoxResult.OK)
                {
                    gameOver = true;
                    GameRestart();
                }
            }
            #endregion

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void NameEntry_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPlayer1Name.Text) && !string.IsNullOrWhiteSpace(txtPlayer2Name.Text))
            {
                txtP1Name.Text = $"{txtPlayer1Name.Text}:";
                txtP2Name.Text = $"{txtPlayer2Name.Text}:";
                borPlayerNames.Visibility = Visibility.Hidden;
                foreach (var item in buttons)
                {
                    item.IsEnabled = true;
                }
            }
        }
    }
}
