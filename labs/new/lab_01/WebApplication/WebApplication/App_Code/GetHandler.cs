using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.App_Code
{
    public class GetHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string ParmA = request.Params["ParmA"];
            string ParmB = request.Params["ParmB"];

//          GET        http://localhost:8078/xxx.kvo?ParmA=4&ParmB=5
            if (ParmA != null && ParmB != null)
            {
                response.Write($"GET Handler KVO: parmA={ParmA}; parmB={ParmB}");
            }
            else
            {
                response.Write("Get Handler");
            }
                      
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}