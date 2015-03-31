using BookLibrary.DataAccess.Concrete;
using BookLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Repositories
{
    public class BookGenreRepository : Repository<DictBookGenre>
    {
        public BookGenreRepository(BookLibraryDataContext context)
            : base(context)
        { }
    }
}
