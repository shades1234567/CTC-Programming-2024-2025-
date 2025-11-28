using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Globalization;

namespace CH6EX10
{
    public partial class Form1 : Form
    {
        Random ranNumberGenerator = new Random();
        bool correct = false;
        bool correctletter = false;
        char guess;
        string[] names = { "Duck", "Tiger", "Cat", "Sheep", "Axolotl" };
        string guessword;
        char[] displayword;
        int randomNumber; public Form1()
        
        {
            InitializeComponent();
            GenerateWord();

        }      

        private void GenerateWord()
        {
            randomNumber = ranNumberGenerator.Next(0, 5);
            guessword = names[randomNumber];
            displayword = new char[guessword.Length];
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
           
            lblGame.Text = string.Empty;
            for (int i = 0; i < guessword.Length; ++i)
            {
                displayword[i] = '*';
            }
            if (!correct)
            {
                correctletter = false;
                lblGame.Text += ("Word: ");
                for (int i = 0; i < guessword.Length; ++i)
                {
                    lblGame.Text += Convert.ToString(displayword[i]);
                }
                guess = Convert.ToChar(txtGuess.Text);


                for (int i = 0; i < guessword.Length; ++i)
                {
                    if (guess == guessword[i])
                    {
                        displayword[i] = guess;
                        correctletter = true;
                    }
                }


                if (correctletter == true)
                {
                    lblCheck.Text = ("Yes! " + guess + " is in the word");
                }
                else
                {
                    if (correctletter == false)
                    {
                        lblCheck.Text = ("Sorry. " + guess + " is not in the word");
                    }
                }


                correct = true;
                for (int i = 0; i < guessword.Length; ++i)
                {
                    if (displayword[i] != guessword[i])
                    {
                        correct = false;
                    }
                }
                if (correct == true)
                {
                    lblCheck.Text = ("You Won!");
                }

            }
        }
    }
}
