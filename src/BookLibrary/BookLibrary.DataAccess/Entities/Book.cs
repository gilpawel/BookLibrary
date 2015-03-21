using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Count { get; set; }
        public int BookGenreId { get; set; }
    }
}
