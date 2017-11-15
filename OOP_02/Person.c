using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
	enum gender = { male, female, other };
    class Person
    {
		
		private string name;
		private int birthYear;

		Random rand = new Random();

		public string FamilyName{
			get {return nameCorrection(name.Substring(0, name.IndexOf(" "))); }
		}
			public string GivenName{
			get { return nameCorrection(name.Substring(name.IndexOf(" ")));  }
		}
    }
}
