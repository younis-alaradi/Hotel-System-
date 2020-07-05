using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class Drinking_form : Form
    {
       public  static double Drinkingprice;
        public Drinking_form()
        {
            InitializeComponent();
        }
        

        private void Drinking_form_Load(object sender, EventArgs e)
        {
           

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodFORM food = new FoodFORM();
            food.Show();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Drinkingprice = 0.1;
                CustomerChoice_label.Text = "Water";
            }
            else if (radioButton2.Checked)
            {
                Drinkingprice = 1.2;
                CustomerChoice_label.Text = "Orange juice ";
            }
            else if (radioButton3.Checked)
            {
                Drinkingprice = 1.2;
                CustomerChoice_label.Text = "Mango juice ";
            }
            else if (radioButton4.Checked)
            {
                Drinkingprice = 1.2;
                CustomerChoice_label.Text = "Watermelon juice ";
            }
            else if (radioButton5.Checked)
            {
                Drinkingprice = 1.2;
                CustomerChoice_label.Text = "Banana juice ";
            }
            else if (radioButton6.Checked)
            {
                Drinkingprice = 1.2;
                CustomerChoice_label.Text = "Strawberry juice ";
            }
            else if (checkBox1.Checked)
            {
                Drinkingprice = 0.3;
                CustomerChoice_label.Text = "Cocacola";
            }
            else if (checkBox2.Checked)
            {
                Drinkingprice = 0.3;
                CustomerChoice_label.Text = "Fanta";
            }
            else if (checkBox3.Checked) 
            {
                Drinkingprice = 0.3;
                CustomerChoice_label.Text = "Meranda";
            }

              Drinkingprice = FoodFORM.NUmberOfBerson * Drinkingprice;
              drink_price_label.Text = Drinkingprice.ToString();
            this.Hide();
            FoodFORM fv = new FoodFORM();
            fv.Show();
        }
    }
}
