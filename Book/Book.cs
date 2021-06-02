using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1._1.Book
{
    class Book : IBook
    {
        String Name;
        String Genre;
        String Author;
        String Language;
        String Publisher;
        int Pages;
        int Year;
        double Price;
        int id;

        public string getAuthor()
        {
            return this.Author;
        }

        public string getGenre()
        {
            return this.Genre;
        }

        public string getLanguage()
        {
            return this.Language;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getPages()
        {
            return this.Pages;
        }

        public double getPrice()
        {
            return this.Price;
        }

        public string getPublisher()
        {
            return this.Publisher;
        }

        public int getYear()
        {
            return this.Year;
        }

        public void setAuthor(string Author)
        {
            this.Author = Author;
        }

        public void setGenre(string Genre)
        {
            this.Genre = Genre;
        }

        public void setLanguage(string Language)
        {
            this.Language = Language;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public void setPages(int Pages)
        {
            this.Pages = Pages;
        }

        public void setPrice(double Price)
        {
            this.Price = Price;
        }

        public void setPublisher(string Publisher)
        {
            this.Publisher = Publisher;
        }

        public void setYear(int Year)
        {
            this.Year = Year;
        }
    }
}
