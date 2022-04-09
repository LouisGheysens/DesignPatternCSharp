using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new();
            IPerson person = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(person.SayHello());
        }
    }
}
