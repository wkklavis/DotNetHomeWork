using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    class SimpleCrawler// : INotifyPropertyChanged双向数据绑定
    {
        /*//双向数据绑定
        private string urlText = "";
        private string exceptionText = "";
        public string UrlText { get { return urlText; } set { urlText = value; NotifyPropertyChanged(() => UrlText); } } 
        public string ExceptionText { get { return exceptionText; } set { exceptionText = value; NotifyPropertyChanged(() => ExceptionText); } }*/

        public System.Windows.Forms.ListView urlListView ;
        public System.Windows.Forms.ListView exceptionListView;

        public Hashtable urls = new Hashtable();
        public int count = 0;

      

        /*static void Main(string[] args)
        {
        SimpleCrawler myCrawler = new SimpleCrawler();
        string startUrl = "http://www.cnblogs.com/dstang2000/";
        if (args.Length >= 1) startUrl = args[0];
        myCrawler.urls.Add(startUrl, false);//加入初始页面
        new Thread(myCrawler.Crawl).Start();
        }*/

        public void Crawl()
        {
            
            urlListView.Items.Add(new ListViewItem("开始爬行了.... \r\n"));
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) 
                {
                    break; 
                }
                urlListView.Items.Add(new ListViewItem("爬行" + current + "页面!"));


                
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;

                Parse(html,current);//解析,并加入新的链接

               // urlListView.Items.Add("爬行结束");
            }
        }

        

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                exceptionListView.Items.Add(new ListViewItem(ex.Message+""));
                return "";
            }
        }

        private void Parse(string html,string current)//此时HTML为
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";//超链接
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)//每一个超链接
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;

                string completeUrl = Convert(strRef,current);//转换成完整格式
                if (Check(strRef)&&urls[strRef] == null) urls[strRef] = false;//只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL。

            }
        }

        private string Convert(string url,string current)
        {
            if (url.StartsWith("https")) return url;//完整格式不用处理
            if (current.EndsWith("/")) current= current.Substring(0, current.Length - 1);
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }

            if(url.StartsWith("/"))
            {
                return current +url.Substring(1);
            }
            if (url.StartsWith("./"))//转变成test/test1一样处理
            {
                return Convert(url.Substring(2),current);
            }
            if (url.StartsWith("../"))
            {
                int position = current.LastIndexOf("/");
                return Convert(url.Substring(3),current.Substring(0,position));
            }



            return current + "/" + url;
        }

        private bool Check(string html)//判断是否为html/aspx/jsp
        {
            return Regex.IsMatch(html, @".*\.jsp") || Regex.IsMatch(html, @".*\.html") || Regex.IsMatch(html, @".*\.aspx");
        }


        /*  双向数据绑定
          public event PropertyChangedEventHandler PropertyChanged;
          public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
          {
              if (PropertyChanged == null)
                  return;

              var memberExpression = property.Body as MemberExpression;
              if (memberExpression == null)
                  return;

              PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
          }*/
    }
}
