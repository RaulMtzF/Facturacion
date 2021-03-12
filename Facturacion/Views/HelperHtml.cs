using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturacion.Helpers
{
    public static class InputURLHelper
    {
        public static MvcHtmlString InputURL(this HtmlHelper htmlHelper)
        {
            string url = GetUrlApplication(HttpContext.Current);
            return MvcHtmlString.Create(String.Format("<input type='hidden' id='inputURL' value='{0}' />", url));
        }

        public static string GetUrlApplication(HttpContext currentHttpContext)
        {
            if (currentHttpContext.Request.ApplicationPath != "/")
            {
                //IIS LOCAL
                return currentHttpContext.Request.Url.Scheme + "://" + currentHttpContext.Request.Url.IdnHost + "/" + currentHttpContext.Request.Url.Segments[1];
            }
            else
            {
                //IIS EXPRESS
                return currentHttpContext.Request.Url.Scheme + "://" + currentHttpContext.Request.Url.IdnHost + ":" + currentHttpContext.Request.Url.Port + "/";
            }
        }
    }
}