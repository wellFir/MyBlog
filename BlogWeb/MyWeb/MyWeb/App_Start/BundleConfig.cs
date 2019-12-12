using System.Web;
using System.Web.Optimization;

namespace MyWeb
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/html5shiv.min.js",
                      "~/Scripts/jquery-1.11.1.min.js",
                      "~/Scripts/jquery-2.1.4.min.js",
                      "~/Scripts/jquery.ias.js",
                      "~/Scripts/jquery.lazyload.min.js",
                      "~/Scripts/nprogress.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/scripts.min.js",
                      "~/Scripts/selectivizr-min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/normalize.css",
                      "~/Content/nprogress.css",
                      "~/Content/style.css"));
        }
    }
}
