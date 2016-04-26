using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data;
using DAL;


namespace BLL
{

    public class train_bll
    {
        public int adddata(train_bo obj2)
        {

            train_dal data = new train_dal();
            data.inserttrain(obj2);
            return 0;
        }



        public DataTable searchtrains(train_bo tbl)
        {
            train_dal trdat = new train_dal();
            return trdat.showtrains(tbl);
        }

        public int deltrain(train_bo dt)
        {
            train_dal detra = new train_dal();
            return detra.delete(dt);
        }

    }
}
