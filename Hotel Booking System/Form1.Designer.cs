namespace Hotel_Booking_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.Number_of_room_text = new System.Windows.Forms.TextBox();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.Room_type_combo = new System.Windows.Forms.ComboBox();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Another_booking_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cost_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Number_of_Days_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Name_text
            // 
            this.Name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_text.Location = new System.Drawing.Point(269, 165);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(291, 27);
            this.Name_text.TabIndex = 5;
            // 
            // Number_of_room_text
            // 
            this.Number_of_room_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_room_text.Location = new System.Drawing.Point(269, 282);
            this.Number_of_room_text.Name = "Number_of_room_text";
            this.Number_of_room_text.Size = new System.Drawing.Size(75, 27);
            this.Number_of_room_text.TabIndex = 6;
            // 
            // Address_text
            // 
            this.Address_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_text.Location = new System.Drawing.Point(269, 204);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(327, 27);
            this.Address_text.TabIndex = 7;
            // 
            // Room_type_combo
            // 
            this.Room_type_combo.FormattingEnabled = true;
            this.Room_type_combo.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.Room_type_combo.Location = new System.Drawing.Point(269, 244);
            this.Room_type_combo.Name = "Room_type_combo";
            this.Room_type_combo.Size = new System.Drawing.Size(121, 24);
            this.Room_type_combo.TabIndex = 8;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_btn.Location = new System.Drawing.Point(626, 160);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(240, 31);
            this.Calculate_btn.TabIndex = 9;
            this.Calculate_btn.Text = "Calculate the Price";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(766, 215);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 31);
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(766, 280);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 31);
            this.Exit_btn.TabIndex = 11;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Another_booking_combo
            // 
            this.Another_booking_combo.FormattingEnabled = true;
            this.Another_booking_combo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Another_booking_combo.Location = new System.Drawing.Point(349, 388);
            this.Another_booking_combo.Name = "Another_booking_combo";
            this.Another_booking_combo.Size = new System.Drawing.Size(102, 24);
            this.Another_booking_combo.TabIndex = 13;
            this.Another_booking_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Do you want to another booking ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Cost_text
            // 
            this.Cost_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_text.Location = new System.Drawing.Point(635, 381);
            this.Cost_text.Name = "Cost_text";
            this.Cost_text.Size = new System.Drawing.Size(182, 27);
            this.Cost_text.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total of Cost";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Number_of_Days_text
            // 
            this.Number_of_Days_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_Days_text.Location = new System.Drawing.Point(269, 322);
            this.Number_of_Days_text.Name = "Number_of_Days_text";
            this.Number_of_Days_text.Size = new System.Drawing.Size(75, 27);
            this.Number_of_Days_text.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of Days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 529);
            this.Controls.Add(this.Number_of_Days_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cost_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Another_booking_combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Room_type_combo);
            this.Controls.Add(this.Address_text);
            this.Controls.Add(this.Number_of_room_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox Number_of_room_text;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.ComboBox Room_type_combo;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.ComboBox Another_booking_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cost_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Number_of_Days_text;
        private System.Windows.Forms.Label label8;
    }
}

