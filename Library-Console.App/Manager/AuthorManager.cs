using Library_Console.App.DataModels;
using Library_Console.App.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.Manager
{
    public class AuthorManager : IManager<Author>, IEnumerable<Author>
    {
        Author[] data=new Author[0];
        public void Add(Author item)
        {
            int lenght = data.Length;
            Array.Resize(ref data, lenght + 1);
            data[lenght] = item;
        }

        public void Edit(Author item)
        {
            var index = Array.IndexOf(data, item);
            if (index == -1)
                return;
            var found = data[index];
            
            found.Name = item.Name;
            found.Surname = item.Surname;
            
        }

        public void Remove(Author item)
        {
            int index = Array.IndexOf(data, item);
            if (index == -1)
                return;
            int lenght = data.Length;
            for (int i = index; i < lenght - 1; i++)
            {
                data[i] = data[i + 1];
                Array.Resize(ref data, lenght - 1);
            }
        }
        public Author this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public IEnumerator<Author> GetEnumerator()
        {
            foreach(var item in data) yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();    
        }
    }
}
