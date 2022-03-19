using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Medicine> medicines = new List<Medicine>();
        List<Accessories> accessories = new List<Accessories>();
        public int money = 0;

        private void button_medicine_add_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.name = textBox_medicine_name.Text;
            medicine.qty = Convert.ToInt32(textBox_medicine_qty.Text);
            medicine.cost = Convert.ToInt32(textBox_medicine_cost.Text);
            medicines.Add(medicine);
        }

        private void button_accessories_add_Click(object sender, EventArgs e)
        {
            Accessories accessory = new Accessories();
            accessory.name = textBox_accessories_name.Text;
            accessory.qty = Convert.ToInt32(textBox_accessories_qty.Text);
            accessory.cost = Convert.ToInt32(textBox_accessories_cost.Text);
            accessories.Add(accessory);
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            if(textBox_buy_type.Text == "Medicine")
            {
                for(int i = 0; i < medicines.Count; i++)
                {
                    if(medicines[i].name == textBox_buy_name.Text)
                    {
                        money += medicines[i].cost * Convert.ToInt32(textBox_buy_qty.Text);
                        medicines[i].qty -= Convert.ToInt32(textBox_buy_qty.Text);
                    }
                }
            }
            else if(textBox_buy_type.Text == "Accessory")
            {
                for (int i = 0; i < accessories.Count; i++)
                {
                    if (accessories[i].name == textBox_buy_name.Text)
                    {
                        money += accessories[i].cost * Convert.ToInt32(textBox_buy_qty.Text);
                        accessories[i].qty -= Convert.ToInt32(textBox_buy_qty.Text);
                    }
                }
            }
            else
            {

            }
        }

        private void button_balance_Click(object sender, EventArgs e)
        {
            textBox_balance.Text = Convert.ToString(money);
        }
    }
    internal class Medicine
    {
        public string name;
        public int qty;
        public int cost;
    }
    internal class Accessories
    {
        public string name;
        public int qty;
        public int cost;
    }
}
