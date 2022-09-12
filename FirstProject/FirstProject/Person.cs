using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        private Adress adress;

        public Person()
        {
            this.name = "None";
            this.surname = "None";
            this.age = 0;
            this.adress = new Adress();
        }
        public Person(string name, string surname, int age, Adress adress)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.adress = adress;
        }
        public string toStr()
        {
            return "Name: " + this.name +
                "\nSurname: " + this.surname +
                "\nAge: " + this.age.ToString() +
                "\nAdress: " + this.adress.toStr();
        }
        public void printInfo()
        {
            string info =
                "Name: " + this.name +
                "\nSurname: " + this.surname +
                "\nAge: " + this.age.ToString() +
                "\nAdress: " + this.adress.toStr();
            Console.WriteLine(info);
        }
    }
}
