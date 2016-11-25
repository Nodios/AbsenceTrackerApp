using System.Web;
using System.Web.Optimization;

namespace AbsenceTracker.WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Custom bundles
            bundles.Add(new ScriptBundle("~/app/js").Include(
                "~/app/js/angular/angular.js",
                "~/app/js/md5.js",
                "~/app/js/angular/angular-ui-router.js",
                "~/app/js/angularUtils-pagination-0.11.0/dirPagination.js",
                "~/app/js/angular/angular-cookies.js"
                ));
            
            //Add controllers
            //example: "~/app/controllers/[directory_name]/*Controller.js"
            bundles.Add(new ScriptBundle("~/app").Include(
                "~/app/app.js",
                "~/app/services/*Service.js",
                "~/app/controllers/user/*Controller.js",
                "~/app/controllers/admin/*Controller.js",
                "~/app/controllers/login/*Controller.js"
                ));

        }
    }
}
