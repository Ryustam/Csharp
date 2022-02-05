using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLastConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "my test";
            string test2 = "my" + "ldj" + "test";
            string test3 = string.Format("my{0}test{1}", "ldj",123);
            string test4 = $"my age is {34} and my name is {"이동준"}";
            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test4);

            Product p2 = new Product();

            Mobile m = new Mobile();
            m.Name = "s20";
            m.modelName = "갤럭시";
            m.buy();
            m.buy(10);
            m.Call();


            //배열이랑은 다르게, 크기가 유동적인 자료
            //자바의 ArrayList랑 동일한 것

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(-10);
            numbers.Remove(10); //값을 넣거나 빼는 것이 배열에 비해 훨신 유동적
            Console.WriteLine(numbers[0]); //각 요소에 접근 하는 건 배열이랑 동일..
            List<Product> products = new List<Product>();
            products.Add(p2);
            List<Mobile> mobiles = new List<Mobile>();
            mobiles.Add(m);
            mobiles.Clear(); //List에 있는 내용을 싹 다 지움.

            //C#에서의 ArrayList는 뭐든지 저장함
            ArrayList myList = new ArrayList();
            myList.Add(m);
            myList.Add(10);

            Console.WriteLine(myList[1]);

        }
    }
}
