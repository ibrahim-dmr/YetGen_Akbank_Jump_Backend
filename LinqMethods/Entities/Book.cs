    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqMethods.Enums;

namespace LinqMethods.Entities
{
    public class Book
    {
     

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, string author, string iSBN, DateTime publicationDate, Genre genre)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationDate = publicationDate;
            Genre = genre;
        }
    }
}
