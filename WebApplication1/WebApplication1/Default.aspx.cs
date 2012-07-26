using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        private int count = 0;
        public int result(string a)
        {
            if (a != "")
            {
                count = 3;
            }
            else
            {
                count = 10;
            }
            return count;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
