using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.DataModels
{
    public class Author: IEquatable<Author> 
    {
        static int counter = 0;
        public Author()
        {
            this.id = ++counter;
        }
        public Author(int id)
        {
            this.id = id;   
        }
        public int id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool Equals(Author? other)
        {
            return other?.id == this.id;
        }
    }
}
