using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BLL;


namespace WebApplication3
{
    public partial class add_train : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            train_bo new_data = new train_bo();
            new_data.name = TextBox1.Text;
            new_data.no = Convert.ToInt16(TextBox2.Text);

            train_bll new_bll = new train_bll();

            new_bll.adddata(new_data);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}