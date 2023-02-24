using Library_Console.App.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.DataModels
{
    public class Author: IEquatable<Author> 
    {
        static int counter = 0;
        static int authorCount = 0;
        public Author()
        {
            counter++;
            this.Id =counter;
            authorCount++;
        }
        public Author(int id)
        {
            this.Id = id;   
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool Equals(Author? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"{Id}. Author Name: {Name}, Author Surname: {Surname}";
        }

        public static int GetAuthorCount()
        {
            return authorCount;
        }

    }
}
