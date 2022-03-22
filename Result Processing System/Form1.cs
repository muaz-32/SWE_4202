using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        public List<string> id = new List<string>();
        public List<string> name = new List<string>();
        public List<int> attendance = new List<int>();
        
        public List<int> quiz1 = new List<int>();
        public List<int> quiz2 = new List<int>();
        public List<int> quiz3 = new List<int>();
        public List<int> quiz4 = new List<int>();
        public List<int> mid = new List<int>();
        public List<int> final = new List<int>();
        public List<int> viva = new List<int>();
        List<float> percentage = new List<float>();
        List<string> grade = new List<string>();
        public Form1()
        {
            InitializeComponent();
            readData();
            writeData();

        }
        public void readData()
        {
            StreamReader reader = new StreamReader(@"D:\SWE4201MarkSheet.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values;
                values = line.Split(',');
                id.Add(values[0]);
                name.Add(values[1]);
                attendance.Add(Convert.ToInt32(values[2]));
                try
                {
                    
                    quiz1.Add(Convert.ToInt32(values[3]));
                    
                }
                catch
                {
                    quiz1.Add(0);
                }
                try
                {

                    quiz2.Add(Convert.ToInt32(values[4]));

                }
                catch
                {
                    quiz2.Add(0);
                }
                try
                {

                    quiz3.Add(Convert.ToInt32(values[5]));

                }
                catch
                {
                    quiz3.Add(0);
                }
                try
                {

                    quiz4.Add(Convert.ToInt32(values[6]));

                }
                catch
                {
                    quiz4.Add(0);
                }
                
                mid.Add(Convert.ToInt32(values[7]));
                try
                {

                    final.Add(Convert.ToInt32(values[8]));

                }
                catch
                {
                    final.Add(0);
                }
                try
                {

                    viva.Add(Convert.ToInt32(values[9]));

                }
                catch
                {
                    viva.Add(0);
                }
                

            }
        }
        public void writeData()
        {
            listBox_id.Items.Clear();
            listBox_name.Items.Clear();
            listBox_percentage.Items.Clear();
            listBox_grade.Items.Clear();
            for(int i = 0; i < id.Count; i++)
            {
                listBox_id.Items.Add(id[i]);
                listBox_name.Items.Add(name[i]);
                buildList();
            }
        }
        public int totalOfBest3Quizzes(int i)
        {
            List<int> quizzes = new List<int>();
            quizzes.Add(quiz1[i]);
            quizzes.Add(quiz2[i]);
            quizzes.Add(quiz3[i]);
            quizzes.Add(quiz4[i]);
            quizzes.Sort();
            return quizzes[1] + quizzes[2] + quizzes[3];
        }
        public int totalMarks(int i)
        {
            return attendance[i] + totalOfBest3Quizzes(i) + mid[i] + final[i] + viva[i];
        }
        public float percentageOfTotalMarks(int i)
        {
            return totalMarks(i) * 100 / 300 ;
        }
        public string gradeCalculation(int i)
        {
            if (percentageOfTotalMarks(i) >= 0 && percentageOfTotalMarks(i) <= 39)
                return "F";
            else if (percentageOfTotalMarks(i) >= 40 && percentageOfTotalMarks(i) <= 44)
                return "D";
            else if (percentageOfTotalMarks(i) >= 45 && percentageOfTotalMarks(i) <= 49)
                return "C";
            else if (percentageOfTotalMarks(i) >= 50 && percentageOfTotalMarks(i) <= 54)
                return "C+";
            else if (percentageOfTotalMarks(i) >= 55 && percentageOfTotalMarks(i) <= 59)
                return "B-";
            else if (percentageOfTotalMarks(i) >= 60 && percentageOfTotalMarks(i) <= 64)
                return "B";
            else if (percentageOfTotalMarks(i) >= 65 && percentageOfTotalMarks(i) <= 69)
                return "B+";
            else if (percentageOfTotalMarks(i) >= 70 && percentageOfTotalMarks(i) <= 74)
                return "A-";
            else if (percentageOfTotalMarks(i) >= 75 && percentageOfTotalMarks(i) <= 79)
                return "A";
            else
                return "A+";
        }
        public void buildList()
        {
            for(int i = 0; i < id.Count; i++)
            {
                percentage.Add(percentageOfTotalMarks(i));
                grade.Add(gradeCalculation(i));
            }
            listBox_grade.Items.Clear();
            for(int i = 0; i < id.Count; i++)
            {
                listBox_percentage.Items.Add(percentage[i]);
                listBox_grade.Items.Add(grade[i]);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var data = from student in id
                       where textBox_searchId.Text == student
                       select student;
            foreach(var item in data)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    if (id[i] == item)
                    {
                        textBox_attendance.Text = Convert.ToString(attendance[i]);
                        textBox_final.Text = Convert.ToString(final[i]);
                        textBox_grade.Text = Convert.ToString(grade[i]);
                        textBox_mid.Text = Convert.ToString(mid[i]);
                        textBox_percentage.Text = Convert.ToString(percentage[i]);
                        textBox_quiz1.Text = Convert.ToString(quiz1[i]);
                        textBox_quiz2.Text = Convert.ToString(quiz2[i]);
                        textBox_quiz3.Text = Convert.ToString(quiz3[i]);
                        textBox_quiz4.Text = Convert.ToString(quiz4[i]);
                        textBox_quiztotal.Text = Convert.ToString(totalOfBest3Quizzes(i));
                        textBox_total.Text = Convert.ToString(totalMarks(i));
                        textBox_viva.Text = Convert.ToString(viva[i]);
                    }
                }
            }
            

        }
    }
}
