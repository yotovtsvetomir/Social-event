using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            theAnimal = null;
            theDog = null;
            theCat = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
           theAnimal = new Animal(textBoxChipRegNumb.Text, dateTimePickerBroughtIn.Value, textBoxName.Text);
        }



        /// <summary>
        /// Show the info of the animal referenced by the 'theAnimal' field, if it exists. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowInfoAnimal_Click(object sender, EventArgs e)
        {
            if (theAnimal != null)
            {
                textBoxChipRegNumb.Text = theAnimal.ChipRegistrationNumber;
                dateTimePickerBroughtIn.Value = theAnimal.DateOfBroughtIn;
                textBoxName.Text = theAnimal.Name;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            Dog theDog = new Dog(textBoxChipRegNumb.Text, dateTimePickerBroughtIn.Value, textBoxName.Text, dateTimePickerLastWalked.Value);
        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            Cat theCat = new Cat(textBoxChipRegNumb.Text, dateTimePickerBroughtIn.Value, textBoxName.Text, textBoxBadHabits.Text);
        }

        private void btnShowInfoDog_Click(object sender, EventArgs e)
        {
                        if (theDog!= null)
            {
                textBoxChipRegNumb.Text = theDog.ChipRegistrationNumber;
                dateTimePickerBroughtIn.Value = theDog.DateOfBroughtIn;
                textBoxName.Text = theDog.Name;
                dateTimePickerLastWalked.Value = theDog.LastWalkDate;
            }
        }
            
       

        private void btnShowInfoCat_Click(object sender, EventArgs e)
        {
            if (theCat != null)
            {
                textBoxChipRegNumb.Text = theCat.ChipRegistrationNumber;
                dateTimePickerBroughtIn.Value = theCat.DateOfBroughtIn;
                textBoxName.Text = theCat.Name;
                textBoxBadHabits.Text = theCat.BadHabits;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
