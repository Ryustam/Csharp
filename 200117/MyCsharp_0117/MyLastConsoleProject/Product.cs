using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLastConsoleProject
{
    //Product: 사용자가 직접 정의한 자료형
    //int , string 과는 다르게 하나의 변수가 1가지 '이상'의 값을 가질 수 있음
    //예를 들어서 Product라면 제품명, 가격 등의 속성을 가질 수 있다.
    internal class Product
    {
        public string Name;
        public int Price;

        private int Product_code; // 제품 고유 코드
        public int get_Product_code()
        {
            return Product_code;
        }

        public void set_Product_code(int pcode)
        {
            this.Product_code= pcode;
        }

        public string StoreName { get; set; } //getter와 setter를 축약한 형태1

        private int amt;
        public int amount { get { return amt; } set { amt = value; } }  //축약형태2

        //제품을 만들긴 했는데, 그 제품이 뭔지도 모를때

        public Product() { }


        //제품을 만듦과 동시에 뭔지 알 때
        public Product(string name, int price, int product_code, string storeName, int amt, int amount)
        {
            Name = name;
            Price = price;
            Product_code = product_code;
            StoreName = storeName;
            this.amt = amt;
            this.amount = amount;
        }
        //오버로딩 : 함수랑 생성자한테 동일하게 적용되는 개념
        //이름은 똑같은 데 괄호 안에 내용이 다르면 (변수의 타입이나 변수의 개수)
        //서로 다른 함수(or 생성자)로 간주하는 것!

        public void buy (int a)
        {
            Console.WriteLine(a+"개 구매하셨습니다.");
        }

        public void buy()
        {
            Console.WriteLine("구매를 시작하려고 합니다.");
        }

    }
}
