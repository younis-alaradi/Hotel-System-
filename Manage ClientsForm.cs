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
   
    public partial class Manage_ClientsForm : Form
    {
        public static string ID, Fname;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual_StudioC#\Hotel_System\Hotel_System\CustomerData.mdf;Integrated Security=True;Connect Timeout=30");

        public Manage_ClientsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_FirstName.Text = "";
            Textbox_LastName.Text = "";
            Textbox_phNumber.Text = "";
            Textbox_country.Text = "";
        }

        private void ADDCustomer_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Customer values (' " + textBox_ID.Text + " ', ' " + textBox_FirstName.Text + " ',' " + Textbox_LastName.Text + " ', ' " + Textbox_phNumber.Text + " ', ' " + Textbox_country + " ' )";
            ; 
            if (textBox_ID.Text == command.CommandText)
            {
                textBox_ID.Text = "0";
            }
            else
            {
                command.ExecuteNonQuery();
                con.Close();
                display_Information();
                MessageBox.Show("Customer information ", "Inserted sucssufull", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID = textBox_ID.Text;
                Fname = textBox_FirstName.Text;
            }
            this.Hide();
            ManageReversationForm ManREV = new ManageReversationForm();
            ManREV.Show();

        }
        public void display_Information()
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * from Customer";
            command.ExecuteNonQuery();
            DataTable Customer_Table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(Customer_Table);

            
            con.Close();

        }

        private void Manage_ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);
            display_Information();

        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete    from Customer where  name =' " + textBox_ID.Text + " ' ";
            ; MessageBox.Show("Customer information deleted  sucssfuly","Customer manager ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            command.ExecuteNonQuery();
            con.Close();
            display_Information();
            

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm open = new MainForm();
            open.Show();
        }

     
    }
}
