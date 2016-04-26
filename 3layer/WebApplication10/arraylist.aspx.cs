using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO_Layer;
using BLL_Layer;

namespace WebApplication10
{
    public partial class arraylist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            movie m=new movie();
            movieBLL mb=new movieBLL();
            arraylist list = new arraylist();
            Table t = new Table();
            list.Add(mb.ser(m));
            foreach(in list)
            {

            }
        }
    }
}