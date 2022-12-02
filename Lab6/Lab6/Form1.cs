//Grading ID: C4517
//Lab 6
//Due Date: 10/28/2018
//CIS 199-75
//This lab determines the grade a student gets based on their word count.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {

            int userInput;//this is the variable for what the user enters.
            int[] wordCount = { 0, 16, 31, 51, 76 };//array of the number of words
            char[] grade = { 'F', 'D', 'C', 'B', 'A' };//array for the different letter grades
            bool found = false;//bool value
            char gradeRecieved = 'F';//base grade recieved
          
                int index = wordCount.Length - 1;//woed count length 

            if (int.TryParse(numOfWordsTxt.Text, out userInput))//tests if the value entered is a number
            {
                if (userInput >= 0)//this texts if the value of the user is greater than or equal to zero.

                {
                    //tests the index if it is greater than zero and not found.
                    while (index >= 0 && !found)
                    {
                        if (userInput >= wordCount[index])//if the user input is within the range it is true 
                            found = true;
                        else
                            --index;
                    }
                    //if the value entered is found it returns the grade the user recieved. 
                    if (found)
                        gradeRecieved = grade[index];
                    gradeLbl.Text = $"You got a {gradeRecieved}";

                }
                else
                    MessageBox.Show("Enter a positive number");//if the user enters a negative value it returns this. 
                numOfWordsTxt.Clear();//clears the users input
            }
            else
                MessageBox.Show("Enter a number");//diplays that the user needs to enter a number.
            numOfWordsTxt.Clear();//clears the text box
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            numOfWordsTxt.Clear();//clears the users input
            gradeLbl.Text = " ";//clears where the grade is given 
        }
    }
           
 }
           
 

    

    

