using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
     class Class1
    {
        public void Time()
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, num, 0, 2000);

        }

        public void Count(object obj)
        {
            Thread th1 = new Thread(() =>
            {
                Reader(@"‪C:\test\J1.json");
            });
            th1.Start();

            Thread th2 = new Thread(() => {
                Reader(@"‪C:\test\J2.json");
            });
            th2.Start();

            Thread th3 = new Thread(() =>
            {
                Reader(@"‪C:\test\J3.json");
            });
            th3.Start();

            Console.WriteLine(DateTime.Now.ToString("G"));
        }

        public void Reader(string path)
        {
            switch (path)
            {
                case @"‪C:\test\J1.json":
                    var read1 = Serialize<AllNews, J1>.Reader(@"‪C:\test\J1.json");
                    break;
                case @"‪C:\test\J2.json":
                    var read2 = Serialize<Liststr, J2>.Reader(@"‪C:\test\J2.json");
                    break;
                case @"‪C:\test\J3.json":
                    var read3 = Serialize<ListJ3, J3>.Reader(@"‪C:\test\J3.json");
                    break;
            }

        }

    }
}
