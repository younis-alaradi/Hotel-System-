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
    public partial class Bahrani_Food : Form
    {
        public static double price, TBcost;
        public static string foodName;
        public Bahrani_Food()
        {
            InitializeComponent();
         
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {   if (checkBox1.Checked)
            {
                price = 4.2;
                foodName = "Legumes ";
            }
            else if (checkBox2.Checked)
            {
                price = 5.6;
                foodName = "Tradtional ";


            }
            else if (checkBox3.Checked)
            {
                price = 3.9;
                foodName = "Muhammer";
            }
            TBcost = FoodFORM.NUmberOfBerson * price;

            this.Hide();
            FoodFORM formF = new FoodFORM();

            formF.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodFORM open = new FoodFORM();
            open.Show();
        }
    }
}
