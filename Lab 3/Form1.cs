// Scottie Sterling
// 4/21/2018
// Lab3
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
     

        class IT_inventory
        {
            private string model;
            public IT_inventory(string str)
            {
                model = str;
            }
            public string get_inventory()
            { return model; } 
       
        }
        class Computer : IT_inventory
        {
            private string os;
            public Computer(string str1, string str2) : base(str2)
            {
                os = str1;
            }
            public string get_os()
            {
                return os;
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IT_inventory IT1 = new IT_inventory(textBox1.Text);
            string str = IT1.get_inventory();
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Computer C1 = new Computer(textBox1.Text, textBox2.Text);
            string str1 = C1.get_inventory();
            string str2 = C1.get_os();
            MessageBox.Show(str1, str2);
        }
    }
    
}
