using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class FoodFORM : Form
    {
        public static double price;
        public static int NUmberOfBerson = ManageReversationForm.N_Of_person;
        public static double TCost;
        public static String FoodType;
        public FoodFORM()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Handi_Food_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Handi_FOOD Hfood = new Handi_FOOD();
            Hfood.Show();
        }

        private void Saudi_Food_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuadiFood Sfood = new SuadiFood();
            Sfood.Show();

        }

        private void Bahrani_Food_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bahrani_Food foodForm = new Bahrani_Food();
            foodForm.Show();
        }

        private void FoodFORM_Load(object sender, EventArgs e)
        {textBox_NumberOfBerson.Text = NUmberOfBerson.ToString();
        }


        private void button_OK_Click(object sender, EventArgs e)
        {
   

            if (checkBox1.Checked)
            {
                price = 5;
                TCost = price * NUmberOfBerson;
                Total_cost.Text = TCost.ToString();
                FoodType = "buffet";

            }
            else
            {
                
                    if (Drinking_form.Drinkingprice == 0)
                    {
                        DrinkPrice.Text = "No Drinks";
                        TCost = Handi_FOOD.TotalCost;
                        Total_cost.Text = TCost.ToString();
                    }
                    else
                    {

                      DrinkPrice.Text = Drinking_form.Drinkingprice.ToString();
                        Food_price.Text = Handi_FOOD.TotalCost.ToString();
                        TCost = Drinking_form.Drinkingprice + Handi_FOOD.TotalCost;
                    FoodType = Handi_FOOD.Food_name;
                        Total_cost.Text = TCost.ToString();
                    
                
                   
                        DrinkPrice.Text = Drinking_form.Drinkingprice.ToString();
                        Food_price.Text = SuadiFood.TScost.ToString();
                        TCost = Drinking_form.Drinkingprice + SuadiFood.TScost;
                         FoodType = SuadiFood.foodname;
                         Total_cost.Text = TCost.ToString();
                   
                
             
                        DrinkPrice.Text = Drinking_form.Drinkingprice.ToString();
                        Food_price.Text = Bahrani_Food.TBcost.ToString();
                        TCost = Drinking_form.Drinkingprice + Bahrani_Food.TBcost;
                    FoodType = Bahrani_Food.foodName;
                         Total_cost.Text = TCost.ToString();
                    }
              //  CustomerRecipt.TotalCost += TCost;
            
              
             }
           



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinking_form formD = new Drinking_form();
            formD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { this.Hide();
            CustomerRecipt CR = new CustomerRecipt();
            CR.Show();
        }
    }
}
