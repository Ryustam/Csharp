using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class loginDTO
    {
		private string ID { get; set; }
		private string PW { get; set; }

		private string name { get; set; }	

		public loginDTO() { }

		public loginDTO(string ID, string PW, string name)
		{
			this.ID = ID;
			this.PW = PW;
			this.name = name;
		}

		public string getID()
		{
			return this.ID;
		}

		public string getPW()
		{
			return this.PW;
		}

		public string getName()
        {
			return this.name;
        }

	}
}
