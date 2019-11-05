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

// Escape Game - ISC3U
// By Jackson Rawes and Rowan Honeywell
// November 5th 2019

namespace summative_choice_game
{
    public partial class Form1 : Form
    {
        //Global Variable Declaration
        int killerPosition = 0;
        int scene = 0;
        int previousScene = 0;
        int num;
        Random rGen = new Random();

        //Sound Declaration
        SoundPlayer killerApproach = new SoundPlayer(Properties.Resources.killerApproach);
        SoundPlayer bomb = new SoundPlayer(Properties.Resources.Bomb);
        SoundPlayer snake = new SoundPlayer(Properties.Resources.Snake);
        SoundPlayer creepy1 = new SoundPlayer(Properties.Resources.Creepy1);
        SoundPlayer creepy2 = new SoundPlayer(Properties.Resources.Creepy2);
        SoundPlayer door1 = new SoundPlayer(Properties.Resources.Door1);
        SoundPlayer door2 = new SoundPlayer(Properties.Resources.Door2);
        SoundPlayer death = new SoundPlayer(Properties.Resources.Death2);
        SoundPlayer wolf = new SoundPlayer(Properties.Resources.Wolf);
        SoundPlayer escape = new SoundPlayer(Properties.Resources.Escape);

        public Form1()
        {

            InitializeComponent();

            //Primary killerPosition Declaration
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

            promptLabel.Visible = true;
            ifLbl.Visible = true;
        }


