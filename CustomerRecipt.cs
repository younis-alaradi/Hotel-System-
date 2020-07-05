using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System
{
    public partial class CustomerRecipt : Form
    {
        public  double TotalCost;
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual_StudioC#\Hotel_System\Hotel_System\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");

        public CustomerRecipt()
        {
            InitializeComponent();
        }

        private void CustomerRecipt_Load(object sender, EventArgs e)
        {
            int index = 1;
            CPR_Text.Text += Manage_ClientsForm.ID;
           
            TotalCost = FoodFORM.TCost + ManageReversationForm.TNcost+(FoodFORM.TCost + ManageReversationForm.TNcost)*2; 
            Total_Cost.Text = TotalCost.ToString();
            RoomType.Text = ManageReversationForm.RoomType;
            Food_Type_label.Text = FoodFORM.FoodType;
            Food_price.Text = FoodFORM.TCost.ToString();
            Customer_name_label.Text = Manage_ClientsForm.Fname;
            Check_IN_label.Text = ManageReversationForm.Date_IN;
            check_out_label.Text = ManageReversationForm.Date_out;
            index++;
            Invoice_NO.Text = index.ToString();
     }

        private void button_OK_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Recipt values (' " + CPR_Text.Text + " ', ' " + Total_Cost.Text+" ' )";
                MessageBox.Show("Payment", "paid sucssesfully", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Recipt_Enter(object sender, EventArgs e)
        {

        }

        private void Food_price_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Total_Cost_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
