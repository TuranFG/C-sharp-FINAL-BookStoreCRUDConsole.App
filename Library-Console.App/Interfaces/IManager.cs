using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.Interfaces
{
    public interface IManager<T>
    {
        void Add(T item);
        void Remove(T item);
        void Edit (T item); 
        T GetById(int id);
        T []FindByName(string name);
      

    }
}
