using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap11
{
    class Movie
    {
        //private variables
        private string name;
        private string catagory;

        //properties
        public string Name
        { get; set;}
        public string Catagory
        { get; set; }

        // constructor
        public Movie()
        {
            
        }

        //
        public Movie(string Catagories,string Titles)
        {
            Catagory = Catagories;
            Name = Titles;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }






    }
}
