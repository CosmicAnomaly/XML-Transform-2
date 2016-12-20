using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Xml.Xsl;

public class MyDBUtil
{

    /**

    Author: Scott Robinson
    December 2016
    XML Final Project**/



    private static string connectString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString;
    //Method for querying the server and giving the information needed to create the XML file.
    public XmlDocument GetTeams(int minimumTitles)
    {

        SqlConnection conn = new SqlConnection(connectString);

        String sql = "Select TeamId, Name, City, Titles, RunnersUp, LastYearWon from PremiereLeagueTeam " +
            "WHERE Titles > @minTitles  ORDER BY TeamId FOR XML AUTO, ELEMENTS XSINIL, ROOT('premiereleagueteam')";
        SqlParameter titles = new SqlParameter("@minTitles", minimumTitles);
        conn.Open();
        SqlCommand cmdSelect = new SqlCommand(sql, conn);
        cmdSelect.Parameters.Add(titles);
        XmlReader xreader = cmdSelect.ExecuteXmlReader();

        XmlDocument doc = new XmlDocument();
        doc.Load(xreader);

        return doc;
    }
}