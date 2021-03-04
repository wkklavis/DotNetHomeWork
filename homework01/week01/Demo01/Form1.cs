using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
           
            double num2 = double.Parse(textBox2.Text);
            double result = 0;
            string operation = (string)comboBox.SelectedItem;
            switch (operation)
            {
                case "+": { result = num1 + num2; break; }
                case "-": { result = num1 - num2; break; }
                case "*": { result = num1 * num2; break; }
                case "/": { result = num1 / num2; break; }
            
            }
            textBox3.Text=result.ToString();


        }

       
    }
}
