using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singleTon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        logger log = logger.GetInstance();
       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            log.addToLog(DateTime.Today.ToString()+":" +"add student " + textBox1.Text + " to list");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(log.Tostring());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveLogsToFile();
        }
        private void SaveLogsToFile()
        {
           
            string filePath = "logs.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string logEntry in log.Tostring())
                    {
                        writer.WriteLine(logEntry);
                    }
                }
                MessageBox.Show("Log saved: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save ERROR: " + ex.Message);
            }
        }
    }
}
