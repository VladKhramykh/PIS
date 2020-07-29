using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.App_Code
{
    public class LastTaskHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string ParmA = request.Params["x"];
            string ParmB = request.Params["y"];

            //          POST        http://localhost:8078/xxx.kvo
            //          Body->Form-Data->ParmA = ... ParmB = ...
            if (request.HttpMethod == "POST")
            {
                context.Response.Write($"LastTask Handler KVO: parmA={ParmA}; parmB={ParmB}");
            }
            else if(request.HttpMethod == "GET")                
            {
                response.Redirect("index.html"); ;
            }

        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}