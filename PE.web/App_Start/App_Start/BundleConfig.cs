using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace PE.web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Bootstrap

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            // jQuery

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-3.6.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                     "~/Content/assets/js/vendor/jquery.js"));

            // jQuery validation

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));
            // Bootstrap CSS

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));
            
            // Font Awesome icons style

            bundles.Add(new Bundle("~/bundle/fontawesome").Include(
                      "~/Content/assets/css/plugins/fontawesome.min.css"));

            bundles.Add(new Bundle("~/bundle/fontawesome").Include(
                     "~/Scripts/fontawesome/fontawesome.js"));


            //Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-{version}.js"));

            // Template integration

            bundles.Add(new StyleBundle("~/bundles/slick").Include(
                "~/Content/assets/css/vendor/slick.css"));

            bundles.Add(new StyleBundle("~/bundles/slick-theme").Include(
                "~/Content/assets/css/vendor/slick-theme.css"));

            bundles.Add(new StyleBundle("~/bundles/feather").Include(
                "~/Content/assets/css/plugins/feather.css"));

            bundles.Add(new StyleBundle("~/bundles/euclid-circulara").Include(
                "~/Content/assets/css/plugins/euclid-circulara.css"));

            bundles.Add(new StyleBundle("~/bundles/swiper").Include(
               "~/Content/assets/css/plugins/swiper.css"));

            bundles.Add(new StyleBundle("~/bundles/magnify").Include(
               "~/Content/assets/css/plugins/magnify.css"));

            bundles.Add(new StyleBundle("~/bundles/odometer").Include(
               "~/Content/assets/css/plugins/odometer.css"));

            bundles.Add(new StyleBundle("~/bundles/magnify").Include(
               "~/Content/assets/css/plugins/magnify.css"));

            bundles.Add(new StyleBundle("~/bundles/animation").Include(
               "~/Content/assets/css/plugins/animation.css"));

            bundles.Add(new StyleBundle("~/bundles/jquery-ui").Include(
               "~/Content/assets/css/plugins/jquery-ui.css"));

            bundles.Add(new StyleBundle("~/bundles/magnigny-popup").Include(
               "~/Content/assets/css/plugins/magnigy-popup.min.css"));

            bundles.Add(new Bundle("~/bundles/style").Include(
               "~/Content/assets/css/style.css"));

            //

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/assets/js/vendor/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sal").Include(
                       "~/Content/assets/js/vendor/sal.js"));

            bundles.Add(new Bundle("~/bundles/swiper").Include(
                       "~/Content/assets/js/vendor/swiper.js"));

            bundles.Add(new ScriptBundle("~/bundles/magnify").Include(
                     "~/Content/assets/js/vendor/magnify.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-appear").Include(
                    "~/Content/assets/js/vendor/jquery-appear.js"));

            bundles.Add(new ScriptBundle("~/bundles/odometer").Include(
                   "~/Content/assets/js/vendor/jquery-appear.js"));

            bundles.Add(new ScriptBundle("~/bundles/backtotop").Include(
                   "~/Content/assets/js/vendor/backtotop.js"));

            bundles.Add(new ScriptBundle("~/bundles/isotop").Include(
                   "~/Content/assets/js/vendor/isotop.js"));


            bundles.Add(new ScriptBundle("~/bundles/imageloaded").Include(
                    "~/Content/assets/js/vendor/imageloaded.js"));

            //

            bundles.Add(new ScriptBundle("~/bundles/wow").Include(
                    "~/Content/assets/js/vendor/wow.js"));

            bundles.Add(new ScriptBundle("~/bundles/waypoint").Include(
                    "~/Content/assets/js/vendor/waypoint.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/easypie").Include(
                    "~/Content/assets/js/vendor/easypie.js"));

            bundles.Add(new ScriptBundle("~/bundles/text-type").Include(
                    "~/Content/assets/js/vendor/text-type.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-one-page-nav").Include(
                    "~/Content/assets/js/vendor/jquery-one-page-nav.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select").Include(
                    "~/Content/assets/js/vendor/bootstrap-select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                    "~/Content/assets/js/vendor/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/magnify-popup").Include(
                    "~/Content/assets/js/vendor/magnify-popup.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/paralax-scroll").Include(
                    "~/Content/assets/js/vendor/paralax-scroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/paralax").Include(
                    "~/Content/assets/js/vendor/paralax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/countdown").Include(
                    "~/Content/assets/js/vendor/countdown.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                   "~/Content/assets/js/main.js"));
        }
    }
}