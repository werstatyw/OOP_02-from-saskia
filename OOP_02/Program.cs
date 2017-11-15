using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Vector in (x,y) format: ");
            string s = Console.ReadLine();
            Vector v1 = Vector.Parse(s);
            Console.WriteLine(v1.print());*/

            //Persons
            int numberPersons = 3;
            int ageDiff = 5;
            Console.WriteLine("\nTask1: generate data");
            PersonB[] p = new PersonB[numberPersons];
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("Name of person " + i + ": ");
                string s1 = Console.ReadLine();
                Console.Write(" Gender of person " + i + "(m/f): ");
                string s2 = Console.ReadLine();
                if(s2[0] == 'f')
                {
                    p[i] = new PersonB(s1, Gender.female);
                }
                else
                {
                    p[i] = new PersonB(s1, Gender.male);
                }
            }
            for(int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i].print());
            }

            //user stuff
            string name = "Müller angie";
            Gender gx = Gender.female;
            PersonB user = new PersonB(name, gx);

            Console.WriteLine("\nTask2: person with same given or family name as user, user: "+user.print());
            
            int size = sameName(p, user);
            if(size > 0)
            {
                Console.WriteLine("There are persons wit same family or given name, " + size + " persons");
                PersonB[] matches = new PersonB[size];
                safeToArray(p, matches, user);
                for (int j = 0; j < matches.Length; j++)
                {
                    Console.WriteLine(matches[j].print());
                }
            }
            //
            Console.WriteLine("\nTask3: persons with opposite gender than user (" + user.G + ")");
            int count = countOppGender(p, user);
            if(count > 0)
            {
                PersonB[] genderOpps = new PersonB[count];
                safeOppGender(p, genderOpps, user);
                Console.WriteLine("There are " + genderOpps.Length + " persons of the opposite gender");
                for (int i = 0; i < genderOpps.Length; i++)
                {
                    Console.WriteLine(genderOpps[i].print());
                }
            }
            
           
           
            
            Console.Read();
        }
        static void safeOppGender(PersonB[] p, PersonB[] genderOpps, PersonB user)
        {
            int pos = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].G != user.G)
                {
                    genderOpps[pos] = p[i];
                    pos++;
                }
            }
        }
        static int countOppGender(PersonB[] p, PersonB user)
        {
            int count = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].G != user.G)
                {
                    count++;
                }
            }
            return count;
        }
        static void safeToArray(PersonB[] p, PersonB[] matches, PersonB user)
        {
            int index = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].FamilyName == user.FamilyName || p[i].GivenName == user.GivenName)
                {
                    matches[index] = p[i];
                    index++;
                }
            }
        }
        static int sameName(PersonB[] p, PersonB user)
        {
            int index = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].FamilyName == user.FamilyName || p[i].GivenName == user.GivenName)
                {
                    index++;
                }
            }
            return index;
        }
    }
}
