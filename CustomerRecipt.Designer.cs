namespace Hotel_System
{
    partial class CustomerRecipt
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Recipt = new System.Windows.Forms.GroupBox();
            this.Food_Type_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_Cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPR_Text = new System.Windows.Forms.Label();
            this.Invoice_box = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Food_price = new System.Windows.Forms.Label();
            this.Customer_name_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Check_IN_label = new System.Windows.Forms.Label();
            this.check_out_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Invoice_NO = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox_Recipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(628, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 647);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 85);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Recipt ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Recipt
            // 
            this.groupBox_Recipt.Controls.Add(this.check_out_label);
            this.groupBox_Recipt.Controls.Add(this.Check_IN_label);
            this.groupBox_Recipt.Controls.Add(this.label11);
            this.groupBox_Recipt.Controls.Add(this.label9);
            this.groupBox_Recipt.Controls.Add(this.Customer_name_label);
            this.groupBox_Recipt.Controls.Add(this.label10);
            this.groupBox_Recipt.Controls.Add(this.Food_price);
            this.groupBox_Recipt.Controls.Add(this.label8);
            this.groupBox_Recipt.Controls.Add(this.Food_Type_label);
            this.groupBox_Recipt.Controls.Add(this.label5);
            this.groupBox_Recipt.Controls.Add(this.RoomType);
            this.groupBox_Recipt.Controls.Add(this.label7);
            this.groupBox_Recipt.Controls.Add(this.label6);
            this.groupBox_Recipt.Controls.Add(this.Total_Cost);
            this.groupBox_Recipt.Controls.Add(this.label2);
            this.groupBox_Recipt.Controls.Add(this.CPR_Text);
            this.groupBox_Recipt.Controls.Add(this.Invoice_box);
            this.groupBox_Recipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Recipt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox_Recipt.Location = new System.Drawing.Point(25, 104);
            this.groupBox_Recipt.Name = "groupBox_Recipt";
            this.groupBox_Recipt.Size = new System.Drawing.Size(529, 498);
            this.groupBox_Recipt.TabIndex = 2;
            this.groupBox_Recipt.TabStop = false;
            this.groupBox_Recipt.Text = "Total cost ....";
            this.groupBox_Recipt.Enter += new System.EventHandler(this.groupBox_Recipt_Enter);
            // 
            // Food_Type_label
            // 
            this.Food_Type_label.Location = new System.Drawing.Point(134, 196);
            this.Food_Type_label.Name = "Food_Type_label";
            this.Food_Type_label.Size = new System.Drawing.Size(113, 41);
            this.Food_Type_label.TabIndex = 8;
            this.Food_Type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Food Type :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomType
            // 
            this.RoomType.Location = new System.Drawing.Point(134, 137);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(113, 41);
            this.RoomType.TabIndex = 6;
            this.RoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "Room type : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "BD";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Total_Cost
            // 
            this.Total_Cost.Location = new System.Drawing.Point(122, 437);
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.Size = new System.Drawing.Size(113, 41);
            this.Total_Cost.TabIndex = 3;
            this.Total_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Total_Cost.Click += new System.EventHandler(this.Total_Cost_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Cost : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CPR_Text
            // 
            this.CPR_Text.Location = new System.Drawing.Point(174, 33);
            this.CPR_Text.Name = "CPR_Text";
            this.CPR_Text.Size = new System.Drawing.Size(113, 41);
            this.CPR_Text.TabIndex = 1;
            this.CPR_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invoice_box
            // 
            this.Invoice_box.Location = new System.Drawing.Point(-13, 33);
            this.Invoice_box.Name = "Invoice_box";
            this.Invoice_box.Size = new System.Drawing.Size(173, 41);
            this.Invoice_box.TabIndex = 0;
            this.Invoice_box.Text = "Customer CPR :";
            this.Invoice_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(-5, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment Manger ....";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.Transparent;
            this.button_OK.Location = new System.Drawing.Point(669, 580);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(103, 29);
            this.button_OK.TabIndex = 16;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "BD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Food_price
            // 
            this.Food_price.AutoSize = true;
            this.Food_price.Location = new System.Drawing.Point(253, 206);
            this.Food_price.Name = "Food_price";
            this.Food_price.Size = new System.Drawing.Size(0, 20);
            this.Food_price.TabIndex = 10;
            this.Food_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Food_price.Click += new System.EventHandler(this.Food_price_Click);
            // 
            // Customer_name_label
            // 
            this.Customer_name_label.Location = new System.Drawing.Point(174, 87);
            this.Customer_name_label.Name = "Customer_name_label";
            this.Customer_name_label.Size = new System.Drawing.Size(113, 41);
            this.Customer_name_label.TabIndex = 12;
            this.Customer_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-5, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 41);
            this.label10.TabIndex = 11;
            this.label10.Text = "Customer Name : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 41);
            this.label9.TabIndex = 13;
            this.label9.Text = "Check IN : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 41);
            this.label11.TabIndex = 14;
            this.label11.Text = "Check OUT : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Check_IN_label
            // 
            this.Check_IN_label.Location = new System.Drawing.Point(108, 251);
            this.Check_IN_label.Name = "Check_IN_label";
            this.Check_IN_label.Size = new System.Drawing.Size(403, 49);
            this.Check_IN_label.TabIndex = 15;
            this.Check_IN_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // check_out_label
            // 
            this.check_out_label.Location = new System.Drawing.Point(120, 319);
            this.check_out_label.Name = "check_out_label";
            this.check_out_label.Size = new System.Drawing.Size(403, 49);
            this.check_out_label.TabIndex = 16;
            this.check_out_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(546, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 41);
            this.label12.TabIndex = 17;
            this.label12.Text = "Invoice No :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Invoice_NO
            // 
            this.Invoice_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_NO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Invoice_NO.Location = new System.Drawing.Point(654, 192);
            this.Invoice_NO.Name = "Invoice_NO";
            this.Invoice_NO.Size = new System.Drawing.Size(118, 41);
            this.Invoice_NO.TabIndex = 18;
            this.Invoice_NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.Invoice_NO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_Recipt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerRecipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer recipt ";
            this.Load += new System.EventHandler(this.CustomerRecipt_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox_Recipt.ResumeLayout(false);
            this.groupBox_Recipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Recipt;
        private System.Windows.Forms.Label CPR_Text;
        private System.Windows.Forms.Label Invoice_box;
        private System.Windows.Forms.Label Total_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Food_Type_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Food_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Customer_name_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label check_out_label;
        private System.Windows.Forms.Label Check_IN_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Invoice_NO;
    }
}