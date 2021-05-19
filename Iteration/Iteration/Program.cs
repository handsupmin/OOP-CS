using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        // IEnumerator 맴버
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        // IEnumerator 맴버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        // IEnumerator 맴버
        public void Reset()
        {
            position = -1;
        }

        // IEnumerable 맴버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) (1) MyList implicit version");
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
            Console.WriteLine();

            Console.WriteLine("1) (2) MyList explicit version");
            MyList list2 = new MyList();
            for (int i = 0; i < 5; i++)
                list2[i] = i;
            IEnumerator it = list2.GetEnumerator();

            while(it.MoveNext())
                Console.WriteLine(it.Current);
            Console.WriteLine();

            Console.WriteLine("2) (1) ArrayList implicit version");
            ArrayList list3 = new ArrayList {1, 2, 3, 4, 5};
            for (int i = 0; i < 5; i++)
                list3[i] = i;

            foreach (int e in list3)
                Console.WriteLine(e);
            Console.WriteLine();

            Console.WriteLine("2) (2) ArrayList explicit version");
            ArrayList list4 = new ArrayList { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
                list4[i] = i;
            IEnumerator it2 = list4.GetEnumerator();

            while (it2.MoveNext())
                Console.WriteLine(it2.Current);
        }
    }
}
