using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class NameCard
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard Mycard = new NameCard()
            {
                Name = "상현",
                Age = 24
            };

            Console.WriteLine("이름: {0}", Mycard.Name);
            Console.WriteLine("나이: {0}", Mycard.Age);
        }
    }
}
