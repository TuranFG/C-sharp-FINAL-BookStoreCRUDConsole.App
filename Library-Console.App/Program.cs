using Library_Console.App.DataModels;
using Library_Console.App.Enums;
using Library_Console.App.Helpers;
using Library_Console.App.Manager;

namespace Library_Console.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BookManager bookManager = new BookManager();
            AuthorManager authorManager = new AuthorManager();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Library!");


            Console.ForegroundColor = ConsoleColor.White;
            var selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");


            switch (selectmenu)
            {
                case MenuTypes.AuthorAdd:
                    break;
                case MenuTypes.AuthorEdit:
                    break;
                case MenuTypes.AuthorRemove:
                    break;
                case MenuTypes.AuthorFindByName:
                    break;
                case MenuTypes.AuthorGetById:
                    break;
                case MenuTypes.AuthorGetAll:
                    break;
                case MenuTypes.BookAdd:
                    break;
                case MenuTypes.BookEdit:
                    break;
                case MenuTypes.BookRemove:
                    break;
                case MenuTypes.BookFindByName:
                    break;
                case MenuTypes.BookGetById:
                    break;
                case MenuTypes.BookGetAll:
                    break;
                default:
                    break;
            }

        }
    }
}