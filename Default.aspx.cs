using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;
using System.Xml.Xsl;
/** Author: Scott Robinson
 * December 2016
 * XML Final Project
 * Ideally this would be utilized to house a multitude of leagues from different teams. Different templates could be used depending on the league. 
It would have been nice to dynamically select leagues and have it show this information, but I wasn't able to determine how to accomplish that.*/
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Method for the button that is clicked and creates the XML file, and displays the raw XML data.
    protected void btnGo_Click(object sender, EventArgs e)
    {
        MyDBUtil dbUtil = new MyDBUtil();
        XmlDocument PremTeams = dbUtil.GetTeams(0);

        PremTeams.Save(Server.MapPath(@"App_Data\PremTeams1.xml"));

        TextBox1.Text = PremTeams.OuterXml;  // display raw xml data
    }
}
