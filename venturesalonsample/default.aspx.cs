using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venturesalonsample
{
    public partial class _default : System.Web.UI.Page
    {
        string userAgent = "";
        string BrowserURL = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            userAgent = Request.Browser.Capabilities[""].ToString();
            BrowserURL = Request.Url.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                System.Net.HttpWebRequest webreq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(BrowserURL);
                webreq.UserAgent = userAgent;
                System.Net.HttpWebResponse webres = (System.Net.HttpWebResponse)webreq.GetResponse();
                webres.Close();
            }
        }
    }
}