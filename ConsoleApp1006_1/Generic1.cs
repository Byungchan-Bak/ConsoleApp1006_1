using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006_1
{
    class Calc<T>   //모든 데이터 타입을 받기 위해 제네릭으로 선언
    {
        public T Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx + dy;
        }
        public T Minor(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx - dy;
        }
    }
    class Generic1
    {
        static void Main()
        {
            Calc<int> c1 = new Calc<int>();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(c1.Add(13, 21));
            Console.WriteLine(c1.Minor(x, y));

            Calc<double> c2 = new Calc<double>();
            c2.Add(3.2, 6.3);
        }
    }
}
