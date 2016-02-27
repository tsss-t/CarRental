using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFpart.SOA.Function;
using System.Web.Security;

namespace WCFpart
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderSummery o = new OrderSummery();
            Response.Write( o.Delete_OverTime(1));
        }
    }
}