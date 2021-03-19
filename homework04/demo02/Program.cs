using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Alarm alarm = new Alarm();
            //设置闹钟时间
            Console.WriteLine("设置闹钟时间");
            alarm.Alarmhh = Int32.Parse(Console.ReadLine());
            alarm.Alarmmm = Int32.Parse(Console.ReadLine());
            alarm.Alarmss = Int32.Parse(Console.ReadLine());
            
            alarm.Begin();
        }

    
    }
}
