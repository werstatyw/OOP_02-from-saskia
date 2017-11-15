using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    enum Gender { male, female, other}; //always outside the class, like a constant: also usable in Main(Program)
class PersonB
    {
        private string name;
        private int birthYear;
        Gender g;

        static Random rand = new Random();

        public string FamilyName
        {
            get { return nameCorrection(name.Substring(0, name.IndexOf(" "))); }
        }
        public string GivenName
        {
            get { return nameCorrection(name.Substring(name.IndexOf(" ")).Trim()); }
        }
        static string nameCorrection(string s)
        {
        return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }
        public int BirthYear
        {
            get { return birthYear; }
        }
        public Gender G
        {
            get { return g; }
        }
        public PersonB(string name, Gender g)
        {
            this.name = name.Trim();
            this.g = g;
            birthYear = rand.Next(1950, 2007);
        }
        public string print()
        {
            return "\n Person: Given name= *" + GivenName + "*, Family name= *" + FamilyName +
                "*, Birth year= *" + BirthYear + "*, Gender= *" + g + "*";

        }
    }
}
