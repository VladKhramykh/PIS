using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.App_Code
{
    public class SumHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            //          POST        http://localhost:8078/sum.kvo
            //          Body->Form-Data->x = ... y = ...
            try
            {
                int x = Int32.Parse(request.Params["x"]);
                int y = Int32.Parse(request.Params["y"]);
                response.Write($"POST Handler KVO: sum = {x + y}");
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}