using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7.Models;

namespace lab7.Models
{
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurun", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Nazin", Author = "Sequiter", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 4, Title = "Elwqit", Author = "Tefgmpor", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 5, Title = "Eleqit", Author = "Tempor", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 6, Title = "Elqeit", Author = "Tempdgor", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 9, Title = "Elqgdeit", Author = "Tempor", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 10, Title = "Elit", Author = "Tempordg", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookId = 11, Title = "Elqeit", Author = "Tempador", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookId = 12, Title = "Elqeit", Author = "sdTempor", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookId = 13, Title = "Elit", Author = "adTempor", CoverImage = "Assets/13.png" });

            return books;
        }
    }
}
