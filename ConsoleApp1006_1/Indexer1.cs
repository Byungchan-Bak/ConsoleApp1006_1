using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1006_1
{
    class IntegerText
    {
        char[] txtnumber;

        public char this[int idx]   //인덱서는 무조건 this로 메서드 생성, 대괄호 안에 매개변수, get; set; 구조
        {
            get { return txtnumber[txtnumber.Length - (idx + 1)]; }
            set { txtnumber[txtnumber.Length - (idx + 1)] = value; }
        }

        public IntegerText(int number)
        {
            this.txtnumber = number.ToString().ToCharArray();   //매개변수를 문자로 바꿔 배열에 저장
        }

        public char GetPointNumber(int point)
        {
            return txtnumber[txtnumber.Length - (point + 1)];
        }
    }

        class Indexer1
    {   
        
        static void Main()
        {
            IntegerText c1 = new IntegerText(123456);

            int step = 1;
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{step}의 자릿수" + c1.GetPointNumber(i));
                Console.WriteLine($"{step}의 자릿수" + c1[i].ToString());  //인덱서 활용
                step *= 10;
            }
        }
    }
}
