using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonList list = new PersonList();

            Adress firstAdress = new Adress("Ukraine", "Kherson", "Pokrisheva", 45);
            Adress secondAdress = new Adress("Ukraine", "Kiyv", "Beregova", 6);
            
            Person firstPerson = new Person();
            Person secondPerson = new Person("Yurii", "Yezelevich", 18, firstAdress);
            Person thirdPerson = new Person("Maxim", "Shevchenko", 21, secondAdress);

            list.add(firstPerson);
            list.add(secondPerson);
            list.add(thirdPerson);

            list.printAll();
        }
    }
}
