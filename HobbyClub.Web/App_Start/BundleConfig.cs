using System.Web;
using System.Web.Optimization;

namespace HobbyClub.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
            bundles.Add(new ScriptBundle("~/bundles/libraries").Include(
                //"~/Scripts/libraries/jquery.js",
                       "~/Scripts/libraries/jquery-1.11.2.min.js",
                       "~/Scripts/libraries/angular.js",
                      "~/Scripts/libraries/angular-sanitize.min.js"
                       ));

 			bundles.Add(new ScriptBundle("~/bundles/libraries/bootstrap").Include(
                      "~/Scripts/libraries/bootstrap.min.js",
                      "~/Scripts/libraries/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/libraries/mainPage").Include(
                      "~/Scripts/libraries/owl.carousel.min.js",
                      "~/Scripts/libraries/mousescroll.js",
                      "~/Scripts/libraries/smoothscroll.js",
                      "~/Scripts/libraries/jquery.prettyPhoto.js",
                      "~/Scripts/libraries/jquery.isotope.min.js",
                       "~/Scripts/libraries/jquery.inview.min.js",
                       "~/Scripts/libraries/wow.min.js",
                       "~/Scripts/libraries/main.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                  "~/Scripts/app/layout.js",
                  "~/Scripts/app/interest/angularModules.js"
                     ));




			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/Css/bootstrap.min.css",
                      "~/Content/Css/font-awesome.css",
                      "~/Content/Css/font-awesome.min.css",
                      "~/Content/Css/animate.min.css",
                      "~/Content/Css/owl.carousel.css",
                      "~/Content/Css/owl.transitions.css",
                      "~/Content/Css/prettyPhoto.css",
                      "~/Content/Css/main.css",
                      "~/Content/Css/responsive.css",
                      "~/Content/Css/tree.css"
                      ));
		}
	}
}
