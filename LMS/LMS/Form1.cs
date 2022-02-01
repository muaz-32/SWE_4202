using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_tchr_add_Click(object sender, EventArgs e)
        {
            if(comboBox_tchr_type.Text == "Lecturer")
            {
                Lecturer dummy = new Lecturer(textBox_tchr_name.Text, "Lecturer");
                
                
                LMS_Class_library.lecturers.Add(dummy);
                comboBox_listbox_tchr.Items.Add(textBox_tchr_name.Text);
            }
            else if(comboBox_tchr_type.Text == "Professor")
            {
                Professor dummy = new Professor(textBox_tchr_name.Text, "Professor");
                
                
                LMS_Class_library.professors.Add(dummy);
                comboBox_listbox_tchr.Items.Add(textBox_tchr_name.Text);
            }
        }

        private void button_crse_add_Click(object sender, EventArgs e)
        {
            Course dummy = new Course();
            dummy.type = comboBox_crse_type.Text;
            dummy.code = textBox_crse_code.Text;
            dummy.sem = comboBox_crse_sem.Text;
            dummy.title = textBox_crse_title.Text;
            dummy.tchr = comboBox_crse_tchr.Text;
            LMS_Class_library.courses.Add(dummy);
            
            for(int i=0; i<LMS_Class_library.lecturers.Count; i++)
            {
                if(LMS_Class_library.lecturers[i].name == comboBox_crse_tchr.Text)
                {
                    LMS_Class_library.lecturers [i].courses.Add(dummy);
                }
            }
            for(int i=0; i<LMS_Class_library.professors.Count; i++)
            {
                if(LMS_Class_library.professors[i].name == comboBox_crse_tchr.Text)
                {
                    LMS_Class_library.professors[i].courses.Add(dummy);
                }
            }
        }

        private void button_stdnt_add_Click(object sender, EventArgs e)
        {
            Student dummy = new Student();
            dummy.name = textBox_stdnt_name.Text;
            dummy.sem = comboBox_stdnt_sem.Text;
            dummy.crse.Add(comboBox_stdnt_crse.Text);
            LMS_Class_library.students.Add(dummy);
            comboBox_listbox_stdnt.Items.Add(textBox_stdnt_name.Text);
        }

        private void comboBox_crse_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_crse_type.Text == "Lab")
            {
                comboBox_crse_tchr.Items.Clear();
                for (int i=0; i<LMS_Class_library.lecturers.Count; i++)
                {
                    comboBox_crse_tchr.Items.Add(LMS_Class_library.lecturers[i].name);
                }
            }
            else if(comboBox_crse_type.Text == "Theory")
            {
                comboBox_crse_tchr.Items.Clear();
                for (int i = 0; i < LMS_Class_library.professors.Count; i++)
                {
                    comboBox_crse_tchr.Items.Add(LMS_Class_library.professors[i].name);
                }
            }
            else
            {

            }
        }

        private void comboBox_stdnt_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_stdnt_sem.Text == "1")
            {
                comboBox_stdnt_crse.Items.Clear();
                for(int i=0; i<LMS_Class_library.courses.Count; i++)
                {
                    if(LMS_Class_library.courses[i].sem == "1")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if(comboBox_stdnt_sem.Text == "2")
            {
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "2")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
                //comboBox_stdnt_crse.Items.Clear();
            }
            else if(comboBox_stdnt_sem.Text== "3")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "3")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if (comboBox_stdnt_sem.Text == "4")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "4")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if (comboBox_stdnt_sem.Text == "5")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "5")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if (comboBox_stdnt_sem.Text == "6")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "6")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if (comboBox_stdnt_sem.Text == "7")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "7")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else if (comboBox_stdnt_sem.Text == "8")
            {
                comboBox_stdnt_crse.Items.Clear();
                comboBox_stdnt_crse.Items.Clear();
                for (int i = 0; i < LMS_Class_library.courses.Count; i++)
                {
                    if (LMS_Class_library.courses[i].sem == "8")
                    {
                        comboBox_stdnt_crse.Items.Add(LMS_Class_library.courses[i].code);
                    }
                }
            }
            else
            {

            }
        }

        private void button_tchr_show_Click(object sender, EventArgs e)
        {
            listBox_tchr.Items.Clear();
            for(int i=0; i<LMS_Class_library.lecturers.Count; i++)
            {
                if(comboBox_listbox_tchr.Text == LMS_Class_library.lecturers[i].name)
                {
                    listBox_tchr.Items.Add(LMS_Class_library.lecturers[i].getInfo());
                    for(int j=0; j<LMS_Class_library.lecturers[i].courses.Count; j++)
                    {
                        listBox_tchr.Items.Add(LMS_Class_library.lecturers[i].getCourseInfo(j));
                    }
                    listBox_tchr.Items.Add("Credit: " + LMS_Class_library.lecturers[i].getCredit());
                    
                }
            }
            for(int i=0; i<LMS_Class_library.professors.Count; i++)
            {
                if(comboBox_listbox_tchr.Text == LMS_Class_library.professors[i].name)
                {
                    listBox_tchr.Items.Add(LMS_Class_library.professors[i].getInfo());
                    for (int j = 0; j < LMS_Class_library.professors[i].courses.Count; j++)
                    {
                        listBox_tchr.Items.Add(LMS_Class_library.professors[i].getCourseInfo(j));
                    }
                    listBox_tchr.Items.Add("Credit: " + LMS_Class_library.professors[i].getCredit());
                }
            }
        }

        private void button_stdnt_info_Click(object sender, EventArgs e)
        {
            listBox_stdnt.Items.Clear();
            for(int i=0; i<LMS_Class_library.students.Count; i++)
            {
                if(comboBox_listbox_stdnt.Text == LMS_Class_library.students[i].name)
                {
                    listBox_stdnt.Items.Add(LMS_Class_library.students[i].getInfo());
                    for(int j=0; j<LMS_Class_library.students[i].crse.Count; j++)
                    {
                        listBox_stdnt.Items.Add(LMS_Class_library.students[i].crse[j]);
                    }
                }
            }    
        }
    }
}
