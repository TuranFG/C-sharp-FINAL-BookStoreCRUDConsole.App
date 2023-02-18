using Library_Console.App.DataModels;
using Library_Console.App.Manager;

namespace Library_Console.App
{
    internal class Program
    {
        static void Main(string[] args)
        {   BookManager bookManager = new BookManager();
            Book book1 = new Book();
            book1.Name = Console.ReadLine();
            book1.Price = 100;
            bookManager.Add(book1);

            Book book2 = new Book();
            book2.Name = "Yoga";
            book2.PageCount = 10;

            Book book3 = new Book();
            book3.Name = "Sarah";
            bookManager.Add(book2);
            bookManager.Add(book3);

            foreach (var item in bookManager)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}