using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace summative_choice_game
{
    public partial class Form1 : Form
    {
        int killerPosition = 0;
        int scene = 0;
        int num;
        Random rGen = new Random();

        public Form1()
        {
           
            InitializeComponent();

            pos1.Visible = true;
            pos2.Visible = false;
            pos3.Visible = false;
            pos4.Visible = false;
            pos5.Visible = false;
            pos6.Visible = false;
            pos7.Visible = false;
            pos8.Visible = false;
            pos9.Visible = false;
            pos10.Visible = false;

            if (killerPosition == 1)
            {

                pos1.Visible = false;
                pos2.Visible = true;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 2)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = true;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 3)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = true;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 4)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = true;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }


            if (killerPosition == 5)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = true;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 6)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = true;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 7)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = true;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 8)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = true;
                pos9.Visible = false;
                pos10.Visible = false;
            }

            if (killerPosition == 9)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = true;
                pos10.Visible = false;
            }
            if (killerPosition == 10)
            {

                pos1.Visible = false;
                pos2.Visible = false;
                pos3.Visible = false;
                pos4.Visible = false;
                pos5.Visible = false;
                pos6.Visible = false;
                pos7.Visible = false;
                pos8.Visible = false;
                pos9.Visible = false;
                pos10.Visible = true;
            }

            promptLabel.Visible = true;
            ifLbl.Visible = true;
            chooseLabel.Visible = true;
        }
        private void GreenButton_Click(object sender, EventArgs e)
        {
            if (killerPosition == 12) { scene = 99; }

            promptLabel.Visible = false;
            ifLbl.Visible = false;
            chooseLabel.Visible = false;

            if (scene == 0) { scene = 1; }
            else if (scene == 1) { scene = 3; }
            else if (scene == 3) { scene = 2; }
            else if (scene == 2) { scene = 4; }
            else if (scene == 4) { scene = 12; }
            else if (scene == 12) { scene = 10; }
            else if (scene == 10) { scene = 22; }
            else if (scene == 8) { scene = 10; }
            else if (scene == 6)
            {
                num = rGen.Next(1, 101);
                if (num >= 70)
                { scene = 7; }
                else { scene = 9; }
            }
            else if (scene == 7) { scene = 13; }
            else if (scene == 11) { scene = 14; }
            else if (scene == 14) { scene = 16; }
            else if (scene == 5) { scene = 6; }


            //if (scene == 99 )
            //{
            //    sceneLabel.Text = "Game Over!";
            //    Thread.Sleep(2000);
            //    sceneLabel.Text = "Play again? (Green door for yes | Blue door for no)";
            //}
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            promptLabel.Visible = false;
            ifLbl.Visible = false;
            chooseLabel.Visible = false;

            if (scene == 0) { scene = 2; }
            else if (scene == 2) { scene = 6; }
            else if (scene == 6) { scene = 19; }
            else if (scene == 19) { scene = 13; }
            else if (scene == 7) { scene = 15; }
            else if (scene == 11) { scene = 17; }
            else if (scene == 14) { scene = 15; }
            else if (scene == 3) { scene = 6; }
            else if (scene == 1) { scene = 2; }
            else if (scene == 12) { scene = 22; }
            else if (scene == 10) { scene = 22; }
            else if (scene == 4) { scene = 6; }
            else if (scene == 8) { scene = 10; }
            else if (scene == 5) { scene = 6; }

            ScenceOutput();
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            promptLabel.Visible = false;
            ifLbl.Visible = false;
            chooseLabel.Visible = false;

            if (scene == 0) { scene = 3; }
            else if (scene == 3) { scene = 5; }
            else if (scene == 5) { scene = 6; }
            else if (scene == 6) { scene = 20; }
            else if (scene == 2) { scene = 5; }
            else if (scene == 1) { scene = 2; }
            else if (scene == 4) { scene = 8; }
            else if (scene == 8) { scene = 12; }
            else if (scene == 12) { scene = 22; }
            else if (scene == 10) { scene = 23; }
            else if (scene == 7) { scene = 11; }
            else if (scene == 11) { scene = 17; }
            else if (scene == 14) { scene = 18; }
            else if (scene == 19) { scene = 15; }

            ScenceOutput();
        }

        private void ScenceOutput()
        {
            
        }
      
    }
}
