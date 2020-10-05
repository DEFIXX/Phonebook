using System;
using System.Collections.Generic;

namespace Mic.VetEducation.ContactProject
{
    class Program : Phonebook
    {
        static void Main(string[] args)
        {
            var ContactList = new Phonebook();

            ContactList.addInfo("Arame", 95443322);
            ContactList.addInfo("Aram", 55123212);
            ContactList.addInfo("Hayk", 43536353);
            ContactList.addInfo("Suren", 41567676);
            ContactList.addInfo("Gayane", 33909631);
            ContactList.addInfo("Narine", 98233353);
            ContactList.addInfo("Karine", 99877887);
            ContactList.addInfo("Artyom", 44745446);
            ContactList.addInfo("Karine", 95679756);
            Console.Write("\n");

            ContactList.addMemberNumber("Karine");
            ContactList.addMemberNumber("Test name!");
            Console.WriteLine();

            Console.WriteLine("Old List");
            ContactList.printMembersList();
            Console.WriteLine();

            ContactList.deleteMember("Arame");
            ContactList.deleteMember("Narine");
            ContactList.deleteMember("Test name!");

            Console.WriteLine("------------------------\n");

            Console.WriteLine("New Members");
            ContactList.printMembersList();

            Console.WriteLine("\n------------------------");
        }
    }
}
