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
    public partial class ManageReversationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual_StudioC#\Hotel_System\Hotel_System\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");

        public static int N_Of_person;
        public static double night;
        public static double TNcost;
        public static string RoomType, Date_IN, Date_out;
        

        public ManageReversationForm()
        {
            InitializeComponent();
        }

       
      

        private void comboBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nightDay;//= (dateTime_OUT.Value - dateTime_IN.Value).Days;

            var  startDate = Convert.ToDateTime(dateTime_IN.Value);
            var endDate =  Convert.ToDateTime(dateTime_OUT.Value);
            Date_IN = Convert.ToDateTime(dateTime_IN.Value).ToString();
            Date_out = endDate.ToString();
    

            TimeSpan dates = startDate - endDate;
            nightDay = dates.Days + 1;
            if (comboBox_RoomType.Text == "Single Bed ")
            {
                night = 30;
                N_Of_person = 1;
                

                comboBox_RoomNumber.Items.Add("102");
                comboBox_RoomNumber.Items.Add("104");
                comboBox_RoomNumber.Items.Add("106");
                comboBox_RoomNumber.Items.Add("108");
                comboBox_RoomNumber.Items.Add("202");
                comboBox_RoomNumber.Items.Add("204");
                comboBox_RoomNumber.Items.Add("206");
                comboBox_RoomNumber.Items.Add("208");

            }
            else if (comboBox_RoomType.Text == "Twin Bed ")
            {
                night = 50;
                N_Of_person = 2;
                comboBox_RoomNumber.Items.Add("101");
                comboBox_RoomNumber.Items.Add("103");
                comboBox_RoomNumber.Items.Add("105");
                comboBox_RoomNumber.Items.Add("107");
                comboBox_RoomNumber.Items.Add("109");
                comboBox_RoomNumber.Items.Add("201");
                comboBox_RoomNumber.Items.Add("203");
                comboBox_RoomNumber.Items.Add("205");

            }
            else if (comboBox_RoomType.Text == "Family Room ")
            {
                
                night = 60;
                N_Of_person = 5;
                
                comboBox_RoomNumber.Items.Add("207");
                comboBox_RoomNumber.Items.Add("209");
                comboBox_RoomNumber.Items.Add("210");
                comboBox_RoomNumber.Items.Add("301");
                comboBox_RoomNumber.Items.Add("302");
                comboBox_RoomNumber.Items.Add("303");
                comboBox_RoomNumber.Items.Add("304");
                comboBox_RoomNumber.Items.Add("305");
            }
            TNcost = nightDay * night;
            RoomType = comboBox_RoomType.Text;

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }

        private void ADDCustomer_btn_Click(object sender, EventArgs e)
        {  
            con.Open();
            SqlCommand command = con.CreateCommand();
            //command.ExecuteNonQuery();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert*into Room_Manage values (' " + TextBox_CPR.Text + " ', ' " + comboBox_RoomType.Text + " ',' " +comboBox_RoomNumber.Text + " ', ' " + dateTime_IN.Value.ToString()+ " ', ' " + dateTime_OUT.Value.ToString() + " ' )";
            MessageBox.Show("Room manager ", "Room sucssufully inserted to database ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            con.Close();
            display_Information();

            this.Hide();
            FoodFORM food = new FoodFORM();
            food.Show();

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
         
            TextBox_CPR.Text = "";
            comboBox_RoomNumber.Text = "";
            comboBox_RoomType.Text = "";
        }

        private void ManageReversationForm_Load(object sender, EventArgs e)
        {
            TextBox_CPR.Text = Manage_ClientsForm.ID;
            display_Information();
        }
        public void display_Information()
        {
           /* con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * from  Reversations";
            command.ExecuteNonQuery();
            DataTable Reversations_Table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(Reversations_Table);
            dataGridView_Reversations.DataSource = Reversations_Table;


            con.Close();*/

        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE *   from Reversations WHERE  name =' " +TextBox_CPR.Text+ " ' ";
            ; MessageBox.Show("Room information deleted  sucssfuly");
            command.ExecuteNonQuery();
            con.Close();
            display_Information();

        }
    }
}
