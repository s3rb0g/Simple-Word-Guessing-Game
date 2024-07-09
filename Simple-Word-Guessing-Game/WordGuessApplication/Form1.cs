using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private static String word = "computer";
        private StringBuilder wordToGuess = new StringBuilder(word);

    public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) 
        { 
            int lent = wordToGuess.Length;
            lent -= 1;

            for (int i = 1; i < lent; i++)
            {
                wordToGuess[i] = '?';
            }
            guessWord.Text = wordToGuess.ToString();

             
        }
        private void button1_Click(object sender, EventArgs e) 
        { 
            string guess = suggest.Text.ToString();

            if (guess.ToLower() == word) 
            {
                guessWord.Text = word;
                MessageBox.Show("Correct Guess!"); 
            }  
            else 
            { 
                ListBox.Items.Add(guess); 
                MessageBox.Show("Wrong Guess \nTry Again."); 
                suggest.Clear(); 
                 
            } 

        }
    }
}
