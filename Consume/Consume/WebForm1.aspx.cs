using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;
using System.Xml;

namespace Consume
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            MyWebService.MyWebServer MyWebserclass = new MyWebService.MyWebServer();
            double c = MyWebserclass.Add(a, b);
            Response.Write(c.ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            MyWebService.MyWebServer MyWebserclass = new MyWebService.MyWebServer();
            double c = MyWebserclass.Subtract(a, b);
            Response.Write(c.ToString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            MyWebService.MyWebServer MyWebserclass = new MyWebService.MyWebServer();
            double c = MyWebserclass.Multiply(a, b);
            Response.Write(c.ToString());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            MyWebService.MyWebServer MyWebserclass = new MyWebService.MyWebServer();
            double c = MyWebserclass.Divide(a, b);
            Response.Write(c.ToString());
        }
    }
}