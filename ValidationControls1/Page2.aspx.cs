// Page2.aspx.cs
// Verifies user's id and displays their name if there is a respective cookie

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cookies;

namespace Cookies
{
    public partial class Page2 : System.Web.UI.Page
    {
        // create collection of cookies
        HttpCookieCollection cookies;

        public void Page_Load(object sender, EventArgs e)
        {
            // retrieve client's cookies
            cookies = Request.Cookies;
        }

        // verify is there is a cookie for a user with entered ID
        protected void submitButton_Click(object sender, EventArgs e)
        {
            String uid = id.Value;
            bool foundCookie = false;

            if (cookies.Count > 0)
            {
                for (int i = 0; i < cookies.Count; i++)
                {
                    if (cookies[i].Name == uid)
                    {
                        Label1.Text = "Cookie found! User ID: " + uid + ", User details: " + cookies[i].Value;
                        foundCookie = true;
                    }
                }
            }
            else
            {
                Label1.Text = "There are no cookies";
            }

            if (!foundCookie)
            {
                Response.Redirect("Page1.aspx");
            }
        }
    }
}