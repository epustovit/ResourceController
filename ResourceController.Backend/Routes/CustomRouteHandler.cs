using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ResourceController.Backend.Routes
{
    public class CustomRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
             return new MyClassHttpHandler(requestContext);
        }
    }

    public class MyClassHttpHandler : IHttpHandler
    {
        public RequestContext RequestContext
        {
            get;

            set;
        }

        public MyClassHttpHandler(RequestContext requestContext)
        {
            this.RequestContext = requestContext;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Redirect("http://www.itfunda.com", true);
        }
    }
}