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
        SimpleCrawler myCrawler ;
        
        public Form1()
        {
            InitializeComponent();
            /* 双向数据绑定
             * urlInfotextBox.DataBindings.Add("Text", myCrawler, "UrlText",false, DataSourceUpdateMode.OnPropertyChanged);
               exceptionTextBox.DataBindings.Add("Text", myCrawler, "ExceptionText", false, DataSourceUpdateMode.OnPropertyChanged);*/
            urlListView.View = View.List;
            exceptionListView.View = View.List;

           /* this.urlListView.MinimumSize = new Size(150, 200);
            ImageList imageList = new ImageList();
            urlListView.StateImageList = imageList;
            imageList.ImageSize = new Size(1,20);*/

            
        }

        private void crawlerButton_Click(object sender, EventArgs e)
        {
            myCrawler = new SimpleCrawler();
            myCrawler.urlListView = this.urlListView;
            myCrawler.exceptionListView = this.exceptionListView;
            
            string startUrl = urlTextBox.Text;
            myCrawler.urls.Add(startUrl, false);
            
            myCrawler.Crawl();//?????Thread
        }
    }
}
