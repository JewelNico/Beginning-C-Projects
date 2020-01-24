// Amber Perkins
// 000828993
// 10/29/2019
//10/30/2019
//This program is a distance calculator.
// it calculates  and list the speed of a vehicle per hour
// it it keeps a total of distance, hours traveled, total trips, and average distance.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_PerkinsA_Lab05
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Declare fields for GroupBox
        private int totalTrips = 0;
        private int totalHours = 0;
        private decimal totalDistance = 0.00m;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //declare variables
            decimal speed;
            int hours = 0;
            int number;
            int averageDistance = 0;
            int distance;
      

            // Get the speed
            if (decimal.TryParse(vehicleSpeedTextBox.Text, out speed)) // decimal data conversion
            {

                if (speed > 0 && speed <= 180) // speed valid input
                {

                    if (int.TryParse(hoursTraveledTextBox.Text, out hours)) // interger data conversion
                    {

                        if (hours >= 0 && hours <= 50) // hours valid input
                        {


                            for (number = 1; number <= hours; number++) // loop counter
                            {
    
                                distanceListBox.Items.Add("After Hour " + number + " the distance is " + (number * speed));
                           
                            }
                        }
                        else
                        {
                            // Hours not within 1 - 50 range
                            MessageBox.Show("Hours traveled must be between 1 - 50.");
                            hoursTraveledTextBox.Clear();
                            hoursTraveledTextBox.Focus();
                        }
                    }
                    else
                    {
                        // Invalid hour data type
                        MessageBox.Show("Hours must be a whole number");
                        hoursTraveledTextBox.Clear();
                        hoursTraveledTextBox.Focus();
                    }
                }
                else
                {
                    // Speed not within 1 - 180 range 
                    MessageBox.Show("Speed must be between 1 - 180.");
                    vehicleSpeedTextBox.Clear();
                    vehicleSpeedTextBox.Focus();
                }

            }
            else
            {
                // Invalid speed data type
                MessageBox.Show("Speed must be a number.");
                vehicleSpeedTextBox.Clear();
                vehicleSpeedTextBox.Focus();
            }

            // Calculate distance
            distance = (int)speed * hours;

            // Accumulate Total Hours
            totalHours = hours + totalHours;

            // Accumulate  Total Trips
            totalTrips = totalTrips + 1;

            // Accumulate Total Distance
            totalDistance = hours * speed + totalDistance;

            // Calculate Average Distance
            averageDistance = (int)totalDistance / totalTrips;

            // Display Output Total Hours
            totalHoursTraveledOutputLabel.Text = totalHours.ToString();

            // Display Output Total Trips
            totalTripsOutputLabel.Text = totalTrips.ToString();

            //Display Output Total Distance
            totalDistanceOutputLabel.Text = totalDistance.ToString("n2");

            // Display Average Distance
            averageDistanceOutputLabel.Text = averageDistance.ToString("n2");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear Text Box
            vehicleSpeedTextBox.Clear();
            hoursTraveledTextBox.Clear();

            // Clear Average Distance

            averageDistanceOutputLabel.Text = "";

            // Clear List Box
            distanceListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



