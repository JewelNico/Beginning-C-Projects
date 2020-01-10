// Amber Perkins
// 000828993
// 09/17/2019
// 09/20/2019
// This program allows the user to toggle through five cards to reveal it's face value and name. 
// This program also allows the user to reset the program to it's original state and the ability to exit.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_PerkinsA_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void threeOfClubsPictureBox_Click(object sender, EventArgs e)
        {
            backFacePictureBox1.Visible = true;
            cardLabel.Text = "";
        }

        private void tenOfDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            backFacePictureBox2.Visible = true;
            cardLabel.Text = "";
        }

        private void sevenOfSpadesPictureBox_Click(object sender, EventArgs e)
        {
            backFacePictureBox3.Visible = true;
            cardLabel.Text = "";
        }

        private void queenOfHeartsPictureBox_Click(object sender, EventArgs e)
        {
            backFacePictureBox4.Visible = true;
            cardLabel.Text = "";
        }

        private void aceOfDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            backFacePictureBox5.Visible = true;
            cardLabel.Text = "";
        }

        private void backFace1_Click(object sender, EventArgs e)
        {
            threeOfClubsPictureBox.Visible = true;
            cardLabel.Text = "Three of Clubs";
            backFacePictureBox1.Visible = false;
            backFacePictureBox3.Visible = true;
            backFacePictureBox2.Visible = true;
            backFacePictureBox4.Visible = true;
            backFacePictureBox5.Visible = true;
        }

        private void backFace2_Click(object sender, EventArgs e)
        {
            tenOfDiamondsPictureBox.Visible = true;
            cardLabel.Text = "Ten of Diamonds";
            backFacePictureBox2.Visible = false;
            backFacePictureBox1.Visible = true;
            backFacePictureBox3.Visible = true;
            backFacePictureBox4.Visible = true;
            backFacePictureBox5.Visible = true;
        }

        private void backFace3_Click(object sender, EventArgs e)
        {
            sevenOfSpadesPictureBox.Visible = true;
            cardLabel.Text = "Seven of Spades";
            backFacePictureBox3.Visible = false;
            backFacePictureBox1.Visible = true;
            backFacePictureBox2.Visible = true;
            backFacePictureBox4.Visible = true;
            backFacePictureBox5.Visible = true;
        }

        private void backFace4_Click(object sender, EventArgs e)
        {
            queenOfHeartsPictureBox.Visible = true;
            cardLabel.Text = "Queen of Hearts";
            backFacePictureBox4.Visible = false;
            backFacePictureBox3.Visible = true;
            backFacePictureBox2.Visible = true;
            backFacePictureBox5.Visible = true;
            backFacePictureBox1.Visible = true; 

        }

        private void backFace5_Click(object sender, EventArgs e)
        {
            aceOfDiamondsPictureBox.Visible = true;
            cardLabel.Text = "Ace of Diamonds";
            backFacePictureBox5.Visible = false;
            backFacePictureBox3.Visible = true;
            backFacePictureBox4.Visible = true;
            backFacePictureBox2.Visible = true;
            backFacePictureBox1.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            backFacePictureBox1.Visible = true;
            backFacePictureBox2.Visible = true;
            backFacePictureBox3.Visible = true;
            backFacePictureBox4.Visible = true;
            backFacePictureBox5.Visible = true;
            cardLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}