using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
            /* 双向数据绑定
             * urlInfotextBox.DataBindings.Add("Text", myCrawler, "UrlText",false, DataSourceUpdateMode.OnPropertyChanged);
               exceptionTextBox.DataBindings.Add("Text", myCrawler, "ExceptionText", false, DataSourceUpdateMode.OnPropertyChanged);*/
            myCrawler.exceptionTextBox = this.exceptionTextBox;
            myCrawler.urlInfotextBox = this.urlInfotextBox;
        }

        private void crawlerButton_Click(object sender, EventArgs e)
        {
            string startUrl = urlTextBox.Text;
            myCrawler.urls.Add(startUrl, false);      
            
            myCrawler.Crawl();//?????Thread
        }
    }
}
