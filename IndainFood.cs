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
    public partial class Handi_FOOD : Form
    {
        public static double IndiaFOODPrice, TotalCost;
        public static String Food_name;
        public Handi_FOOD()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Handi_FOOD_Load(object sender, EventArgs e)
        {
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                IndiaFOODPrice = 3.8;
                TotalCost = FoodFORM.NUmberOfBerson * IndiaFOODPrice;
                Food_name = "Baryani";
            }
            else if (checkBox3.Checked)
            {
                IndiaFOODPrice = 2.8;
                TotalCost = FoodFORM.NUmberOfBerson * IndiaFOODPrice;
                Food_name = "Carry";
            }
            else if (checkBox1.Checked)
            {
                IndiaFOODPrice = 3.5;
                TotalCost = FoodFORM.NUmberOfBerson * IndiaFOODPrice;
                Food_name = "Barbqi";
            }
            this.Hide();
            FoodFORM formF = new FoodFORM();
            formF.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodFORM formF = new FoodFORM();
            formF.Show();
        }
    }
}
