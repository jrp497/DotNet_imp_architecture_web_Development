using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BO;
using System.Data;

namespace WebApplication3
{
    public partial class ui : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            train_bll trbl = new train_bll();
            train_bo trbo = new train_bo();
            //trbo.no =Convert.ToInt16 (TextBox2.Text);
            trbo.name = (TextBox1.Text);


            DataTable dm = trbl.searchtrains(trbo);
            GridView1.DataSource = dm;
            GridView1.DataBind();
        }
    }
}