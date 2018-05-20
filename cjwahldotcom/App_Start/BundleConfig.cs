using System.Web;
using System.Web.Optimization;

namespace cjwahldotcom
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/main.css",
                      "~/Content/bootstrap/bootstrap.min.css"));
        }
    }
}
