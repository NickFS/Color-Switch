using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorSwitch
{
    public partial class Form1 : Form
    {
        List<Color> colors; // create a list of colors for the game

        Random rnd = new Random(); // new instance of the random class called rnd

        Random blockPosition = new Random(); // new instance of the random class callsed block position

        int blockColor = 0; // integer that will determine the block of colors

        int i; // integer that will change the players of color

        int speed = 5; // speed of the blocks in the beginning of the game

        int score = 0; // the default game over Boolean


        public Form1()
        {
            InitializeComponent();
            resetGame(); //invoke the reset game function
        }

        private void playGame(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyPressEventArgs e)
        {
            // if the player presses the space key we do the following
            if (e.KeyChar == (char)Keys.Space)
            {
                i++; // increase the i integer by 1

                // if the i integer is greater than the total colours we have in the list
                if (i > colors.Count - 1)
                {
                    // reset i back to 0
                    i = 0;
                }

                player.BackColor = colors[i]; // apply the color to players background
            }

            // if the key capital R or lower case r is pressed then we do the following
            // if the game is also true only then the game will reset else it will not do anything

            if (e.KeyChar == (char)Keys.R) || e.KeyChar == char.ToLower((char)Keys.R) && gameOver)
                {
                // invoke the reset game function
                resetGame();
                gameOver = false; // now the game is reset we will set game to false
                }
        }

        public void resetGame()
        {
            // this is the reset game function
            block1.Top = -80; //set the block 1 to top of the screen at -80 pixels
            block2.Top = -300; // set the block 2 to top of the screen at -300 pixels
            // below is the list of colors we will add for the player and the blocks

            colors = new List<Color> {
                System.Drawing.Color.Red, System.Drawing.Color.Yellow, System.Drawing.Color.White, System.Drawing.Color.Purple
            };

            i = 0; //i is set ot 0 as default
            gameTimer.Start(); // start the game timer
            speed = 5; //set the default speed to 5 for the blocks
            score = 0; // default score is 0
        }
    }
}
