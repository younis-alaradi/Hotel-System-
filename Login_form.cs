using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        void login() 
        {
            for (int i = 0; i <= 500; i++) 
            {
                Thread.Sleep(10);
            }
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            using (WatingForm frm = new WatingForm(login)) 
            {
                frm.ShowDialog(this);
            }
            Connect conn = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `user` WHERE `username` =@usn AND `password`=@pass ";

            command.CommandText = query;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Username_TextBOX;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Username_password_Text;


            adapter.SelectCommand = command;

            //adapter.Fill(table);

            if (Username_TextBOX.Text=="younis" &&Username_password_Text.Text=="0000")
            {
               
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
                

            }
            else
            {
                if (Username_TextBOX.Text.Trim().Equals(" ")) 
                {
                    MessageBox.Show("Enter your username  to login ", "Empty username ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Username_TextBOX.Text.Trim().Equals(" "))
                {
                    MessageBox.Show("Enter your password to login ", "Empty password ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
             
        }
    }
}
