namespace Hotel_System
{
    partial class ManageReversationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.ADDCustomer_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_RoomNumber = new System.Windows.Forms.ComboBox();
            this.comboBox_RoomType = new System.Windows.Forms.ComboBox();
            this.dateTime_IN = new System.Windows.Forms.DateTimePicker();
            this.dateTime_OUT = new System.Windows.Forms.DateTimePicker();
            this.customerDataSet1 = new Hotel_System.CustomerDataSet();
            this.TextBox_CPR = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Reversation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(701, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 525);
            this.label2.TabIndex = 1;
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(206, 539);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(160, 35);
            this.Clear_btn.TabIndex = 30;
            this.Clear_btn.Text = "Clear ";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(386, 479);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(160, 35);
            this.Remove_btn.TabIndex = 29;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(206, 479);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(160, 35);
            this.Exit_btn.TabIndex = 28;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // ADDCustomer_btn
            // 
            this.ADDCustomer_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ADDCustomer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCustomer_btn.ForeColor = System.Drawing.Color.White;
            this.ADDCustomer_btn.Location = new System.Drawing.Point(28, 479);
            this.ADDCustomer_btn.Name = "ADDCustomer_btn";
            this.ADDCustomer_btn.Size = new System.Drawing.Size(160, 35);
            this.ADDCustomer_btn.TabIndex = 27;
            this.ADDCustomer_btn.Text = "Add new customer ";
            this.ADDCustomer_btn.UseVisualStyleBackColor = false;
            this.ADDCustomer_btn.Click += new System.EventHandler(this.ADDCustomer_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(73, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Date IN :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(0, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Room number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room Type : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(0, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer CPR : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(56, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date Out :";
            // 
            // comboBox_RoomNumber
            // 
            this.comboBox_RoomNumber.BackColor = System.Drawing.Color.MidnightBlue;
            this.comboBox_RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RoomNumber.ForeColor = System.Drawing.Color.White;
            this.comboBox_RoomNumber.FormattingEnabled = true;
            this.comboBox_RoomNumber.Location = new System.Drawing.Point(181, 277);
            this.comboBox_RoomNumber.Name = "comboBox_RoomNumber";
            this.comboBox_RoomNumber.Size = new System.Drawing.Size(445, 26);
            this.comboBox_RoomNumber.TabIndex = 33;
            // 
            // comboBox_RoomType
            // 
            this.comboBox_RoomType.BackColor = System.Drawing.Color.MidnightBlue;
            this.comboBox_RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RoomType.ForeColor = System.Drawing.Color.White;
            this.comboBox_RoomType.FormattingEnabled = true;
            this.comboBox_RoomType.Items.AddRange(new object[] {
            "Single Bed ",
            "Twin Bed ",
            "Family Room "});
            this.comboBox_RoomType.Location = new System.Drawing.Point(184, 193);
            this.comboBox_RoomType.Name = "comboBox_RoomType";
            this.comboBox_RoomType.Size = new System.Drawing.Size(445, 24);
            this.comboBox_RoomType.TabIndex = 32;
            this.comboBox_RoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_RoomType_SelectedIndexChanged);
            // 
            // dateTime_IN
            // 
            this.dateTime_IN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTime_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_IN.Location = new System.Drawing.Point(184, 338);
            this.dateTime_IN.Name = "dateTime_IN";
            this.dateTime_IN.Size = new System.Drawing.Size(445, 26);
            this.dateTime_IN.TabIndex = 34;
            // 
            // dateTime_OUT
            // 
            this.dateTime_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_OUT.Location = new System.Drawing.Point(184, 409);
            this.dateTime_OUT.Name = "dateTime_OUT";
            this.dateTime_OUT.Size = new System.Drawing.Size(445, 26);
            this.dateTime_OUT.TabIndex = 35;
            // 
            // customerDataSet1
            // 
            this.customerDataSet1.DataSetName = "CustomerDataSet";
            this.customerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextBox_CPR
            // 
            this.TextBox_CPR.BackColor = System.Drawing.Color.MidnightBlue;
            this.TextBox_CPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CPR.ForeColor = System.Drawing.Color.White;
            this.TextBox_CPR.Location = new System.Drawing.Point(181, 123);
            this.TextBox_CPR.Name = "TextBox_CPR";
            this.TextBox_CPR.Size = new System.Drawing.Size(448, 28);
            this.TextBox_CPR.TabIndex = 36;
            this.TextBox_CPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageReversationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 598);
            this.Controls.Add(this.TextBox_CPR);
            this.Controls.Add(this.dateTime_OUT);
            this.Controls.Add(this.dateTime_IN);
            this.Controls.Add(this.comboBox_RoomNumber);
            this.Controls.Add(this.comboBox_RoomType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.ADDCustomer_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReversationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReversationForm";
            this.Load += new System.EventHandler(this.ManageReversationForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button ADDCustomer_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_RoomNumber;
        private System.Windows.Forms.ComboBox comboBox_RoomType;
        private System.Windows.Forms.DateTimePicker dateTime_IN;
        private System.Windows.Forms.DateTimePicker dateTime_OUT;
        private CustomerDataSet customerDataSet1;
        private System.Windows.Forms.Label TextBox_CPR;
    }
}