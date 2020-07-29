using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.App_Code
{
    public class PostHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string ParmA = request.Params["ParmA"];
            string ParmB = request.Params["ParmB"];

//          POST        http://localhost:8078/xxx.kvo
//          Body->Form-Data->ParmA = ... ParmB = ...
            if (ParmA != null && ParmB != null)
            {
                context.Response.Write($"POST Handler KVO: parmA={ParmA}; parmB={ParmB}");
            }
            else
            {
                response.Write("Post Handler"); ;
            }
       
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}