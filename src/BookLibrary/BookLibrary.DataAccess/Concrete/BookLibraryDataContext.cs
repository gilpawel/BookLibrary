using BookLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Concrete
{
    ///http://www.entityframeworktutorial.net/code-first/entity-framework-code-first.aspx

    public class BookLibraryDataContext : System.Data.Entity.DbContext
    {
        public BookLibraryDataContext()
            : base()
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<DictBookGenre> BookGenres { get; set; }
    }
}
