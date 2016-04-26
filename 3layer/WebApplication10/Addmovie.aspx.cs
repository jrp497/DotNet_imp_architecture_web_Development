using System;
using System.Collections.Generic;
//using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO_Layer;
using BLL_Layer;
using System.Data;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        movie m = new movie();
        movieBLL mb = new movieBLL();
        //double r;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            m.name = TextBox1.Text;
            m.budget = Convert.ToDouble(TextBox2.Text);
            mb.share(m);
            //int r = Convert.ToInt16(mb.share(m));
            //if (r > 0)
            //    Label3.Text = "record added successfully";
            //else
            //    Label3.Text = "sorry";


            //if (DropDownList1.Text == "50")
            //{
            //    r = Convert.ToDouble(DropDownList1.Text);
            //    m.share = r;
            //    mb.share(m);
            //}

            //else if (DropDownList1.Text == "100")
            //{
            //    r = Convert.ToDouble(DropDownList1.Text);
            //    m.share = r;
            //    mb.share(m);
            //}
            //else
            //{
            //    r = Convert.ToDouble(DropDownList1.Text);
            //    m.share = r;
            //    mb.share(m);
            //}

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            m.movname = TextBox3.Text;
            DataTable dat = mb.ser(m);
            GridView1.DataSource = dat;
            GridView1.DataBind();
            int result = GridView1.Rows.Count;
            if (result > 0)
                Label3.Text = "Record found";
            else
                Label3.Text = "Record not found";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            m.id = Convert.ToInt16(TextBox4.Text);
            int r = Convert.ToInt16(mb.delete(m));
            if (r > 0)
               Label3.Text = "record deleted successfully";
            else
             Label3.Text = "record not found";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            m.id = Convert.ToInt16(TextBox5.Text);
            m.name = TextBox1.Text;
            int r = Convert.ToInt16(mb.upd(m));
            if (r > 0)
                Label3.Text = "record updated successfully";
            else
                Label3.Text = "record not found";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            m.id = Convert.ToInt16(TextBox6.Text);
            m.sharepart = Convert.ToDouble(TextBox7.Text);
            int r = Convert.ToInt16(mb.sp(m));
            if (r > 0)
                Label3.Text = "share part updated successfully";
            else
                Label3.Text = "record not found";
        }
    }
}