using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

/// <summary>
/// Summary description for RedirectHandler
/// </summary>
public class RedirectRouteHandler : IRouteHandler
{
    private string _redirectUrl;

    public RedirectRouteHandler(string redirectUrl)
    {
        _redirectUrl = redirectUrl;
    }

    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
        if (_redirectUrl.StartsWith("~/"))
        {
            string virtualPath = _redirectUrl.Substring(2);
            Route route = new Route(virtualPath, null);
            var vpd = route.GetVirtualPath(requestContext,
                requestContext.RouteData.Values);
            if (vpd != null)
            {
                _redirectUrl = "~/" + vpd.VirtualPath;
            }
        }

        return new RedirectHandler(_redirectUrl, false);
    }
}

public class RedirectHandler : IHttpHandler
{
    private readonly string _redirectUrl;

    public RedirectHandler(string redirectUrl, bool isReusable)
    {
        _redirectUrl = redirectUrl;
        IsReusable = isReusable;
    }

    public bool IsReusable { get; private set; }

    public void ProcessRequest(HttpContext context)
    {
        context.Response.Status = "301 Moved Permanently";
        context.Response.StatusCode = 301;
        context.Response.AddHeader("Location", _redirectUrl);
    }
}

public static class RouteExtensions
{
    public static void Redirect(this RouteCollection routes, string url, string redirectUrl)
    {
        routes.Add(new Route(url, new RedirectRouteHandler(redirectUrl)));
    }
}