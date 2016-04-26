using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO_Layer;
using DAL_Layer;
using System.Data;

namespace BLL_Layer
{
    public class movieBLL
    {
        movieDAL md = new movieDAL();
        public void share( movie mov)
        {
            if (mov.budget <= 10000000)
                mov.share = mov.budget / 3;
            else
                mov.share = mov.budget / 2;
                md.insertmovie(mov);
        }
        public DataTable ser(movie mov)
        {
            return md.search(mov);
        }
        public int delete(movie mov)
        {
            return md.del(mov);
        }
        public int upd(movie mov)
        {
           
            return md.update(mov);
        }
        public int sp(movie mov)
        {

            return md.procedure(mov);
        }
    }

}
