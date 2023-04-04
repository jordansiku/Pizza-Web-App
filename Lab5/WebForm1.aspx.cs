using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["pizza"] = DropDownList1.SelectedItem;
            Session["Size"] = RadioButtonList1.SelectedItem;
            Session["extras"] = CheckBoxList1.SelectedItem;
            Session["drink"] = RadioButtonList2.SelectedItem;

            int price=0;

            if (RadioButtonList1.SelectedValue == "small")
            {
                price = 10;
            }
             if ((RadioButtonList1.SelectedValue == "small")&& (RadioButtonList2.SelectedValue=="Yes"))
            {
                price = 15;
            }
             if (RadioButtonList1.SelectedValue == "medium")
            {
                price = 20;
            }
             if ((RadioButtonList1.SelectedValue == "medium") && (RadioButtonList2.SelectedValue == "Yes"))
            {
                price = 25;
            }
             if (RadioButtonList1.SelectedValue == "large")
            {
                price = 30;
               // Int32.Parse(RadioButtonList1.SelectedValue);
            }
             if ((RadioButtonList1.SelectedValue == "large") && (RadioButtonList2.SelectedValue == "Yes"))
            {
                price = 35;
            }

            Session["price"] = price.ToString();

            Response.Redirect("WebForm2.aspx");
        }
    }
}