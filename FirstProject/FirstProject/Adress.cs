using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Adress
    {
        private string country;
        private string city;
        private string street;
        private int number;

        public Adress()
        {
            this.country = "None";
            this.city = "None";
            this.street = "None";
            this.number = 0;
        }
        public Adress(string country, string city, string street, int number)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
        }
        public string toStr()
        {
            return "Country: " + this.country +
                "\nCity: " + this.city +
                "\nStreet: " + this.street +
                "\nNumber: " + this.number.ToString();
        }
        public void printInfo()
        {
            string info = 
                "Country: " + this.country +
                "\nCity: " + this.city +
                "\nStreet: " + this.street +
                "\nNumber: " + this.number.ToString();
            Console.WriteLine(info);
        }
    }
}
