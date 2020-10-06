using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(10, "오렌지");
            ht[10] = "딸기";  //Hashtable은 대괄호 안에 key값을 부여 -->> key 10번 값 딸기로 변경
            ht[20] = "사과";  //Add함수를 활용하지 않고 대괄호에 key값을 넣고, value를 입력
            //ht.Add(20, "포도");   //Add함수는 대괄호와 달리 key값이 중복될 경우 오류발생
            //ht["과일"] = 100; //value와 key값이 바뀌어도 가능 -->> key와 value가 object로 인식되어 변경 가능
            Console.WriteLine(ht.Count);

            Dictionary<int, string> dic = new Dictionary<int, string>();    //제네릭방식
            dic.Add(10, "오렌지");
            dic[10] = "딸기";
            dic[20] = "자두";
            //dic["복숭아"] = 100;   //value와 key값 변경 불가능

            foreach(int elem in dic.Keys)
            {
                Console.WriteLine(dic[elem]);
            }

            foreach(KeyValuePair<int, string> elem in dic)
            {
                Console.WriteLine($"key -->> {elem.Key}\tvalue -->> {elem.Value}");
            }

            foreach (var elem in dic)   //var : 모든 데이터 타입을 가리킴
            {
                Console.WriteLine($"key -->> {elem.Key}\tvalue -->> {elem.Value}");
            }

            object objName = "고길동"; //출력 시 형변환 필요
            Console.WriteLine(objName.ToString());

            var varName = "홍길동";    //처음 입력한 데이터 타입으로만 사용
            Console.WriteLine(varName);

            dynamic dynName = "한길동";    //데이터 타입을 식별하지 않기 때문에 다른 데이터 타입으로도 변경 가능
            dynName = 10;
            Console.WriteLine(dynName);
        }
    }
}
