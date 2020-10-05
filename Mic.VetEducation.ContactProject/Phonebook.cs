using System;
using System.Collections.Generic;

namespace Mic.VetEducation.ContactProject
{
    class Phonebook
    {
        public Dictionary<string, int> ContactList = new Dictionary<string, int>();      

        public void addInfo(string name, int number)
        {
            try
            {
                ContactList.Add(name, number);
            }
            catch (Exception)
            {
                Console.WriteLine($"The name | {name} | has already been added to the phonebook.");
            }
        }     

        public void addMemberNumber(string name)
        {
            try
            {
                Console.WriteLine($"{name} : 0{ContactList[name]}");
            }
            catch (Exception)
            {
                Console.WriteLine($"None of the phonebook members has a name like | {name} |");
            }
        }

        public void deleteMember(string name)
        {
            ContactList.Remove(name);
        }

        public void printMembersList()
        {
            foreach (var Member in ContactList)
            {
                Console.WriteLine($"{Member.Key} : 0{Member.Value}");
            }
        }
    }
}
