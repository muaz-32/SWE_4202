using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Muaz_132;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();

        private void button_User_Save_Click(object sender, EventArgs e)
        {
            User dummy = new User();
            dummy.setName(textBox_User_User_Name.Text);
            dummy.setID(textBox_User_User_ID.Text);
            dummy.setDesignation (textBox_User_Designation.Text);
            dummy.setAddress (textBox_User_Address.Text);
            users.Add(dummy);
            MessageBox.Show("Saved");
        }

        private void button_Car_Save_Click(object sender, EventArgs e)
        {
            Car dummy = new Car();
            dummy.setName(textBox_Car_Car_Name.Text);
            dummy.setModel(textBox_Car_Car_Model.Text);
            dummy.setNum(Convert.ToInt32(textBox_Car_Number_of_Cars.Text));
            cars.Add(dummy);
            MessageBox.Show("Saved");
        }

        private void button_User_Clear_Click(object sender, EventArgs e)
        {
            textBox_User_User_Name.Clear();
            textBox_User_User_ID.Clear();
            textBox_User_Designation.Clear();
            textBox_User_Address.Clear();
        }

        private void button_Car_Clear_Click(object sender, EventArgs e)
        {
            textBox_Car_Car_Name.Clear();
            textBox_Car_Car_Model.Clear();
            textBox_Car_Number_of_Cars.Clear();
        }

        private void button_Rent_Rent_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<users.Count;i++)
            {
                if (users[i].getID() == textBox_Rent_User_ID.Text)
                {
                    users[i].setRented_Car(textBox_Rent_Car_Name.Text);
                }
            }
            for(i =0; i<cars.Count; i++)
            {
                if(cars[i].getName() == textBox_Rent_Car_Name.Text)
                {
                    cars[i].setNum(cars[i].getNum() - 1);
                }
            }
            MessageBox.Show("Rented");
        }

        private void button_Rent_Clear_Click(object sender, EventArgs e)
        {
            textBox_Rent_User_ID.Clear();
            textBox_Rent_Car_Name.Clear();
        }

        private void button_User_History_Show_Click(object sender, EventArgs e)
        {
            for(int i=0; i<users.Count; i++)
            {
                if (users[i].getID() == textBox_User_History_User_ID.Text)
                {
                    textBox_User_History_User_Name.Text = users[i].getName();
                    textBox_User_History_Rented_Car.Text = users[i].getRented_Car();
                    textBox_User_History_Designation.Text = users[i].getDesignation();
                    textBox_User_History_Address.Text = users[i].getAddress();
                }
            }
        }

        private void button_Car_History_Show_Click(object sender, EventArgs e)
        {
            for(int i=0; i<cars.Count; i++)
            {
                if (cars[i].getName() == textBox_Car_History_Car_Name.Text)
                {
                    textBox_Car_History_Car_Model.Text = cars[i].getModel();
                    textBox_Car_History_Available_Unit.Text = Convert.ToString(cars[i].getNum());
                }
            }
        }
    }
}
