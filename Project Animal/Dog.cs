using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animal
{
    internal record Dog : Animal
    {
        private string _breed;
        public string _name;


        public string Breed
        {
            get
            {
                return _breed;
            }
            init { _breed = value; }
        }
        public Dog(string breed, string name,string gender) : base(gender)
        {
            Breed = breed;
            _name = name;

            Console.WriteLine($"Adi: {name}");
            Console.WriteLine($"Novu: {breed}");


        }
    }
}
