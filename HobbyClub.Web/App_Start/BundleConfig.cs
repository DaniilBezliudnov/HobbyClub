using System.Web;
using System.Web.Optimization;

namespace HobbyClub.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.min.js",
					  "~/Scripts/respond.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mainPage").Include(
                      
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/mousescroll.js",
                      "~/Scripts/smoothscroll.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/jquery.isotope.min.js",
                       "~/Scripts/jquery.inview.min.js",
                       "~/Scripts/wow.min.js",
                       "~/Scripts/main.js"
                      ));


			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/Css/bootstrap.min.css",
                      "~/Content/Css/font - awesome.min.css",
                      "~/Content/Css/animate.min.css",
                      "~/Content/Css/owl.carousel.css",
                      "~/Content/Css/owl.transitions.css",
                      "~/Content/Css/prettyPhoto.css",
                      "~/Content/Css/main.css",
                      "~/Content/Css/responsive.css"
                      ));
		}
	}
}
