using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1._1.Book
{
    class BorrowedBook : Book
    {
        User reader;
        Boolean borrowedStatus;
        DateTime borrowedDateStart;
        DateTime borrowedDateEnd;
        DateTime borrowedDateRealEnd;
    }
}
