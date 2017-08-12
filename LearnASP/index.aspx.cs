using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASP
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(txt_name.Text, int.Parse(txt_age.Text));
            Response.Write("Hello " + cus.Name + ",you're " + cus.Age + "years");

        }
    }
}