using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Client
{
    public partial class Defaut : System.Web.UI.Page
    {

        string iisBstuPath = "http://localhost:10528/kvo.kvo";
        string smwPath = "http://swm-iis-sql:8078/xxx.kvo";
        string iisPath = "http://localhost:8078/xxx.kvo";
        string appPath = "http://localhost:60707/xxx.kvo";

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(iisPath);
            request.Method = "GET";
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Response.Write(streamReader.ReadToEnd());
        }

        protected void PostButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(iisPath);
            request.Method = "POST";
            request.ContentLength = 0;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Response.Write(streamReader.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(iisPath);
            request.Method = "PUT";
            request.ContentLength = 0;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            Response.Write(streamReader.ReadToEnd());
        }
    }
}