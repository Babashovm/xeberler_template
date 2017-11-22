using System.Web;
using System.Web.Optimization;

namespace Xeberler_Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                "~/assets/css/bootstrap.min.css",
                "~/assets/css/font-awesome.min.css",
                "~/assets/css/animate.css",
                "~/assets/css/font.css",
                "~/assets/css/li-scroller.css",
                "~/assets/css/slick.css",
                "~/assets/css/jquery.fancybox.css",
                "~/assets/css/theme.css",
                "~/assets/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/assets/js").Include(
                
                "~/assets/js/jquery.min.js",
                "~/assets/js/wow.min.js",
                "~/assets/js/bootstrap.min.js",
                "~/assets/js/slick.min.js",
                "~/assets/js/jquery.li-scroller.1.0.js",
                "~/assets/js/jquery.newsTicker.min.js",
                "~/assets/js/jquery.fancybox.pack.js",
                "~/assets/js/custom.js"

                )
                );

            

        }
    }
}
