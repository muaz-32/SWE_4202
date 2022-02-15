using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_add_id.Text = "1";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(comboBox_add_designation.Text == "Manager")
            {
                Manager dummy = new Manager();
                dummy.id = Convert.ToInt32(textBox_add_id.Text);
                dummy.name = textBox_add_name.Text;
                dummy.contact = textBox_add_contact.Text;
                dummy.date_of_joining = dateTimePicker_add_date_joining.Value;
                dummy.salary = Convert.ToDouble(textBox_add_salary.Text);
                dummy.leaves = Convert.ToInt32(textBox_add_leaves.Text);
                Employee_Management_System.add_employee(dummy);
                int id = Convert.ToInt32(textBox_add_id.Text);
                textBox_add_id.Text = Convert.ToString(id++);
            }
            else if (comboBox_add_designation.Text == "Salesperson")
            {
                Salesperson dummy = new Salesperson();
                dummy.id = Convert.ToInt32(textBox_add_id.Text);
                dummy.name = textBox_add_name.Text;
                dummy.contact = textBox_add_contact.Text;
                dummy.date_of_joining = dateTimePicker_add_date_joining.Value;
                dummy.salary = Convert.ToDouble(textBox_add_salary.Text);
                dummy.leaves = Convert.ToInt32(textBox_add_leaves.Text);
                Employee_Management_System.add_employee(dummy);
                int id = Convert.ToInt32(textBox_add_id.Text);
                textBox_add_id.Text = Convert.ToString(id++);
            }
            else if (comboBox_add_designation.Text == "Typewriter")
            {
                Typewriter dummy = new Typewriter();
                dummy.id = Convert.ToInt32(textBox_add_id.Text);
                dummy.name = textBox_add_name.Text;
                dummy.contact = textBox_add_contact.Text;
                dummy.date_of_joining = dateTimePicker_add_date_joining.Value;
                dummy.salary = Convert.ToDouble(textBox_add_salary.Text);
                dummy.leaves = Convert.ToInt32(textBox_add_leaves.Text);
                Employee_Management_System.add_employee(dummy);
                int id = Convert.ToInt32(textBox_add_id.Text);
                textBox_add_id.Text = Convert.ToString(id++);
            }
            else
            {

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Employee dummy = new Employee(); 
            try
            {
                dummy = Employee_Management_System.get_employee(Convert.ToInt32(textBox_search_id.Text));
                textBox_search_name.Text = dummy.name;
                textBox_search_contact.Text = dummy.contact;
                textBox_search_salary.Text = Convert.ToString(dummy.get_salary());
                textBox_search_leaves.Text = Convert.ToString(dummy.leaves);

                dateTimePicker_search_date_joining.Value = dummy.date_of_joining;
            }
            catch(search_not_found_exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Employee dummy = new Employee();
            dummy.name = textBox_search_name.Text;
            dummy.contact = textBox_search_contact.Text;
            dummy.salary = Convert.ToInt32(textBox_search_salary.Text);
            dummy.leaves = Convert.ToInt32(textBox_search_leaves.Text);
            dummy.id = Convert.ToInt32(textBox_search_id.Text);
            dummy.date_of_joining = dateTimePicker_search_date_joining.Value;
            try
            {
                Employee_Management_System.update_employee(dummy, Convert.ToInt32(textBox_search_id.Text));
            }
            catch (search_not_found_exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
