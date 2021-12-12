using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculation_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Grade_Click(object sender, EventArgs e)
        {
            int no_attended_classes = Convert.ToInt32(textBox_Number_of_attended_classes.Text);
            Label_value_Attendance.Text = Convert.ToString(Convert.ToInt32((no_attended_classes / 28.0) * 30.0)) + "/30";
            Label_value_Mid.Text = textBox_Mid.Text + "/75";
            Label_value_Final.Text = textBox_Final.Text + "/150";
            int[] quiz_marks = { Convert.ToInt32(textBox_Quiz1.Text), Convert.ToInt32(textBox_Quiz2.Text), Convert.ToInt32(textBox_Quiz3.Text), Convert.ToInt32(textBox_Quiz4.Text) };
            Array.Sort(quiz_marks);
            int i, quiz_total = 0;
            for (i = quiz_marks.Length - 1; i > 0; i--)
            {
                quiz_total+=quiz_marks[i];
            }
            Label_value_Quiz.Text = Convert.ToString(quiz_total) + "/45";
            int Total_Marks = (Convert.ToInt32((no_attended_classes / 28.0) * 30.0)) + Convert.ToInt32(textBox_Mid.Text) + Convert.ToInt32(textBox_Final.Text) + quiz_total;
            Label_value_Total.Text = Convert.ToString(Total_Marks) + "/300";
            int percentage = (Total_Marks * 100) / 300;

            if (percentage >= 80)
                Label_value_Grade.Text = "A+";
            else if (percentage >= 75 && percentage < 80)
                Label_value_Grade.Text = "A";
            else if (percentage >= 70 && percentage < 75)
                Label_value_Grade.Text = "A-";
            else if (percentage >= 65 && percentage < 70)
                Label_value_Grade.Text = "B+";
            else if (percentage >= 60 && percentage < 65)
                Label_value_Grade.Text = "B";
            else if (percentage >= 55 && percentage < 60)
                Label_value_Grade.Text = "B-";
            else if (percentage >= 50 && percentage < 55)
                Label_value_Grade.Text = "C+";
            else if (percentage >= 45 && percentage < 50)
                Label_value_Grade.Text = "C";
            else if (percentage >= 40 && percentage < 45)
                Label_value_Grade.Text = "D";
            else
                Label_value_Grade.Text = "F";
            Label_Final_Statement.Text = textBox_Name.Text + " obtained " + Convert.ToString(percentage) + "% marks.";
        }
    }
}
