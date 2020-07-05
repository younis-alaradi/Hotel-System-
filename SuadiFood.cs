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
    public partial class SuadiFood : Form
    {
        public static double price, TScost;
        public static String foodname;
        public SuadiFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodFORM food = new FoodFORM();
            this.Hide();
            food.Show();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked){ foodname = "Kabsa"; price = 3.8;}
           else if (checkBox1.Checked) { foodname = "mandi"; price = 3.1;}
            else if (checkBox3.Checked)  { foodname = " saleeg"; price = 2.5;  }
            TScost = FoodFORM.NUmberOfBerson * price;
            this.Hide();
            FoodFORM f = new FoodFORM();
            f.Show();

        }

      
    }
}
