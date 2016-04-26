using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO_Layer;
using DAL_Layer;

namespace BLL_Layer
{
    public class BookBLL
    {
        BookDAL Dobj = new BookDAL();
        public int AddBook(Book b)
        {
            int res;
            if (b.rating <= 3)
            {
                b.fine = b.cost * 2;

            }
            else
            {
                b.fine = b.cost * 5;
            }

            res = Dobj.insertBook(b);
            return res;
        }
    }
}
