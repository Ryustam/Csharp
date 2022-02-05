using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_data_gridview
{
    internal class Drug
    {
        public string Name { get; set; }
        
        private string Id;

        public string DrugId { get => Id; set=> Id = value; }  //람다식. 함수를 더 간소화 시킨것

        private string Comp;

        public string DrugComp { get { return Comp;} set { Comp = value; } }

        public Drug(string name, string id, string comp)
        {
            Name = name;
            Id = id;
            Comp = comp;    
        }
    }
}
