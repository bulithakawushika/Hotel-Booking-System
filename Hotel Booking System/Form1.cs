using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    public partial class Form1 : Form
    {
        int available_single = 10,available_double=7,available_family=4,available_suite=2;
        double cost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //total cost calculate method
        public double calculate_cost (int room_rate,int number_of_Days,int number_of_rooms,string room_type)
        {
            cost = cost+(room_rate * number_of_Days * number_of_rooms);
            if (room_type == "Double" & number_of_Days > 5)
            {
                cost = cost * 0.95;
            }
            if (room_type == "Suite" & number_of_Days > 5)
            {
                cost = cost * 0.88;
            }
            return cost;
        }

        //clearn text after one selection
        public void clean_form_room_data()
        {
            Number_of_Days_text.Clear();
            Number_of_room_text.Clear();
            Room_type_combo.SelectedIndex = -1;
            Another_booking_combo.SelectedIndex = -1;
        }

        //exit button
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calculate the price button
        private void button1_Click(object sender, EventArgs e)
        {
            string room_type,Another_room= "No" ;  
            int room_rate = 0, number_of_rooms = 0, number_of_Days = 0;

            room_type = Room_type_combo.Text;

            //Cheeck personal information
            if (Name_text.Text == "" | Address_text.Text == "")
            {
                MessageBox.Show("Enter your personal details correctly (Name and Address) ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //exception handeling number of days,rooms are not fill and invalid input
                try
                {
                    number_of_rooms = int.Parse(Number_of_room_text.Text);
                    number_of_Days = int.Parse(Number_of_Days_text.Text);
                }
                catch
                {
                    MessageBox.Show("Form is incomplete or invalid input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            if (number_of_Days > 0)
            {

                //select type of room
                switch (room_type)
                {
                    case "Single":
                        room_rate = 5000;

                        //check availability of room
                        if (number_of_rooms <= available_single)
                        {
                            available_single -= number_of_rooms;
                            cost = calculate_cost(room_rate, number_of_Days, number_of_rooms, room_type);
                        }
                        else
                        {
                            //rooms are not available message
                            MessageBox.Show("Single Rooms are not Available at this moment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "Double":
                        room_rate = 7500;
                        if (number_of_rooms <= available_double)
                        {
                            available_double -= number_of_rooms;
                            cost = calculate_cost(room_rate, number_of_Days, number_of_rooms, room_type);
                        }
                        else
                        {
                            MessageBox.Show("Double Rooms are not Available at this moment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "Family":
                        room_rate = 8000;
                        if (number_of_rooms <= available_family)
                        {
                            cost = calculate_cost(room_rate, number_of_Days, number_of_rooms, room_type);
                            available_family -= number_of_rooms;
                        }
                        else
                        {
                            MessageBox.Show("Family Rooms are not Available at this moment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        break;

                    case "Suite":
                        room_rate = 12500;
                        if (number_of_rooms <= available_suite)
                        {
                            cost = calculate_cost(room_rate, number_of_Days, number_of_rooms, room_type);
                            available_suite -= number_of_rooms;
                        }
                        else
                        {
                            MessageBox.Show("Suite Rooms are not Available at this moment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        break;
                    //room type is not selected message
                    default:
                        MessageBox.Show(" Select Room Type", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            Cost_text.Text = Convert.ToString(Math.Round(cost, 2));

            //Another booking for same user ( by default anoter room is set as "No" )

            Another_room = Another_booking_combo.Text;
            if (Another_room == "Yes")
            {
                clean_form_room_data();
            }

        }

        //clear button
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            cost = 0;
            Cost_text.Clear();
            Name_text.Clear();
            Address_text.Clear();
            clean_form_room_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
