using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate int MyDivide(int a, int b);

        static void Main(string[] args)
        {
            // Anonymous function 사용
            MyDivide myFunc;
            myFunc = delegate (int a, int b)
            {
                if (b == 0)
                {
                    return -1; // 발견한 버그, null 값은 반환될 수 없음
                }

                return a / b;
            };
            void write(int a, int b)
            {
                int result = myFunc(a, b);

                if (result != -1)
                    Console.WriteLine("{0} / {1} == {2}", a, b, result);
                else
                    Console.WriteLine("{0} / {1} == ", a, b);
            }

            int t1, t2;

            t1 = 10;
            t2 = 2;
            write(t1, t2);

            t2 = 0;
            write(t1, t2);

            // Lambda식을 사용하여 구현
            MyDivide myFunc2;

            myFunc2 = (int a, int b) => { return (a / b); };

            t1 = 10;
            t2 = 2;
            Console.WriteLine("{0} / {1} == {2}", t1, t2, myFunc2(t1, t2));

            // Function Delegate 사용
            Func<int, int, int> myFunc3 = (int a, int b) => { return (a / b); };

            t1 = 10;
            t2 = 2;
            Console.WriteLine("{0} / {1} == {2}", t1, t2, myFunc3(t1, t2));

            // Action Delegate 사용
            Action<int, int> myFunc4 = (int a, int b) => { Console.WriteLine("{0} / {1} == {2}", a, b, (a / b)); };
            myFunc4(10, 2);
        }
    }
}