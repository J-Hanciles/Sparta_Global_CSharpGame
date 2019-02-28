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

namespace WPFConnect4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PvPWindow : Window
    {
        int gridNum = 42;

        /*Button[,] grid = new Button[6, 7]
        {
            {, , , , , , },
            {, , , , , , },
            {, , , , , , },
            {, , , , , , },
            {, , , , , , },
            {, , , , , , }
        };*/

        ///Grid[2,2] = ;

        public PvPWindow()
        {
            InitializeComponent();

            int moveone = 1;//variables to use later when 
            int movetwo = 2;//the game starts for alternate turn if statements

            int player1 = moveone;//
            int player2 = movetwo;
           
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control ctrl in connect4Table.Children)
            {
                if (Background == Brushes.Red)
                {
                    
                }
            }



            for (int i = 0; i < 42; i++)//the amount of buttons in grid
            {




            }
        }

        private void R0C0_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)e.Source;

            if (gridNum % 2 == 0)
            {
                if ((bt.Background == Brushes.LightGray))
                {
                    bt.Background = Brushes.Black;//applied to all buttons
                    gridNum--;
                    checkWin(bt.Tag.ToString());
                }
                
            }
            else if (gridNum % 2 == 1)
            {
                if ((bt.Background == Brushes.LightGray))
                {
                    bt.Background = Brushes.Red;//applied to all buttons
                    gridNum--;
                    checkWin(bt.Tag.ToString());
                }
                
            }
            
            
        }
        /*private void checkWinner(string tag)
        {



        }*/
        /*public void CheckWin(Button bt)
        {
            //get the R and c of this button
            //use the array index to retrive all the possible moves of this array
            //in the top right bottom and left position

        }*/


        private void checkWin(string tag)
        {
            if (tag == "00")//Horizontal Wins
            {
                if(R0C0.Background.ToString() == R0C1.Background.ToString() && R0C1.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }                 
            }
            if (tag == "01")
            {
                if (R0C1.Background.ToString() == R0C0.Background.ToString() && R0C1.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "01")
            {
                if (R0C1.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "02")
            {
                if (R0C2.Background.ToString() == R0C1.Background.ToString() && R0C1.Background.ToString() == R0C0.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "02")
            {
                if (R0C2.Background.ToString() == R0C1.Background.ToString() && R0C2.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "02")
            {
                if (R0C2.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C1.Background.ToString() && R0C1.Background.ToString() == R0C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C1.Background.ToString() && R0C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R0C2.Background.ToString() && R0C3.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C5.Background.ToString() && R0C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "04")
            {
                if (R0C4.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C2.Background.ToString() && R0C2.Background.ToString() == R0C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "04")
            {
                if (R0C4.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C2.Background.ToString() && R0C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "04")
            {
                if (R0C4.Background.ToString() == R0C3.Background.ToString() && R0C4.Background.ToString() == R0C5.Background.ToString() && R0C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "05")
            {
                if (R0C5.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C3.Background.ToString() && R0C3.Background.ToString() == R0C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "05")
            {
                if (R0C5.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C3.Background.ToString() && R0C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "06")
            {
                if (R0C6.Background.ToString() == R0C5.Background.ToString() && R0C5.Background.ToString() == R0C4.Background.ToString() && R0C4.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "10")
            {
                if (R1C0.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R1C0.Background.ToString() && R1C1.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R1C0.Background.ToString() && R1C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R1C1.Background.ToString() && R1C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R1C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C1.Background.ToString() && R1C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R1C2.Background.ToString() && R1C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C2.Background.ToString() && R1C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R1C3.Background.ToString() && R1C4.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R1C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C3.Background.ToString() && R1C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "16")
            {
                if (R1C6.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "20")
            {
                if (R2C0.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R2C0.Background.ToString() && R2C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R2C0.Background.ToString() && R2C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R2C1.Background.ToString() && R2C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R2C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C1.Background.ToString() && R2C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R2C2.Background.ToString() && R2C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R2C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C2.Background.ToString() && R2C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R2C3.Background.ToString() && R2C4.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R2C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C3.Background.ToString() && R2C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "26")
            {
                if (R2C6.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "30")
            {
                if (R3C0.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R3C0.Background.ToString() && R3C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R3C0.Background.ToString() && R3C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R3C1.Background.ToString() && R3C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R3C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C1.Background.ToString() && R3C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R3C2.Background.ToString() && R3C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R3C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C2.Background.ToString() && R3C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R3C3.Background.ToString() && R3C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R3C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C3.Background.ToString() && R3C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "36")
            {
                if (R3C6.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "40")
            {
                if (R4C0.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C1.Background.ToString() == R4C0.Background.ToString() && R4C1.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C1.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R4C0.Background.ToString() && R4C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R4C1.Background.ToString() && R4C2.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R2C3.Background.ToString() && R4C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R4C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C1.Background.ToString() && R4C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R4C2.Background.ToString() && R4C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R4C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R4C2.Background.ToString() && R4C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R4C3.Background.ToString() && R4C4.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R4C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C3.Background.ToString() && R4C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "46")
            {
                if (R4C6.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "50")
            {
                if (R5C0.Background.ToString() == R5C1.Background.ToString() && R5C1.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "51")
            {
                if (R5C1.Background.ToString() == R5C0.Background.ToString() && R5C1.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "51")
            {
                if (R5C1.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "52")
            {
                if (R5C2.Background.ToString() == R5C1.Background.ToString() && R5C1.Background.ToString() == R5C0.Background.ToString() && R5C2.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "52")
            {
                if (R5C2.Background.ToString() == R5C1.Background.ToString() && R5C2.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "52")
            {
                if (R5C2.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C1.Background.ToString() && R5C1.Background.ToString() == R5C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C1.Background.ToString() && R5C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R5C2.Background.ToString() && R5C3.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C5.Background.ToString() && R5C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "54")
            {
                if (R5C4.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C2.Background.ToString() && R5C2.Background.ToString() == R5C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "54")
            {
                if (R5C4.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C2.Background.ToString() && R5C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "54")
            {
                if (R5C4.Background.ToString() == R5C3.Background.ToString() && R5C4.Background.ToString() == R5C5.Background.ToString() && R5C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "55")
            {
                if (R5C5.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C3.Background.ToString() && R5C3.Background.ToString() == R5C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "55")
            {
                if (R5C5.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C3.Background.ToString() && R5C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "56")
            {
                if (R5C6.Background.ToString() == R5C5.Background.ToString() && R5C5.Background.ToString() == R5C4.Background.ToString() && R5C4.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "00")//Vertical Wins
            {
                if (R0C0.Background.ToString() == R1C0.Background.ToString() && R1C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R3C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "10")
            {
                if (R1C0.Background.ToString() == R0C0.Background.ToString() && R1C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R3C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "10")
            {
                if (R1C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R4C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "20")
            {
                if (R2C0.Background.ToString() == R1C0.Background.ToString() && R1C0.Background.ToString() == R0C0.Background.ToString() && R2C0.Background.ToString() == R3C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "20")
            {
                if (R2C0.Background.ToString() == R1C0.Background.ToString() && R2C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R4C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "20")
            {
                if (R2C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R4C0.Background.ToString() && R4C0.Background.ToString() == R5C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "30")
            {
                if (R3C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R1C0.Background.ToString() && R1C0.Background.ToString() == R0C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "30")
            {
                if (R3C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R1C0.Background.ToString() && R3C0.Background.ToString() == R4C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "30")
            {
                if (R3C0.Background.ToString() == R2C0.Background.ToString() && R3C0.Background.ToString() == R4C0.Background.ToString() && R4C0.Background.ToString() == R5C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "40")
            {
                if (R4C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R2C0.Background.ToString() && R2C0.Background.ToString() == R1C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "40")
            {
                if (R4C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R2C0.Background.ToString() && R4C0.Background.ToString() == R5C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "50")
            {
                if (R5C0.Background.ToString() == R4C0.Background.ToString() && R4C0.Background.ToString() == R3C0.Background.ToString() && R3C0.Background.ToString() == R2C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "01")
            {
                if (R0C1.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R0C1.Background.ToString() && R1C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R0C1.Background.ToString() && R2C1.Background.ToString() == R3C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R1C1.Background.ToString() && R2C1.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R5C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R0C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C1.Background.ToString() && R3C1.Background.ToString() == R4C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R2C1.Background.ToString() && R3C1.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R5C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C0.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C1.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C1.Background.ToString() && R4C1.Background.ToString() == R5C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "51")
            {
                if (R5C1.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "02")
            {
                if (R0C2.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R0C2.Background.ToString() && R1C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R0C2.Background.ToString() && R2C2.Background.ToString() == R3C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R1C2.Background.ToString() && R2C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R5C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R0C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C2.Background.ToString() && R3C2.Background.ToString() == R4C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C2.Background.ToString() && R3C2.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R5C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C2.Background.ToString() && R4C2.Background.ToString() == R5C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "52")
            {
                if (R5C2.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R0C3.Background.ToString() && R1C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C3.Background.ToString() && R2C3.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R1C3.Background.ToString() && R2C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C3.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C3.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C3.Background.ToString() && R4C3.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "04")
            {
                if (R0C4.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R0C4.Background.ToString() && R1C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C4.Background.ToString() && R2C4.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R1C4.Background.ToString() && R2C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C4.Background.ToString() && R3C4.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C4.Background.ToString() && R3C4.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C4.Background.ToString() && R4C4.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "54")
            {
                if (R5C4.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "05")
            {
                if (R0C5.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R0C5.Background.ToString() && R1C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R0C5.Background.ToString() && R2C5.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R1C5.Background.ToString() && R2C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C5.Background.ToString() && R3C5.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R2C5.Background.ToString() && R3C5.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C5.Background.ToString() && R4C5.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "55")
            {
                if (R5C5.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "06")
            {
                if (R0C6.Background.ToString() == R1C6.Background.ToString() && R1C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "16")
            {
                if (R1C6.Background.ToString() == R0C6.Background.ToString() && R1C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "16")
            {
                if (R1C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "26")
            {
                if (R2C6.Background.ToString() == R1C6.Background.ToString() && R1C6.Background.ToString() == R0C6.Background.ToString() && R2C6.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "26")
            {
                if (R2C6.Background.ToString() == R1C6.Background.ToString() && R2C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "26")
            {
                if (R2C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R4C6.Background.ToString() && R4C6.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "36")
            {
                if (R3C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R1C6.Background.ToString() && R1C6.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "36")
            {
                if (R3C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R1C6.Background.ToString() && R3C6.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "36")
            {
                if (R3C6.Background.ToString() == R2C6.Background.ToString() && R3C6.Background.ToString() == R4C6.Background.ToString() && R4C6.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "46")
            {
                if (R4C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R2C6.Background.ToString() && R2C6.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "46")
            {
                if (R4C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R2C6.Background.ToString() && R4C6.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "56")
            {
                if (R5C6.Background.ToString() == R4C6.Background.ToString() && R4C6.Background.ToString() == R3C6.Background.ToString() && R3C6.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "00")//UpLeft+DownRight Diagonal wins
            {
                if (R0C0.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "01")
            {
                if (R0C1.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "02")
            {
                if (R0C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")
            {
                if (R0C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "10")
            {
                if (R1C0.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R0C0.Background.ToString() && R1C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "11")
            {
                if (R1C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R0C1.Background.ToString() && R1C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R0C2.Background.ToString() && R1C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R0C3.Background.ToString() && R1C1.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "20")
            {
                if (R2C0.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C2.Background.ToString() && R5C3.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R1C0.Background.ToString() && R2C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R0C0.Background.ToString() && R2C2.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R1C1.Background.ToString() && R2C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R1C0.Background.ToString() && R2C3.Background.ToString() == R3C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R1C2.Background.ToString() && R2C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C2.Background.ToString() && R2C4.Background.ToString() == R3C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R1C3.Background.ToString() && R2C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C3.Background.ToString() && R2C5.Background.ToString() == R3C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R2C0.Background.ToString() && R3C1.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C0.Background.ToString() && R3C2.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C1.Background.ToString() && R3C3.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C1.Background.ToString() && R1C1.Background.ToString() == R0C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C1.Background.ToString() && R3C3.Background.ToString() == R4C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C2.Background.ToString() && R3C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R0C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C2.Background.ToString() && R3C4.Background.ToString() == R4C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R2C3.Background.ToString() && R3C4.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R2C3.Background.ToString() && R3C4.Background.ToString() == R2C4.Background.ToString() && R3C5.Background.ToString() == R4C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "36")
            {
                if (R3C3.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C0.Background.ToString() && R4C2.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C1.Background.ToString() && R4C3.Background.ToString() == R5C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C2.Background.ToString() && R4C4.Background.ToString() == R5C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "45")
            {
                if (R4C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C3.Background.ToString() && R4C5.Background.ToString() == R5C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "46")
            {
                if (R4C6.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "54")
            {
                if (R5C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "55")
            {
                if (R5C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "56")
            {
                if (R5C6.Background.ToString() == R4C5.Background.ToString() && R4C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "03")//UpRight+DownLeft Diagonal Win
            {
                if (R0C3.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "04")
            {
                if (R0C4.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "05")
            {
                if (R0C5.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "06")
            {
                if (R0C6.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "12")
            {
                if (R1C2.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R3C0.Background.ToString() && R1C2.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "13")
            {
                if (R1C3.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R3C1.Background.ToString() && R1C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "14")
            {
                if (R1C4.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R3C2.Background.ToString() && R1C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "15")
            {
                if (R1C5.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R3C3.Background.ToString() && R1C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "16")
            {
                if (R1C6.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "21")
            {
                if (R2C1.Background.ToString() == R3C0.Background.ToString() && R2C1.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R4C0.Background.ToString() && R2C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "22")
            {
                if (R2C2.Background.ToString() == R3C1.Background.ToString() && R2C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R5C0.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R4C1.Background.ToString() && R2C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "23")
            {
                if (R2C3.Background.ToString() == R3C2.Background.ToString() && R2C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R5C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R4C2.Background.ToString() && R2C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "24")
            {
                if (R2C4.Background.ToString() == R3C3.Background.ToString() && R2C4.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C2.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "25")
            {
                if (R2C5.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R4C3.Background.ToString() && R2C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "26")
            {
                if (R2C6.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "30")
            {
                if (R3C0.Background.ToString() == R2C1.Background.ToString() && R2C1.Background.ToString() == R1C2.Background.ToString() && R1C2.Background.ToString() == R0C1.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R4C0.Background.ToString() && R3C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "31")
            {
                if (R3C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C3.Background.ToString() && R1C3.Background.ToString() == R0C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R5C0.Background.ToString() && R3C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R4C1.Background.ToString() && R3C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "32")
            {
                if (R3C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C4.Background.ToString() && R1C4.Background.ToString() == R0C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R5C1.Background.ToString() && R3C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R4C2.Background.ToString() && R3C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "33")
            {
                if (R3C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C5.Background.ToString() && R1C5.Background.ToString() == R0C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R5C2.Background.ToString() && R3C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "34")
            {
                if (R3C4.Background.ToString() == R4C3.Background.ToString() && R3C4.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "35")
            {
                if (R3C5.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R5C3.Background.ToString() && R3C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "40")
            {
                if (R4C0.Background.ToString() == R3C1.Background.ToString() && R3C1.Background.ToString() == R2C2.Background.ToString() && R2C2.Background.ToString() == R1C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C1.Background.ToString() == R5C0.Background.ToString() && R4C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "41")
            {
                if (R4C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C3.Background.ToString() && R2C3.Background.ToString() == R1C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R5C1.Background.ToString() && R4C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "42")
            {
                if (R4C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C4.Background.ToString() && R2C4.Background.ToString() == R1C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R5C2.Background.ToString() && R4C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "43")
            {
                if (R4C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C5.Background.ToString() && R2C5.Background.ToString() == R1C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "44")
            {
                if (R4C4.Background.ToString() == R5C3.Background.ToString() && R4C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "50")
            {
                if (R5C0.Background.ToString() == R4C1.Background.ToString() && R4C1.Background.ToString() == R3C2.Background.ToString() && R3C2.Background.ToString() == R2C3.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "51")
            {
                if (R5C1.Background.ToString() == R4C2.Background.ToString() && R4C2.Background.ToString() == R3C3.Background.ToString() && R3C3.Background.ToString() == R2C4.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "52")
            {
                if (R5C2.Background.ToString() == R4C3.Background.ToString() && R4C3.Background.ToString() == R3C4.Background.ToString() && R3C4.Background.ToString() == R2C5.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }
            if (tag == "53")
            {
                if (R5C3.Background.ToString() == R4C4.Background.ToString() && R4C4.Background.ToString() == R3C5.Background.ToString() && R3C5.Background.ToString() == R2C6.Background.ToString())
                {
                    MessageBox.Show("Winner");
                }
            }




        }

    }
        
}

