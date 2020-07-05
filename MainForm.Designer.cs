namespace Hotel_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.single_room = new System.Windows.Forms.Button();
            this.Double_room = new System.Windows.Forms.Button();
            this.family_room = new System.Windows.Forms.Button();
            this.pictureBox_familyRoom = new System.Windows.Forms.PictureBox();
            this.pictureBox_double = new System.Windows.Forms.PictureBox();
            this.pictureBox_singleRoom = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_familyRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_singleRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientsToolStripMenuItem,
            this.manageReservationToolStripMenuItem,
            this.foodManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageClientsToolStripMenuItem
            // 
            this.manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            this.manageClientsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.manageClientsToolStripMenuItem.Text = "Customer manage ";
            this.manageClientsToolStripMenuItem.Click += new System.EventHandler(this.manageClientsToolStripMenuItem_Click);
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
            this.manageReservationToolStripMenuItem.Click += new System.EventHandler(this.manageReservationToolStripMenuItem_Click);
            // 
            // foodManagerToolStripMenuItem
            // 
            this.foodManagerToolStripMenuItem.Name = "foodManagerToolStripMenuItem";
            this.foodManagerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.foodManagerToolStripMenuItem.Text = "Food Manager";
            this.foodManagerToolStripMenuItem.Click += new System.EventHandler(this.foodManagerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(636, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 451);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(147, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to hotel system";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // single_room
            // 
            this.single_room.BackColor = System.Drawing.Color.White;
            this.single_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.single_room.ForeColor = System.Drawing.Color.MidnightBlue;
            this.single_room.Location = new System.Drawing.Point(12, 121);
            this.single_room.Name = "single_room";
            this.single_room.Size = new System.Drawing.Size(170, 28);
            this.single_room.TabIndex = 3;
            this.single_room.Text = "Single Room";
            this.single_room.UseVisualStyleBackColor = false;
            this.single_room.Click += new System.EventHandler(this.single_room_Click);
            // 
            // Double_room
            // 
            this.Double_room.BackColor = System.Drawing.Color.White;
            this.Double_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_room.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Double_room.Location = new System.Drawing.Point(65, 155);
            this.Double_room.Name = "Double_room";
            this.Double_room.Size = new System.Drawing.Size(170, 28);
            this.Double_room.TabIndex = 4;
            this.Double_room.Text = "double ";
            this.Double_room.UseVisualStyleBackColor = false;
            this.Double_room.Click += new System.EventHandler(this.Double_room_Click);
            // 
            // family_room
            // 
            this.family_room.BackColor = System.Drawing.Color.White;
            this.family_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.family_room.ForeColor = System.Drawing.Color.MidnightBlue;
            this.family_room.Location = new System.Drawing.Point(167, 189);
            this.family_room.Name = "family_room";
            this.family_room.Size = new System.Drawing.Size(170, 28);
            this.family_room.TabIndex = 5;
            this.family_room.Text = "Family Room ";
            this.family_room.UseVisualStyleBackColor = false;
            this.family_room.Click += new System.EventHandler(this.family_room_Click);
            // 
            // pictureBox_familyRoom
            // 
            this.pictureBox_familyRoom.Image = global::Hotel_System.Properties.Resources.family_room;
            this.pictureBox_familyRoom.Location = new System.Drawing.Point(343, 40);
            this.pictureBox_familyRoom.Name = "pictureBox_familyRoom";
            this.pictureBox_familyRoom.Size = new System.Drawing.Size(287, 177);
            this.pictureBox_familyRoom.TabIndex = 8;
            this.pictureBox_familyRoom.TabStop = false;
            // 
            // pictureBox_double
            // 
            this.pictureBox_double.Image = global::Hotel_System.Properties.Resources.twin_bed;
            this.pictureBox_double.Location = new System.Drawing.Point(343, 40);
            this.pictureBox_double.Name = "pictureBox_double";
            this.pictureBox_double.Size = new System.Drawing.Size(287, 177);
            this.pictureBox_double.TabIndex = 7;
            this.pictureBox_double.TabStop = false;
            // 
            // pictureBox_singleRoom
            // 
            this.pictureBox_singleRoom.Image = global::Hotel_System.Properties.Resources.single_bed;
            this.pictureBox_singleRoom.Location = new System.Drawing.Point(343, 40);
            this.pictureBox_singleRoom.Name = "pictureBox_singleRoom";
            this.pictureBox_singleRoom.Size = new System.Drawing.Size(287, 177);
            this.pictureBox_singleRoom.TabIndex = 6;
            this.pictureBox_singleRoom.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_familyRoom);
            this.Controls.Add(this.pictureBox_double);
            this.Controls.Add(this.pictureBox_singleRoom);
            this.Controls.Add(this.family_room);
            this.Controls.Add(this.Double_room);
            this.Controls.Add(this.single_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_familyRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_singleRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodManagerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button single_room;
        private System.Windows.Forms.Button Double_room;
        private System.Windows.Forms.Button family_room;
        private System.Windows.Forms.PictureBox pictureBox_singleRoom;
        private System.Windows.Forms.PictureBox pictureBox_double;
        private System.Windows.Forms.PictureBox pictureBox_familyRoom;
    }
}