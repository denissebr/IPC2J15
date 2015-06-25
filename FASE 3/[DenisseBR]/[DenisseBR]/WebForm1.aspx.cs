using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _DenisseBR_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = true;
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible=true;

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel1.Visible = false;
        }

        protected void cot_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = true;
        }
    }
}