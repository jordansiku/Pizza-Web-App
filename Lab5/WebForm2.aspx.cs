using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(" Name Surname "+Session["name"]);
            ListBox1.Items.Add(" Pizza Type " + Session["pizza"]);
            ListBox1.Items.Add(" Pizza size " + Session["size"]);
            ListBox1.Items.Add(" Extras " + Session["extras"]);
            ListBox1.Items.Add(" Drink " + Session["drink"]);
            ListBox1.Items.Add(" Price " + Session["price"]);

        }
    }
}