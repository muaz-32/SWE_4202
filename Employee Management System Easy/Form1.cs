using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System_Easy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> employees = new List<Employee>();

        private void button_add_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.name = textBox_name.Text;
            employee.id = textBox_id.Text;
            employee.designation = textBox_designation.Text;
            employees.Add(employee);
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            listBox_employees.Items.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                listBox_employees.Items.Add(employees[i].getInfo());
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_id.Clear(); 
            textBox_designation.Clear();
        }
    }
    internal class Employee
    {
        public string name;
        public string id;
        public string designation;
        public string getInfo()
        {
            return name + " " + id + " " + designation;
        }
    }
}
