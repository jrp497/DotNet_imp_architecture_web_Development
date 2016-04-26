using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BO;

namespace WebApplication3
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            train_bll delt = new train_bll();
            train_bo deltbo = new train_bo();

            //deltbo.no =Convert.ToInt16(TextBox1.Text);

            deltbo.name= (TextBox1.Text);
            
            int r=delt.deltrain(deltbo);

            if (r > 0)
                Label2.Text = "success";
            else

                Label2.Text = "data not found";

        }
    }
}