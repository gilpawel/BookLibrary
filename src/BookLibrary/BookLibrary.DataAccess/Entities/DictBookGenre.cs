using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Entities
{
    public class DictBookGenre
    {
        [Key]
        public int BookGenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public DictBookGenre()
        {
            Books = new HashSet<Book>();
        }
    }
}
