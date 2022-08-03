using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
   public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Favorit { get; set; }
        public Gender Gender { get; set; }
        public string PhotoUrl { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
