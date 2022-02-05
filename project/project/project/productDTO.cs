using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class productDTO
    {
        private string name { get; set; }
        private int price { get; set; }

        public productDTO(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
