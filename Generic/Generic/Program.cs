using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) (1) Dictionary implicit version");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            foreach (KeyValuePair<string, string> e in dic)
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            Console.WriteLine();

            Console.WriteLine("1) (2) Dictionary explicit version");            
            IEnumerator it1 = dic.GetEnumerator();
            while (it1.MoveNext())
                Console.WriteLine(it1.Current);
            Console.WriteLine();

            Console.WriteLine("2) (1) Hashtable implicit version");
            Hashtable hash = new Hashtable();
            hash.Add("하나", "one");
            hash.Add("둘", "two");
            hash.Add("셋", "three");
            hash.Add("넷", "four");
            hash.Add("다섯", "five");

            foreach (DictionaryEntry e in hash)
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            Console.WriteLine();

            Console.WriteLine("2) (2) Hashtable explicit version");
            DictionaryEntry d;
            IEnumerator it2 = hash.GetEnumerator();
            while (it2.MoveNext())
            { 
                d = (DictionaryEntry) it2.Current;
                Console.WriteLine("{0}, {1}", d.Key, d.Value);
            }
            Console.WriteLine();
        }
    }
}
