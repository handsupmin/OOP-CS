using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    class Program
    {
        interface IBorder
        {
            void writeBorder(string content);
        }

        class Monitor
        {
            private IBorder border;
            public Monitor(IBorder border)
            {
                this.border = border;
            }
            public void start()
            {
                Console.Write("텍스트를 입력해주세요.: ");
                string context = Console.ReadLine();
                border.writeBorder(context);
            }
        }

        class Star: IBorder
        {
            public void writeBorder(string content)
            {
                for (int i = 0; i < 14; i++)
                    Console.Write("*");
                Console.WriteLine("\n*{0}*",content);
                for (int i = 0; i < 14; i++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        class Slash : IBorder
        {
            public void writeBorder(string content)
            {
                for (int i = 0; i < 14; i++)
                    Console.Write("/");
                Console.WriteLine("\n/{0}/", content);
                for (int i = 0; i < 14; i++)
                    Console.Write("/");
                Console.Write("\n");
            }
        }
        class Wave : IBorder
        {
            public void writeBorder(string content)
            {
                for (int i = 0; i < 14; i++)
                    Console.Write("~");
                Console.WriteLine("\n~{0}~", content);
                for (int i = 0; i < 14; i++)
                    Console.Write("~");
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            Monitor monitor = new Monitor(new Star());
            monitor.start();
            monitor = new Monitor(new Slash());
            monitor.start();
            monitor = new Monitor(new Wave());
            monitor.start();
        }
    }
}
