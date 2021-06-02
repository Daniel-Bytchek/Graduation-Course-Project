using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1._1.Book
{
    interface IBook
    {
        void setName(String Name);
        String getName();
        void setGenre(String Genre);
        String getGenre();
        void setAuthor(String Author);
        String getAuthor();
        void setLanguage(String Language);
        String getLanguage();
        void setPublisher(String Publisher);
        String getPublisher();
        void setPages(int Pages);
        int getPages();
        void setYear(int Year);
        int getYear();
        void setPrice(double Price);
        double getPrice();
    }
}
