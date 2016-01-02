using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RedWolves
{
 public partial class Default : System.Web.UI.Page
        {
            protected override void OnPreRender(EventArgs e)
            {
                base.OnPreRender(e);
                JavascriptLibrary.JavascriptHelper.Include_animalpagination(Page.ClientScript);
            }
        }
    }