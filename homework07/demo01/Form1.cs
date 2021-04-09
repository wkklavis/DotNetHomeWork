using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen =new Pen(Color.Pink);
        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panel1.CreateGraphics();
            graphics.Clear(this.panel1.BackColor);
            int n;
            if (nTextBox.Text != String.Empty) { n = Int32.Parse(nTextBox.Text); }
            else n = 10;

            double leng;
            if (lengTextBox.Text != String.Empty) { leng = Double.Parse(lengTextBox.Text); }
            else leng = 100;

            if(per1TextBox.Text!= String.Empty) per1 = Double.Parse(per1TextBox.Text);
            if(per2TextBox.Text != String.Empty) per2 = Double.Parse(per2TextBox.Text);
            if (th1TextBox.Text != String.Empty) th1 = Double.Parse(th1TextBox.Text);
            if (th2TextBox.Text != String.Empty) th2 = Double.Parse(th2TextBox.Text);
            if (penListBox.SelectedItem != null) {
                String penColor = penListBox.SelectedItem.ToString();
            switch (penColor)
            {
                case "黑色": { pen = new Pen(Color.Black);break; }
                case "蓝色": { pen = new Pen(Color.Blue);break; }
                case "红色": { pen = new Pen(Color.Red);break; }
                default: { pen = new Pen(Color.Black);break; }
            } 
            }
            

            DrawCayleyTree(n, 200, 510, leng, -Math.PI / 2);
        }

        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            DrawLine(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
    }
}
