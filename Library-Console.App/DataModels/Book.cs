using Library_Console.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.DataModels
{
    public class Book:IEquatable<Book>
    {
        static int counter = 0;
        public Book()
        {
            this.id = ++counter;
        }
        public Book(int id)
        {
            this.id = id;
        }
            
        public int id { get; private set; }
        public string Name { get; set; }
        public int AuthorId { get ; set; }
        public Genre Genre { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public bool Equals(Book? other)
        {
            return other?.id == this.id;
        }

        public override string ToString()
        {
            return $"{id}. Book Name: {Name}, Author ID: {AuthorId}, Genre:{Genre}, Page Count: {PageCount}, Price: {Price}";
        }
    }
}
