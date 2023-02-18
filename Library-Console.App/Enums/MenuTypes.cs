using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Console.App.Enums
{
    public enum MenuTypes: byte
    {
        AuthorAdd = 1,
        AuthorEdit,
        AuthorRemove,
        AuthorFindByName,
        AuthorGetById,
        AuthorGetAll,

        BookAdd,
        BookEdit,
        BookRemove,
        BookFindByName,
        BookGetById,
        BookGetAll
    }
}
