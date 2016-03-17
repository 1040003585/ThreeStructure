using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using Models;

namespace TestOne3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        ColorManager bll = new ColorManager();
        Color color = new Color();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            color.Bm = TextBox1.Text;
            color.Mc = TextBox2.Text;
            bll.add(color);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bll.delete(TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            color.Bm = TextBox1.Text;
            color.Mc = TextBox2.Text;
            bll.change(color);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<Color> colors = bll.selectAll();
            foreach (Color color in colors)
            {
                Response.Write(color.Bm + " " + color.Mc+"<br>");
            }
        }
    }
}