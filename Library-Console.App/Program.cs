using Library_Console.App.DataModels;
using Library_Console.App.Enums;
using Library_Console.App.Helpers;
using Library_Console.App.Manager;
using System;
using System.Data;
using System.Transactions;

namespace Library_Console.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BookManager bookManager = new BookManager();
            AuthorManager authorManager = new AuthorManager();
            Book book;
            Author author;
            int id;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Library!");


            Console.ForegroundColor = ConsoleColor.White;
            var selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");


            label1: switch (selectmenu)
            {
                case MenuTypes.AuthorAdd:
                    author = new Author();
                    author.Name = Helper.ReadString("Author name: ");
                    author.Surname = Helper.ReadString("Author Surname: ");
                    authorManager.Add(author);
                    Console.Clear();
                    selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");
                    goto label1;
                case MenuTypes.AuthorEdit:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Choose the Author you want to edit: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var item in authorManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Choose the author ID from the list: ");
                    if (id == 0)
                    {
                        
                        selectmenu = Helper.ReadMenu<MenuTypes>("Select menu: ");
                        goto label1;
                    }
                    author =authorManager.GetById(id);

                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.AuthorEdit;
                    }
                    author.Name = Helper.ReadString("Change the author name: ");
                    author.Surname = Helper.ReadString("Change the author surname: ");
                    Console.Clear();
                    goto case MenuTypes.AuthorGetAll;
                case MenuTypes.AuthorRemove:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Choose the Author you want to remove: ");
                    Console.ForegroundColor = ConsoleColor.White;   
                    foreach (var item in authorManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Choose the author ID: ");
                    author = authorManager.GetById(id);
                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.AuthorRemove;
                    }
                    authorManager.Remove(author);
                    Console.Clear();
                    goto case MenuTypes.AuthorGetAll;

                    foreach (var item in authorManager)
                    {
                        Console.WriteLine(item);
                    }
                    selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");
                    goto label1;

                case MenuTypes.AuthorFindByName:
                    string name = Helper.ReadString("Enter the Author initial letters to search: ");
                    var data = authorManager.FindByName(name);
                    if (data.Length == 0)
                    {
                        Console.WriteLine("Couldn't find");
                    }

                    Console.Clear();

                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }

                    selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");

                    goto label1;
                    
                case MenuTypes.AuthorGetById:
                    foreach(var item in authorManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.Readint("Choose ID: ");

                    if (id == 0)
                    {
                        selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");
                        goto label1;
                    }
                    author = authorManager.GetById(id);
                    if (author == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Couldn't find");
                        goto case MenuTypes.AuthorGetById;
                    }
                    Console.Clear();
                    Console.WriteLine(author);
                    selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");
                    break;
                case MenuTypes.AuthorGetAll:
                    Console.Clear();
                    foreach (var item in authorManager)
                    {
                        Console.WriteLine(item);
                    }

                    selectmenu = Helper.ReadMenu<MenuTypes>("Select Menu: ");

                    goto label1;
                    
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

            //string sentence = "Good Luck! ";


            //while (true)
            //{
            //    char first = sentence[0];
            //    string second = sentence.Substring(1);
            //    sentence = second + first;
            //    Console.Clear();
            //    Console.WriteLine(sentence);

            //    if (sentence.Substring(0, 7) == "Welcome")
            //    {
            //        Thread.Sleep(4000);
            //    }
            //    else Thread.Sleep(300);

            //}

        }
    }
}