        private void SceneOutput()
        {

            //Scene Properties
            switch (scene)
            {
                case 0:
                    sceneLabel.Text = "You awake in a strange room. You hear distant foot " +
                        "steps, you must choose a door to go through.";
                    promptLabel.Text = "Press 'Space' for green door, 'M' for red door, and 'B' for blue door.";
                    iconDisplay.Image = Properties.Resources.vibeicon;
                    killerPosition = 0;
                    break;

                case 1:
                    sceneLabel.Text = "You entered though the green door. " +
                        "You get an eerie feeling you have made a terrible decision" +
                        " as the door slams behind you. You hear distant footsteps";
                    iconDisplay.Image = Properties.Resources.surprisedicon;
                    break;

                case 2:
                    sceneLabel.Text = "You entered though the door.You feel a wave of" +
                        " terror as you see another set of doors.Your gut tells you to advance through" +
                        " the Green door but, the blue door has a light behind it. Which door do you go through?";
                    iconDisplay.Image = Properties.Resources.lighticon;
                    break;

                case 3:
                    num = rGen.Next(1, 101);
                    if (num >= 50)
                    {
                        killerPosition = killerPosition + 3;
                        killerApproach.Play();
                        sceneLabel.Text = "You entered though the blue door. You get an eerie feeling you have made a terrible decision as the door slams behind you." +
                                             " You hear distant footsteps You entered though the door. You feel a wave of terror as you see another set of doors." +
                                             " Your gut tells you to advance through the Green door but, the blue door has a light behind it. Which door do you choose?";
                        iconDisplay.Image = Properties.Resources.lighticon;

                    }
                    else
                    {
                        killerPosition = killerPosition + 4;
                        killerApproach.Play();
                        sceneLabel.Text = "You entered though the blue door. You get an eerie feeling you have made a terrible decision as the door slams behind you." +
                                               " You hear footsteps pounding in the distance." +
                                               " You entered though the door. You feel a wave of terror as you see another set of doors.Your gut tells you to advance" +
                                               " through the Green door but, the blue door has a light behind it. Which door do you choose?";
                        iconDisplay.Image = Properties.Resources.lighticon;
                    }

                    break;

                case 4:
                    num = rGen.Next(1, 101);
                    if (num >= 75)
                    {
                        sceneLabel.Text = "You step on a rusty nail and you are now slower. Choose a new door.";
                        killerPosition = killerPosition + 2;
                        killerApproach.Play();
                        iconDisplay.Image = Properties.Resources.nailicon;
                    }
                    else
                    {
                        sceneLabel.Text = "To your surprise, nothing happens and you proceed to the next room";
                        killerPosition++;
                        killerApproach.Play();
                        iconDisplay.Image = Properties.Resources.surprisedicon;
                    }
                    break;

                case 5:
                    killerPosition = killerPosition + 5;
                    killerApproach.Play();
                    sceneLabel.Text = "As the door closes generally behind you you feel relaxed as you take in the overwhelming light. You all of a sudden" +
                                       " begin to feel weary and begin to drift off. You awake refreshed yet you feel as if something is not right...";
                    iconDisplay.Image = Properties.Resources.sleepicon;
                    door1.Play();
                    break;

                case 6:
                    sceneLabel.Text = "You burst through the door only to fall into a dank pit of " +
                        "sleeping snakes. There is a long bridge" +
                        " to the green door, a medium length path, with snakes" +
                        " to the red door, and a short, snakeless path to the blue door.";
                    iconDisplay.Image = Properties.Resources.snakeicon;
                    snake.Play();
                    break;

                case 7:
                    sceneLabel.Text = "You make it to the green door, the next room awaits you.";
                    door2.Play();
                    iconDisplay.Image = Properties.Resources.surprisedicon;
                    break;

                case 8:
                    killerPosition = killerPosition + 3;
                    killerApproach.Play();
                    door1.Play();
                    sceneLabel.Text = "New room, same design, Same fear." + " Which door do you choose?";
                    iconDisplay.Image = Properties.Resources.surprisedicon;
                    break;

                case 9:
                    sceneLabel.Text = "Through bad luck the bridge collapsed and you died" +
                                      ". Click the blue if you would like to play again. If you want to leave click the red button.";
                    creepy2.Play();
                    iconDisplay.Image = Properties.Resources.skullicon;
                    break;

                case 10:
                    sceneLabel.Text = "You See the Exit, above the red door, you are hesitant and wonder if you should choose a different door."
                        + " Do you: Run (blue door), go through the red door, or go through the blue door?";
                    killerPosition++;
                    killerApproach.Play();
                    door1.Play();
                    iconDisplay.Image = Properties.Resources.exiticon;
                    break;

                case 11:
                    sceneLabel.Text = "You see blood on the ground, in front of the green and blue doors. Which door do you choose";
                    killerPosition = killerPosition + 2;
                    killerApproach.Play();
                    creepy2.Play();
                    iconDisplay.Image = Properties.Resources.bloodicon;
                    break;

                case 12:
                    sceneLabel.Text = "What is 125 x 7?";
                    redButton.Text = "925";
                    blueButton.Text = "875";
                    greenButton.Text = "850";
                    iconDisplay.Image = Properties.Resources.mathicon;
                    break;

                case 13:
                    sceneLabel.Text = "You run into a ravenous pack of wolves and are mauled to death." +
                                      " Click the blue if you would like to play again. If you want to leave click the red button.";
                    iconDisplay.Image = Properties.Resources.wolficon;
                    wolf.Play();
                    break;

                case 14:
                    sceneLabel.Text = "You enter into the next room unscathed!" + " But now you must choose another door...";
                    killerPosition++;
                    door1.Play();
                    killerApproach.Play();
                    iconDisplay.Image = Properties.Resources.vibeicon;
                    break;

                case 15:
                    sceneLabel.Text = "You open the door to a peaceful forest and escape." +
                                      " Click the blue if you would like to play again. If you want to leave click the red button.";
                    escape.Play();
                    iconDisplay.Image = Properties.Resources.foresticon;
                    break;

                case 16:
                    sceneLabel.Text = "The door has been rigged with a grenade, you blow up!" +
                    " Click the blue if you would like to play again. If you want to leave click the red button.";
                    iconDisplay.Image = Properties.Resources.grenadeicon;
                    bomb.Play();
                    break;

                case 17:
                    sceneLabel.Text = "You open the door and get tied up by a bunch of wires, the killer caught you" +
                                      ". Click the blue if you would like to play again. If you want to leave click the red button.";
                    killerPosition = killerPosition + 10;
                    death.Play();
                    iconDisplay.Image = Properties.Resources.skullicon;
                    break;

                case 18:
                    sceneLabel.Text = "You open the door and you wake up in your room, it was all a dream." +
                                      " Click the blue if you would like to play again. If you want to leave click the red button.";
                    iconDisplay.Image = Properties.Resources.bedicon;
                    escape.Play();
                    break;

                case 19:
                    killerPosition = killerPosition + 3;
                    killerApproach.Play();
                    sceneLabel.Text = "You enter a new room, you are disappointed when it remains the same design, choose a door.";
                    iconDisplay.Image = Properties.Resources.vibeicon;
                    break;

                case 20:
                    sceneLabel.Text = "You wake the snakes up and they kill you." +
                    " Click the blue if you would like to play again. If you want to leave click the red button.";
                    iconDisplay.Image = Properties.Resources.skullicon;
                    death.Play();
                    break;

                case 22:
                    sceneLabel.Text = "The killer caught you. " +
                        " Click the blue if you would like to play again. If you want to leave click the red button.";
                    killerPosition = 10;
                    ifLbl.Text = "You're dead!";
                    iconDisplay.Image = Properties.Resources.vibeicon;
                    death.Play();
                    break;

                case 23:
                    sceneLabel.Text = "The exit sign was honest, you escaped." +
                                      " click the blue if you would like to play again. If you want to leave click the red button.";
                    iconDisplay.Image = Properties.Resources.smileicon;
                    break;

                case 24:
                    sceneLabel.Text = "You must answer this question correctly: 619 + 289";
                    redButton.Text = "908";
                    blueButton.Text = "918";
                    greenButton.Text = "928";
                    iconDisplay.Image = Properties.Resources.mathicon;
                    break;
                case 25:
                    sceneLabel.Text = "Thank you for playing!";
                    iconDisplay.Image = Properties.Resources.smileicon;
                    break;
                case 97:
                    sceneLabel.Text = "Do you want to quit?";
                    redButton.Text = "Yes";
                    blueButton.Text = "No";
                    break;
            }
            //killerPosition Properties With All Values
            if (killerPosition == 0)
            {
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
            }

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
            if (killerPosition >= 10)
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
                scene = 22;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //Scene and Plot Locations for Green Door
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 24; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 12; }
                else if (scene == 12)
                {
                    scene = 10;
                    killerPosition = killerPosition + 3;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                else if (scene == 10) { scene = 22; }
                else if (scene == 8) { scene = 10; killerPosition++; }
                else if (scene == 6)
                {
                    num = rGen.Next(1, 101);
                    if (num >= 70)
                    { scene = 7; }
                    else { scene = 9; }
                }
                else if (scene == 7) { scene = 13; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 19) { scene = 12; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 24)
                {
                    scene = 2;
                    killerPosition = killerPosition + 3;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                SceneOutput();
            }
            if (e.KeyCode == Keys.M)
            {
                //Scene and Plot Locations for Red Door
                if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 6; killerPosition++; }
                else if (scene == 6) { scene = 19; }
                else if (scene == 19) { scene = 13; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 11) { scene = 17; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 1) { scene = 24; }
                else if (scene == 24)
                {
                    scene = 2;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                else if (scene == 12) { scene = 22; }
                else if (scene == 10) { scene = 22; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 8) { scene = 10; killerPosition++; }
                else if (scene == 5) { scene = 6; }

                else if (scene == 9) { scene = 25; }
                else if (scene == 23) { scene = 25; }
                else if (scene == 22)
                {
                    scene = 25;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                else if (scene == 15) { scene = 25; }
                else if (scene == 16) { scene = 25; }
                else if (scene == 17) { scene = 25; }
                else if (scene == 18) { scene = 25; }
                else if (scene == 13) { scene = 25; }
                else if (scene == 20) { scene = 25; }
                else if (scene == 97) { this.Close(); }

                SceneOutput();
            }
            if (e.KeyCode == Keys.B)
            {
                //Scene and Plot Locations for Blue Door
                if (scene == 0) { scene = 3; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 20; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 1) { scene = 24; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 8) { scene = 12; }
                else if (scene == 12) { scene = 22; }
                else if (scene == 10) { scene = 23; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 17; }
                else if (scene == 14) { scene = 18; }
                else if (scene == 19) { scene = 15; }
                else if (scene == 24)
                {
                    scene = 2;
                    killerPosition = killerPosition + 3;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                else if (scene == 9) { scene = 0; }
                else if (scene == 23) { scene = 0; }
                else if (scene == 22)
                {
                    scene = 0;
                    redButton.Text = "";
                    blueButton.Text = "";
                    greenButton.Text = "";
                }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 97)
                {
                    scene = previousScene;
                    redButton.Text = "";
                    greenButton.Text = "";
                    blueButton.Text = "";
                }


                    SceneOutput();
            }
            //If Player Presses Escape - Option to Keep Playing or Quit
            if (e.KeyCode == Keys.Escape)
            {
                previousScene = scene;
                scene = 97;

                SceneOutput();
            }
        }
    }
}
