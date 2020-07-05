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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_ClientsForm ManageClient = new Manage_ClientsForm();
            ManageClient.Show();
         
        }

        private void manageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageReversationForm manageRever = new ManageReversationForm();
            manageRever.ShowDialog();
        }


        private void foodManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodFORM foodform = new FoodFORM();
            foodform.Show();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            pictureBox_singleRoom.Visible = false;
            pictureBox_double.Visible = false;
            pictureBox_familyRoom.Visible = false;

        }

        private void single_room_Click(object sender, EventArgs e)
        {
            pictureBox_singleRoom.Visible = true;
        }

        private void Double_room_Click(object sender, EventArgs e)
        {
            pictureBox_double.Visible = true;
        }

        private void family_room_Click(object sender, EventArgs e)
        {
            pictureBox_familyRoom.Visible = true;
        }

    
    }
}
