using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Family
    {
        List<Person> familyMembers = new List<Person>();

        public Family()
        {


        }
        public void AddFamilyMember()
        {
            Person person = new Person();
            person.setName();
            familyMembers.Add(person);
        }
        public void DisplayFamilyNames()
        {
            foreach (Person person in familyMembers)
            {
                Console.WriteLine(person.getName());
            }
        }
        public void DisplayFamilyNamesWithoutForEach()
        {
            for (int i=0; i < familyMembers.Count; i++)
            {
                Console.WriteLine(familyMembers[i].getName());
            }

        }
    }
}