using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();

        private void button_stu_clr_Click(object sender, System.EventArgs e)
        {
            textbox_stu_dept.Clear();
            textBox_stu_ID.Clear();
            textbox_stu_name.Clear();
            textbox_stu_sem.Clear();
        }

        private void button_tchr_clr_Click(object sender, System.EventArgs e)
        {
            textbox_tchr_dept.Clear();
            textbox_tchr_desig.Clear();
            textbox_tchr_ID.Clear();
            textbox_tchr_name.Clear();
            textbox_tchr_salary.Clear();
        }

        private void button_stu_save_Click(object sender, System.EventArgs e)
        {
            Student dummy = new Student();
            dummy.setID(textBox_stu_ID.Text);
            dummy.setname(textbox_stu_name.Text);
            dummy.setdept(textbox_stu_dept.Text);
            dummy.setsem(textbox_stu_sem.Text);
            students.Add(dummy);
            
            MessageBox.Show("Added");

        }

        private void button_tchr_save_Click(object sender, System.EventArgs e)
        {
            Teacher dummy = new Teacher();
            dummy.setID(textbox_tchr_ID.Text);
            dummy.setname(textbox_tchr_name.Text);
            dummy.setdesig(textbox_tchr_desig.Text);
            dummy.setdept(textbox_tchr_dept.Text);
            dummy.setsalary(textbox_tchr_salary.Text);
            teachers.Add(dummy);
            
            MessageBox.Show("Added");
        }

        private void listBox_tchr_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void listBox_stu_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void button_stu_show_Click(object sender, System.EventArgs e)
        {
            listBox_stu.Items.Clear();
            for (int i=0; i<students.Count; i++)
            {
                listBox_stu.Items.Add(students[i].getinfo());
            }
        }

        private void button_tchr_show_Click(object sender, System.EventArgs e)
        {
            listBox_tchr.Items.Clear();
            for (int i=0; i<teachers.Count; i++)
            {
                listBox_tchr.Items.Add(teachers[i].getinfo());
            }
        }
    }
    
    
}
