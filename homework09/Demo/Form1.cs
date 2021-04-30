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
            myCrawler = new SimpleCrawler();
            /* 双向数据绑定
             * urlInfotextBox.DataBindings.Add("Text", myCrawler, "UrlText",false, DataSourceUpdateMode.OnPropertyChanged);
               exceptionTextBox.DataBindings.Add("Text", myCrawler, "ExceptionText", false, DataSourceUpdateMode.OnPropertyChanged);*/
            urlListView.View = View.List;
            exceptionListView.View = View.List;
            myCrawler.GetUrl += this.GetUrl;
            myCrawler.GetException += this.GetException;

           /* this.urlListView.MinimumSize = new Size(150, 200);
            ImageList imageList = new ImageList();
            urlListView.StateImageList = imageList;
            imageList.ImageSize = new Size(1,20);*/

            
        }

        private void GetException(SimpleCrawler simpleCrawler, string exception)
        {
            Action action = () => { exceptionListView.Items.Add(exception); };
            if (this.InvokeRequired) { this.Invoke(action); }
            else { action(); }
            
        }

        private void GetUrl(SimpleCrawler simpleCrawler, string url)
        {
            Action action = () => { urlListView.Items.Add(url); };
            if (this.InvokeRequired) { this.Invoke(action); }
            else { action(); }
            
        }

        private void crawlerButton_Click(object sender, EventArgs e)
        {
            string startUrl = urlTextBox.Text;
            myCrawler.urls.Add(startUrl, false);          
            new Thread( myCrawler.Crawl).Start();
        }
    }
}
