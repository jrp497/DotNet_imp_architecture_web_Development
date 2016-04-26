using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO_Layer;
using BLL_Layer;

namespace UI_Layer
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Book Bobj = new Book();
            BookBLL BLLObj = new BookBLL();
            Bobj.name = TextBox1.Text;
            Bobj.cost = Convert.ToDouble(TextBox2.Text);
            Bobj.rating = Convert.ToInt16(TextBox3.Text);

            int r = BLLObj.AddBook(Bobj);
            if (r > 0)
                Label4.Text = "Record has been successfully added with ID"+r;
            else
                Label4.Text = " Addition Unsuccessful.  Sorry";
        }
    }
}