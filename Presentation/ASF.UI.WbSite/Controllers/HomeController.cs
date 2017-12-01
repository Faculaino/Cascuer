using ASF.UI.WbSite.Constants;
using ASF.UI.WbSite.Constants.HomeController;
using Boilerplate.Web.Mvc;
using Boilerplate.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ASF.UI.wbsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Cascuer";
            return View();
        }

        [Route("about", Name = HomeControllerRoute.GetAbout)]
        public ActionResult About()
        {
            return this.View(HomeControllerAction.About);
        }

        [Route("contact", Name = HomeControllerRoute.GetContact)]
        public ActionResult Contact()
        {
            return this.View(HomeControllerAction.Contact);
        }

        [Route("search", Name = HomeControllerRoute.GetSearch)]
        public ActionResult Search(string query)
        {
            
            return this.Redirect(string.Format(
                "https://www.google.co.uk/?q=site:{0} {1}",
                this.Url.AbsoluteRouteUrl(HomeControllerRoute.GetIndex),
                query));
        }

        //[NoTrailingSlash]
        //[OutputCache(CacheProfile = CacheProfileName.BrowserConfigXml)]
        //[Route("browserconfig.xml", Name = HomeControllerRoute.GetBrowserConfigXml)]
        //public ContentResult BrowserConfigXml()
        //{
        //    Trace.WriteLine(string.Format(
        //        "browserconfig.xml requested. User Agent:<{0}>.",
        //        this.Request.Headers.Get("User-Agent")));
        //    string content = this.browserConfigService.GetBrowserConfigXml();
        //    return this.Content(content, ContentType.Xml, Encoding.UTF8);
        //}

        //[NoTrailingSlash]
        //[OutputCache(CacheProfile = CacheProfileName.ManifestJson)]
        //[Route("manifest.json", Name = HomeControllerRoute.GetManifestJson)]
        //public ContentResult ManifestJson()
        //{
        //    Trace.WriteLine(string.Format(
        //        "manifest.jsonrequested. User Agent:<{0}>.",
        //        this.Request.Headers.Get("User-Agent")));
        //    string content = this.manifestService.GetManifestJson();
        //    return this.Content(content, ContentType.Json, Encoding.UTF8);
        //}

    }
}