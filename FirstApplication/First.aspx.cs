using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApplication
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Welcome " + TextBox1.Text + " " + "Your password is " + TextBox2.Text);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome "+TextBox1.Text + " " + "Your password is " + TextBox2.Text);
            Response.Write(DropDownList1.SelectedItem.ToString());
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedItem.ToString());
        }
    }
}