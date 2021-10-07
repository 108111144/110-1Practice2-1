using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double d_Value = -1;
            d_Value = 66;
            double d_C = -1;
            d_C = (d_Value - 32) * 5 / 9;
            Response.Write("d_Value =" + d_Value.ToString() + "F = " + d_C.ToString() + "C");
        }
    }
}