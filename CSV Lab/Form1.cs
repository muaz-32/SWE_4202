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

namespace CSV_Lab
{
    public partial class Form1 : Form
    {
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        List<string> list4 = new List<string>();
        List<string> list5 = new List<string>();
        List<string> list6 = new List<string>();
        List<string> list7 = new List<string>();
        List<string> list8 = new List<string>();
        List<string> list9 = new List<string>();
        List<string> list10 = new List<string>();
        List<string> list11 = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            loadData();
            writeData();
        }

        public void loadData()
        {
            StreamReader reader = new StreamReader(@"D:\userinfo.csv");
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values;
                values = line.Split(',');
                list1.Add(values[0]);
                list2.Add(values[1]);
                list3.Add(values[2]);
                list4.Add(values[3]);
                list5.Add(values[4]);
                list6.Add(values[5]);
                list7.Add(values[6]);
                list8.Add(values[7]);
                list9.Add(values[8]);
                list10.Add(values[9]);
                list11.Add(values[10]);
            }
        }
        public void writeData()
        {
            listBox_userinfo.Items.Clear();
            for(int i = 0; i < list1.Count; i++)
            {
                listBox_userinfo.Items.Add(getUserInfo(i));
            }
            
        }
        public string getUserInfo(int i)
        {
            return list1[i] + "\t" + list2[i] + "\t" + list10[i];
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            bool found = false;
            for(int i=0; i < list1.Count; i++)
            {
                if(textBox_search.Text == list11[i])
                {
                    found = true;
                    textBox_name.Text = list1[i];
                    textBox_last_name.Text = list2[i];
                    
                    textBox_address.Text = list4[i];
                    textBox_city.Text = list5[i];
                    textBox_country.Text = list6[i];
                    textBox_state.Text = list7[i];
                    textBox_zip.Text = list8[i];
                    textBox_phone1.Text = list9[i];
                }
            }

            DateTime dateTime = DateTime.Now;
            using (StreamWriter writer = File.AppendText(@"C:\Users\muaz_\Source\Repos\CSV Lab\File.txt"))
            {
                writer.Write(textBox_search.Text + " ");
                if(found)
                {
                    writer.Write("Found ");
                }
                else
                {
                    writer.Write("Not Found ");
                }
                writer.WriteLine(dateTime);
            }
                

        }
    }
}
        
        
        
        

