using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerValleyResto
{
    public partial class FormOne : System.Windows.Forms.Form
    {
        //init variables
        private string entree = "";
        private string drinkSelection = "";
        private string specialRequest = "";
        private bool water;
        private double entreePrice = 0;
        private double drinkPrice = 0;
        private double totalPrice = 0;
        //main driver
        public FormOne()
        {
            MessageBox.Show("Welcome admin");
            InitializeComponent();
        }
        //water check box
        private void checkBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWater.Checked)
            {
                water = true;
            }
            else 
            {
                water = false;
            }
        }
        //radio buttons
        private void radioButtonMilk_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonCoffee.Text;
            drinkPrice += 20;
        }

        private void radioButtonJuice_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonJuice.Text;
            drinkPrice += 10;
        }

        private void radioButtonSoda_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonSoda.Text;
            drinkPrice += 15;
        }

        private void radioButtonLemonade_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonLemonade.Text;
            drinkPrice += 15;
        }

        private void radioButtonTea_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonTea.Text;
            drinkPrice += 40;
        }

        private void radioButtonCoffee_CheckedChanged(object sender, EventArgs e)
        {
            drinkSelection = radioButtonCoffee.Text;
            drinkPrice += 30;
        }
        //File menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: Your data will not be saved");
            Close();
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (water == true)
            {
                MessageBox.Show("Entree Selected: "
                                + listBoxEntreeSelection.SelectedItem
                                + "\n"
                                + "Special Request: "
                                + specialRequest
                                + "\n" + "Drink Selection: "
                                + drinkSelection
                                + "\n with Water" + "\n\n\n");
            }
            else 
            {
                MessageBox.Show("Entree Selected: "
                                + listBoxEntreeSelection.SelectedItem
                                + "\n"
                                + "Special Request: "
                                + specialRequest
                                + "\n" + "Drink Selection: "
                                + drinkSelection
                                + "\n No water" + "\n\n\n");
            }
        }
        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonCoffee.Checked) 
            {
                radioButtonCoffee.Checked = false;
            }
            if (radioButtonTea.Checked) 
            {
                radioButtonTea.Checked = false;
            }
            if (radioButtonLemonade.Checked) 
            {
                radioButtonLemonade.Checked = false;
            }
            if (radioButtonSoda.Checked) 
            {
                radioButtonSoda.Checked = false;
            }
            if (radioButtonJuice.Checked) 
            {
                radioButtonJuice.Checked = false;
            }
            if (radioButtonMilk.Checked) 
            {
                radioButtonMilk.Checked = false;
            }
            
            comboBoxSpecialRequest.ResetText();
            listBoxEntreeSelection.ClearSelected();

            if (checkBoxWater.Checked) 
            {
                checkBoxWater.Checked = false;
            }

            drinkSelection = "";
            specialRequest = "";
            entreePrice = 0;
            drinkPrice = 0;
            totalPrice = 0;

            MessageBox.Show("--All items has been cleared--");
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalPrice = drinkPrice + entreePrice;

            if (water == true)
            {
                MessageBox.Show("Entree Selected: "
                                + listBoxEntreeSelection.SelectedItem
                                + "\n"
                                + "Special Request: "
                                + specialRequest
                                + "\n" + "Drink Selection: "
                                + drinkSelection
                                + "\n with Water" + "\n\n\n"
                                + "Total Price: ₱" + totalPrice.ToString());
            }
            else
            {
                MessageBox.Show("Entree Selected: "
                                + listBoxEntreeSelection.SelectedItem
                                + "\n"
                                + "Special Request: "
                                + specialRequest
                                + "\n" + "Drink Selection: "
                                + drinkSelection
                                + "\n No water" + "\n\n\n"
                                + "Total Price: ₱" + (drinkPrice + entreePrice).ToString());
            }

        }

        private void groupBoxDrinkSelection_Enter(object sender, EventArgs e)
        {

        }
        //combo box for special request
        private void comboBoxSpecialRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialRequest = comboBoxSpecialRequest.GetItemText(comboBoxSpecialRequest.SelectedItem);
            switch (specialRequest) 
            {
                case "Whole Wheat":
                    totalPrice += 10;
                    break;
                case "White Bread":
                    totalPrice += 15;
                    break;
                case "Rye Bread":
                    totalPrice += 20;
                    break;
                case "Hold the Dressing":
                    totalPrice += 10;
                    break;
                case "Hold the Onion":
                    totalPrice += 10;
                    break;
                case "Hold the Mayo":
                    totalPrice += 10;
                    break;
            }

        }
        //listbox selection
        private void listBoxEntreeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            entree = listBoxEntreeSelection.GetItemText(listBoxEntreeSelection.SelectedItem);
            try
            {
                switch (entree)
                {
                    case "Chicken Salad":
                        entreePrice += 20;
                        break;
                    case "Ham and Cheese":
                        entreePrice += 10;
                        break;
                    case "Turkey":
                        entreePrice += 50;
                        break;
                    case "Vegetable Wrap":
                        entreePrice += 15;
                        break;
                    case "Tuna Salad":
                        entreePrice += 15;
                        break;
                    case "Avocado and Cheese":
                        entreePrice += 10;
                        break;
                    case "Club":
                        entreePrice += 30;
                        break;
                    case "Peanut Butter and Jelly":
                        entreePrice += 15;
                        break;
                    case "Grilled Cheese":
                        entreePrice += 10;
                        break;
                    case "Reuben":
                        entreePrice += 30;
                        break;
                }
            }

            catch (NullReferenceException em)
            {
                MessageBox.Show("Enter a valid input");
            }
        }
        //menu items
        private void entreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (entree)
            {
                case "Whole Wheat":
                    resetEntreePrice();
                    break;
                case "White Bread":
                    resetEntreePrice();
                    break;
                case "Rye Bread":
                    resetEntreePrice();
                    break;
                case "Hold the Dressing":
                    resetEntreePrice();
                    break;
                case "Hold the Onion":
                    resetEntreePrice();
                    break;
                case "Hold the Mayo":
                    resetEntreePrice();
                    break;
            }
            listBoxEntreeSelection.ClearSelected();

            MessageBox.Show("--Selected cleared successfully--");
        }
        private void resetEntreePrice() 
        {
            entreePrice = 0;
        }
        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonCoffee.Checked)
            {
                radioButtonCoffee.Checked = false;
                drinkPrice = 0;
            }
            if (radioButtonTea.Checked)
            {
                radioButtonTea.Checked = false;
                drinkPrice = 0;
            }
            if (radioButtonLemonade.Checked)
            {
                radioButtonLemonade.Checked = false;
                drinkPrice = 0;
            }
            if (radioButtonSoda.Checked)
            {
                radioButtonSoda.Checked = false;
                drinkPrice = 0;
            }
            if (radioButtonJuice.Checked)
            {
                radioButtonJuice.Checked = false;
                drinkPrice = 0;
            }
            if (radioButtonMilk.Checked)
            {
                radioButtonMilk.Checked = false;
                drinkPrice = 0;
            }
            
            MessageBox.Show("--Selected cleared successfully--");
        }

        private void specialRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (specialRequest)
            {
                case "Whole Wheat":
                    totalPrice -= 10;
                    break;
                case "White Bread":
                    totalPrice -= 15;
                    break;
                case "Rye Bread":
                    totalPrice -= 20;
                    break;
                case "Hold the Dressing":
                    totalPrice -= 10;
                    break;
                case "Hold the Onion":
                    totalPrice -= 10;
                    break;
                case "Hold the Mayo":
                    totalPrice -= 10;
                    break;
            }
            comboBoxSpecialRequest.ResetText();
            MessageBox.Show("--Selected cleared successfully--");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is used for ordering foods of student in Diner Valley");
        }
    }
}
