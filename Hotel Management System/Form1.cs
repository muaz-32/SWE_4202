using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_user_id.Text = "1";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            User dummy = new User(textBox_user_name.Text, Convert.ToInt32(textBox_user_id.Text), textBox_user_contact.Text, textBox_user_address.Text);
            Hotel_Management_System.users_add(dummy);
            int id = Convert.ToInt32(textBox_user_id.Text);
            textBox_user_id.Text = Convert.ToString(id++);
            MessageBox.Show("Added");
        }

        private void button_place_booking_Click(object sender, EventArgs e)
        {
            Booking dummy = new Booking(comboBox_booking_room_choice.Text, Convert.ToInt32(textBox_booking_qty.Text), dateTimePicker_entry.Value.Date, dateTimePicker_departure.Value.Date, Convert.ToInt32(textBox_booking_user_id.Text), false);
            Hotel_Management_System.bookings_add(dummy);
            MessageBox.Show("Your booking id is" + dummy.id);
        }

        private void button_set_status_Click(object sender, EventArgs e)
        {
            Hotel_Management_System.set_status(Convert.ToInt32(textBox_owner_booking_id.Text), comboBox_owner_status.Text);
            Hotel_Management_System.set_money(Convert.ToInt32(textBox_owner_booking_id.Text));
            MessageBox.Show("Setted");
        }

        private void button_see_order_details_Click(object sender, EventArgs e)
        {
            Booking dummy = Hotel_Management_System.get_booking(Convert.ToInt32(textBox_order_id.Text));
            for(int i = 0; i < Hotel_Management_System.users.Count; i++)
            {
                if(Hotel_Management_System.users[i].id == dummy.user_id)
                {
                    textBox_order_name.Text = Hotel_Management_System.users[i].name;
                    textBox_order_address.Text = Hotel_Management_System.users[i].address;
                }
            }
            if(dummy.booking_confirmation == true)
            {
                textBox_order_status.Text = "confirmed";
            }
            else
            {
                textBox_order_status.Text = "pending";
            }
            textBox_order_amount.Text = Convert.ToString(dummy.get_amount());
            
        }

        private void button_check_current_balance_Click(object sender, EventArgs e)
        {
            textBox_check_current_balance.Text = Convert.ToString(Hotel_Management_System.get_money());
        }

        private void button_listbox_details_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Hotel_Management_System.bookings.Count; i++)
            {
                listBox_show_details.Items.Add(Hotel_Management_System.bookings[i].get_info());
            }
        }
    }
}
