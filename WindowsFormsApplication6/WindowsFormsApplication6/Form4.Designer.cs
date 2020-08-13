namespace WindowsFormsApplication6
{
    partial class Form4
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
            this.total = new System.Windows.Forms.TextBox();
            this.TaxtxtBox = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GrpBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.Unit_Price1txtBox = new System.Windows.Forms.TextBox();
            this.GrpBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SPhone = new System.Windows.Forms.TextBox();
            this.Supplier = new System.Windows.Forms.TextBox();
            this.OrderTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GrpBox = new System.Windows.Forms.GroupBox();
            this.GrpBox1.SuspendLayout();
            this.GrpBox2.SuspendLayout();
            this.GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(6, 138);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(88, 20);
            this.total.TabIndex = 5;
            // 
            // TaxtxtBox
            // 
            this.TaxtxtBox.Location = new System.Drawing.Point(6, 86);
            this.TaxtxtBox.Name = "TaxtxtBox";
            this.TaxtxtBox.ReadOnly = true;
            this.TaxtxtBox.Size = new System.Drawing.Size(88, 20);
            this.TaxtxtBox.TabIndex = 4;
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(6, 35);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Size = new System.Drawing.Size(88, 20);
            this.Subtotal.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "SubTotal:";
            // 
            // GrpBox1
            // 
            this.GrpBox1.Controls.Add(this.button3);
            this.GrpBox1.Controls.Add(this.button1);
            this.GrpBox1.Controls.Add(this.total);
            this.GrpBox1.Controls.Add(this.TaxtxtBox);
            this.GrpBox1.Controls.Add(this.Subtotal);
            this.GrpBox1.Controls.Add(this.label14);
            this.GrpBox1.Controls.Add(this.label13);
            this.GrpBox1.Controls.Add(this.label12);
            this.GrpBox1.Location = new System.Drawing.Point(382, 211);
            this.GrpBox1.Name = "GrpBox1";
            this.GrpBox1.Size = new System.Drawing.Size(191, 190);
            this.GrpBox1.TabIndex = 5;
            this.GrpBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(110, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "SUBMIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(110, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tax (%):";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(161, 95);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(61, 22);
            this.quantity.TabIndex = 12;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Unit_Price1txtBox
            // 
            this.Unit_Price1txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Price1txtBox.Location = new System.Drawing.Point(269, 95);
            this.Unit_Price1txtBox.Name = "Unit_Price1txtBox";
            this.Unit_Price1txtBox.Size = new System.Drawing.Size(72, 22);
            this.Unit_Price1txtBox.TabIndex = 11;
            this.Unit_Price1txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrpBox2
            // 
            this.GrpBox2.Controls.Add(this.comboBox1);
            this.GrpBox2.Controls.Add(this.quantity);
            this.GrpBox2.Controls.Add(this.Unit_Price1txtBox);
            this.GrpBox2.Controls.Add(this.button2);
            this.GrpBox2.Controls.Add(this.TotalBtn);
            this.GrpBox2.Controls.Add(this.label11);
            this.GrpBox2.Controls.Add(this.label7);
            this.GrpBox2.Controls.Add(this.label6);
            this.GrpBox2.Location = new System.Drawing.Point(12, 211);
            this.GrpBox2.Name = "GrpBox2";
            this.GrpBox2.Size = new System.Drawing.Size(364, 190);
            this.GrpBox2.TabIndex = 3;
            this.GrpBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Diesel"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.comboBox1.Location = new System.Drawing.Point(22, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(193, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotalBtn
            // 
            this.TotalBtn.BackColor = System.Drawing.Color.Yellow;
            this.TotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBtn.Location = new System.Drawing.Point(89, 154);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(75, 23);
            this.TotalBtn.TabIndex = 6;
            this.TotalBtn.Text = "Total ";
            this.TotalBtn.UseVisualStyleBackColor = false;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Fuel Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unit Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time:";
            // 
            // SPhone
            // 
            this.SPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPhone.Location = new System.Drawing.Point(170, 114);
            this.SPhone.Name = "SPhone";
            this.SPhone.Size = new System.Drawing.Size(100, 22);
            this.SPhone.TabIndex = 5;
            // 
            // Supplier
            // 
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.Location = new System.Drawing.Point(170, 62);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(100, 22);
            this.Supplier.TabIndex = 7;
            // 
            // OrderTime
            // 
            this.OrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTime.Location = new System.Drawing.Point(445, 114);
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.Size = new System.Drawing.Size(100, 22);
            this.OrderTime.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(445, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // GrpBox
            // 
            this.GrpBox.Controls.Add(this.dateTimePicker1);
            this.GrpBox.Controls.Add(this.OrderTime);
            this.GrpBox.Controls.Add(this.Supplier);
            this.GrpBox.Controls.Add(this.SPhone);
            this.GrpBox.Controls.Add(this.label5);
            this.GrpBox.Controls.Add(this.label4);
            this.GrpBox.Controls.Add(this.label2);
            this.GrpBox.Controls.Add(this.label1);
            this.GrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBox.Location = new System.Drawing.Point(12, 19);
            this.GrpBox.Name = "GrpBox";
            this.GrpBox.Size = new System.Drawing.Size(561, 176);
            this.GrpBox.TabIndex = 4;
            this.GrpBox.TabStop = false;
            this.GrpBox.Text = "ORDER DETAILS";
            this.GrpBox.Enter += new System.EventHandler(this.GrpBox_Enter);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 419);
            this.Controls.Add(this.GrpBox1);
            this.Controls.Add(this.GrpBox2);
            this.Controls.Add(this.GrpBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ORDERS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.GrpBox1.ResumeLayout(false);
            this.GrpBox1.PerformLayout();
            this.GrpBox2.ResumeLayout(false);
            this.GrpBox2.PerformLayout();
            this.GrpBox.ResumeLayout(false);
            this.GrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox TaxtxtBox;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GrpBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox Unit_Price1txtBox;
        private System.Windows.Forms.GroupBox GrpBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SPhone;
        private System.Windows.Forms.TextBox Supplier;
        private System.Windows.Forms.TextBox OrderTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox GrpBox;
    }
}