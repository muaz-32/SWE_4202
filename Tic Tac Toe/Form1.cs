using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                used.Add(false);
            }
            for (int i = 0; i < 9; i++)
            {
                markers.Add(".");
            }
        }
        int scoreUser = 0;
        int scoreComputer = 0;
        List<bool> used = new List<bool>();
        List<string> markers = new List<string>();
        Random random = new Random();
        string userMarker;
        string computerMarker;
        bool end = false;
        public bool computerWinChecker()
        {
            if (markers[0] == computerMarker && markers[1] == computerMarker && markers[2] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if(markers[3] == computerMarker && markers[4] == computerMarker && markers[5] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[6] == computerMarker && markers[7] == computerMarker && markers[8] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[0] == computerMarker && markers[3] == computerMarker && markers[6] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[1] == computerMarker && markers[4] == computerMarker && markers[7] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[2] == computerMarker && markers[5] == computerMarker && markers[8] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[0] == computerMarker && markers[4] == computerMarker && markers[8] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[6] == computerMarker && markers[4] == computerMarker && markers[2] == computerMarker)
            {
                MessageBox.Show("computer win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool userWinChecker()
        {
            if (markers[0] == userMarker && markers[1] == userMarker && markers[2] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[3] == userMarker && markers[4] == userMarker && markers[5] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[6] == userMarker && markers[7] == userMarker && markers[8] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[0] == userMarker && markers[3] == userMarker && markers[6] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[1] == userMarker && markers[4] == userMarker && markers[7] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[2] == userMarker && markers[5] == userMarker && markers[8] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[0] == userMarker && markers[4] == userMarker && markers[8] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else if (markers[6] == userMarker && markers[4] == userMarker && markers[2] == userMarker)
            {
                MessageBox.Show("user win");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool endOfGame()
        {
            int x = 0;
            for(int i = 0; i < 9; i++)
            {
                if(used[i] == true)
                {
                    x++;
                }
            }
            if(x == 9)
            {
                MessageBox.Show("draw");
                for (int i = 0; i < 9; i++)
                {
                    used[i] = false;
                }
                for (int i = 0; i < 9; i++)
                {
                    markers[i] = ".";
                }
                button_1.Text = " ";
                button_2.Text = " ";
                button_3.Text = " ";
                button_4.Text = " ";
                button_5.Text = " ";
                button_6.Text = " ";
                button_7.Text = " ";
                button_8.Text = " ";
                button_9.Text = " ";
                return true;
            }
            else
            {
                return false;
            }
        }
        public void buttonSelector(int i)
        {
            if(i == 0)
            {
                button_1.Text = computerMarker;
            }
            else if(i == 1)
            {
                button_2.Text = computerMarker;
            }
            else if (i == 2)
            {
                button_3.Text = computerMarker;
            }
            else if (i == 3)
            {
                button_4.Text = computerMarker;
            }
            else if (i == 4)
            {
                button_5.Text = computerMarker;
            }
            else if (i == 5)
            {
                button_6.Text = computerMarker;
            }
            else if (i == 6)
            {
                button_7.Text = computerMarker;
            }
            else if (i == 7)
            {
                button_8.Text = computerMarker;
            }
            else if (i == 8)
            {
                button_9.Text = computerMarker;
            }
            else
            {

            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if(used[0] == false)
            {
                markers[0] = userMarker;
                button_1.Text = userMarker;
                used[0] = true;
            }
            if(userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                


            }
            else if(endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (used[1] == false)
            {
                markers[1] = userMarker;
                button_2.Text = userMarker;
                used[1] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (used[2] == false)
            {
                markers[2] = userMarker;
                button_3.Text = userMarker;
                used[2] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (used[3] == false)
            {
                markers[3] = userMarker;
                button_4.Text = userMarker;
                used[3] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }    
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (used[4] == false)
            {
                markers[4] = userMarker;
                button_5.Text = userMarker;
                used[4] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (used[5] == false)
            {
                markers[5] = userMarker;
                button_6.Text = userMarker;
                used[5] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (used[6] == false)
            {
                markers[6] = userMarker;
                button_7.Text = userMarker;
                used[6] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (used[7] == false)
            {
                markers[7] = userMarker;
                button_8.Text = userMarker;
                used[7] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (used[8] == false)
            {
                markers[8] = userMarker;
                button_9.Text = userMarker;
                used[8] = true;
            }
            if (userWinChecker())
            {
                
                scoreUser++;
                textBox_player.Text = Convert.ToString(scoreUser);
                
            }
            else if (endOfGame())
            {
                
                
            }
            else
            {
                while (true)
                {
                    int dummy = random.Next() % 9;

                    if (used[dummy] == false)
                    {
                        markers[dummy] = computerMarker;
                        buttonSelector(dummy);
                        used[dummy] = true;
                        break;
                    }
                }
            }
            
            if (computerWinChecker())
            {
                
                scoreComputer++;
                textBox_computer.Text = Convert.ToString(scoreComputer);
                
            }
            else if (endOfGame())
            {
                
                
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if(textBox_beginning_marker.Text == "0")
            {
                userMarker = "0";
                computerMarker = "X";
            }
            else if(textBox_beginning_marker.Text == "X")
            {
                userMarker = "X";
                computerMarker = "0";
            }
            else
            {

            }
        }

        private void button_player_move_first_Click(object sender, EventArgs e)
        {

        }

        private void button_computer_move_first_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int dummy = random.Next() % 9;

                if (used[dummy] == false)
                {
                    markers[dummy] = computerMarker;
                    buttonSelector(dummy);
                    used[dummy] = true;
                    break;
                }
            }
            
        }
    }
}
