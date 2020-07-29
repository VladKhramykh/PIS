using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.App_Code
{
    public class PutHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string ParmA = request.Params["ParmA"];
            string ParmB = request.Params["ParmB"];

            //          PUT        http://localhost:8078/xxx.kvo
            //          Body->Form-Data->ParmA = ... ParmB = ...
            if (ParmA != null && ParmB != null)
            {
                context.Response.Write($"PUT Handler KVO: parmA={ParmA}; parmB={ParmB}");
            }
            else
            {
                response.Write("PUT Handler");
            }

        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}