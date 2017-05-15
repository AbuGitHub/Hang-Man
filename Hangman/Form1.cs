using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Homework4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();                                                          
        int hangManAnswer;
        int counter = 0;
        string userInput;
        int userInputUsable;

        public Form1()
        {
            InitializeComponent();
            hangManAnswer = rnd.Next(1, 100);                                                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = textBox1.Text;
            int.TryParse(userInput, out userInputUsable);
            counter++;

            switch(counter)
            {
                case 1:
                    {
                        pictureBox1.Image = Properties.Resources.hangman01;
                        break;
                    }

                case 2:
                    {
                        pictureBox1.Image = Properties.Resources.hangman02;
                        break;
                    }

                case 3:
                    {
                        pictureBox1.Image = Properties.Resources.hangman05;
                        break;
                    }

                case 4:
                    {
                        pictureBox1.Image = Properties.Resources.hangman06;
                        break;
                    }

                case 5:
                    {
                        pictureBox1.Image = Properties.Resources.hangman07;
                        break;
                    }

                case 6:
                    {
                        pictureBox1.Image = Properties.Resources.dead;
                        break;
                    }
            }

            if (counter == 6 && userInputUsable != hangManAnswer)
            {
                label1.Text = "You've run out of tries!";
                groupBox1.Visible = true;
            }  
     
            else if (userInputUsable == hangManAnswer)
            {
                pictureBox1.Image = Properties.Resources.yay;
                label1.Text = "Great! You got it!";
                groupBox1.Visible = true;
            }

            else if (userInputUsable > hangManAnswer)
            {
            label1.Text = "The number is less than " + userInput;
            }

            else if (userInputUsable < hangManAnswer)
            {
            label1.Text = "The number is greater than " + userInput;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hangManAnswer = rnd.Next(1, 100);
            pictureBox1.Image = null;
            counter = 0;
            groupBox1.Visible = false;
            radioButton1.Checked = false;
            label1.Text = "Enter a number 1-100";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ("\tThe answer is: " + hangManAnswer);
        }
    }
}
