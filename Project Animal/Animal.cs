using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animal
{
    internal record Animal
    {
        private string _gender;
        private int _birthyear;
             
        public int BirthYear
        {
            get { return _birthyear; }
            init { _birthyear = value; }
        }
        public Animal(string gender)
        {
            _birthyear = DateTime.Now.Year;
            _gender= gender;
            Console.WriteLine($"Cinsi: {_gender}");
            Console.WriteLine($"Dogum Tarixi: {_birthyear}");
        }
       
    }
}
