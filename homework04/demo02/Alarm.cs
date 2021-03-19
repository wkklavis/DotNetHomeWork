using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02
{
    class Alarm
    {
        private int ss;
        private int mm;
        private int hh;

        public int Alarmss { get; set; }
        public int Alarmmm { get; set; }
        public int Alarmhh { get; set; }
        public Alarm()
        {
            
        }

        public event Action Tick;
        public event Action Alarming;

        public void Begin()
        {
            Tick += Run;
            Alarming += Ding;
            Tick();//开始
        }
        public void Run()
        {
            //开始运行，取得当前时间
            ss = DateTime.Now.Second;
            mm = DateTime.Now.Minute;
            hh = DateTime.Now.Hour;

            while (true) 
            { 
                Console.WriteLine($"嘀嗒  {hh}:{mm}:{ss}");
                System.Threading.Thread.Sleep(1000);
                ss++;
                if (ss % 60 == 0) 
                { 
                    ss = 0; mm++;
                    if(mm%60== 0)
                    {
                        mm = 0;
                        hh++;
                        if(hh%24==0)hh=0;
                    }
                }
                //判断闹钟
                if (ss == Alarmss && mm == Alarmmm && hh == Alarmhh) Alarming();
                if (ss == 0) Alarming();//每60秒，触发一次响铃事件
            }
        }
        public void Ding() { 

            Console.WriteLine("闹钟到了，叮叮叮");
            
        }
    }
}
