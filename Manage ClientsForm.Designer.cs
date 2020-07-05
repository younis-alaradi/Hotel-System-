namespace Hotel_System
{
    partial class Manage_ClientsForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.ADDCustomer_btn = new System.Windows.Forms.Button();
            this.Textbox_country = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Textbox_phNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Textbox_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new Hotel_System.CustomerDataSet();
            this.customerTableAdapter = new Hotel_System.CustomerDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Hotel_System.CustomerDataSetTableAdapters.TableAdapterManager();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.database_btn);
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.Remove_btn);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.ADDCustomer_btn);
            this.panel1.Controls.Add(this.Textbox_country);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Textbox_phNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Textbox_LastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_FirstName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 747);
            this.panel1.TabIndex = 0;
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(277, 649);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(160, 35);
            this.Clear_btn.TabIndex = 16;
            this.Clear_btn.Text = "Clear ";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(82, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID :";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.ForeColor = System.Drawing.Color.White;
            this.textBox_ID.Location = new System.Drawing.Point(136, 190);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(529, 29);
            this.textBox_ID.TabIndex = 3;
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(457, 589);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(160, 35);
            this.Remove_btn.TabIndex = 15;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(277, 589);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(160, 35);
            this.Exit_btn.TabIndex = 14;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // ADDCustomer_btn
            // 
            this.ADDCustomer_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ADDCustomer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCustomer_btn.ForeColor = System.Drawing.Color.White;
            this.ADDCustomer_btn.Location = new System.Drawing.Point(99, 589);
            this.ADDCustomer_btn.Name = "ADDCustomer_btn";
            this.ADDCustomer_btn.Size = new System.Drawing.Size(160, 35);
            this.ADDCustomer_btn.TabIndex = 13;
            this.ADDCustomer_btn.Text = "Add new customer ";
            this.ADDCustomer_btn.UseVisualStyleBackColor = false;
            this.ADDCustomer_btn.Click += new System.EventHandler(this.ADDCustomer_btn_Click);
            // 
            // Textbox_country
            // 
            this.Textbox_country.BackColor = System.Drawing.Color.MidnightBlue;
            this.Textbox_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_country.ForeColor = System.Drawing.Color.White;
            this.Textbox_country.Location = new System.Drawing.Point(136, 433);
            this.Textbox_country.Name = "Textbox_country";
            this.Textbox_country.Size = new System.Drawing.Size(529, 29);
            this.Textbox_country.TabIndex = 11;
            this.Textbox_country.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(34, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(34, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(41, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone:";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // Textbox_phNumber
            // 
            this.Textbox_phNumber.BackColor = System.Drawing.Color.MidnightBlue;
            this.Textbox_phNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_phNumber.ForeColor = System.Drawing.Color.White;
            this.Textbox_phNumber.Location = new System.Drawing.Point(136, 376);
            this.Textbox_phNumber.Name = "Textbox_phNumber";
            this.Textbox_phNumber.Size = new System.Drawing.Size(529, 29);
            this.Textbox_phNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(41, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Textbox_LastName
            // 
            this.Textbox_LastName.BackColor = System.Drawing.Color.MidnightBlue;
            this.Textbox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_LastName.ForeColor = System.Drawing.Color.White;
            this.Textbox_LastName.Location = new System.Drawing.Point(136, 316);
            this.Textbox_LastName.Name = "Textbox_LastName";
            this.Textbox_LastName.Size = new System.Drawing.Size(529, 29);
            this.Textbox_LastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(3, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last name : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.ForeColor = System.Drawing.Color.White;
            this.textBox_FirstName.Location = new System.Drawing.Point(136, 253);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(529, 29);
            this.textBox_FirstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(-2, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "First name :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 152);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage clients ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(648, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 694);
            this.label1.TabIndex = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.ReciptTableAdapter = null;
            this.tableAdapterManager.Room_ManageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel_System.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = typeof(Hotel_System.CustomerDataSet);
            // 
            // database_btn
            // 
          
            // 
            // Manage_ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 750);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_ClientsForm";
            this.Load += new System.EventHandler(this.Manage_ClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Textbox_country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Textbox_phNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Textbox_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button ADDCustomer_btn;
        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private CustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button database_btn;
        private System.Windows.Forms.BindingSource customerBindingSource1;
    }
}