using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Windows.Forms;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createPlayer();
            createEnemy();


        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {

            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {

            }
            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {

            }
            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {

            }
            else if (Keyboard.IsKeyPressed(Key.Space))
            {

            }

        }

        private void createPlayer()
        {
            plaer
        }
        private void createEnemy()
        {

        }
    }
}
