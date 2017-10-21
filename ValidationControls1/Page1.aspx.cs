// Page1.aspx.cs
// Processes user's details and writing a cookie to the user's machine.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cookies;

public partial class Page1 : System.Web.UI.Page
{
    //dicitionary to store user data
    private Dictionary<string, string[]> users;
                                
    // initializes the dictionary when the page inits
    protected void Page_Init(object sender, EventArgs e)
    {
        users = new Dictionary<string, string[]>();
    } // end Page_Init

    // store user info to the dictionary
    // create a cookie
    // redirect to Page2
    protected void submitButton_Click(object sender, EventArgs e)
    {
        // save user info
        String uid = id.Value;
        String[] udata = { firstname.Value, lastname.Value, dob.Value };
        users.Add(uid, udata);
                
        // create cookie using name-value pair
        HttpCookie cookie = new HttpCookie(uid, users[uid][0] + ", " + users[uid][1] + ", " + users[uid][2]);

        // add cookie to Response to place it on user's machine
        Response.Cookies.Add(cookie);
        
        // redirect
        Response.Redirect("Page2.aspx");       
    }
}
