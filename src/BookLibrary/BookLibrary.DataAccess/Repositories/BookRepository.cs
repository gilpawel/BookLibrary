using BookLibrary.DataAccess.Concrete;
using BookLibrary.DataAccess.Entities;
using BookLibrary.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(BookLibraryDataContext context)
            : base(context)
        { }
    }
}
