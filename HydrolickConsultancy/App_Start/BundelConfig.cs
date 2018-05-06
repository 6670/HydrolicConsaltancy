using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HydrolickConsultancy.App_Start
{
    public class BundelConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.ResetAll();
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptJs = new ScriptBundle("~/bundles/js");
            StyleBundle styleCss = new StyleBundle("~/content/css/bundles");

            //use Include() method to add all the script files with their paths 
            scriptJs.Include(
                                "~/content/js/jquery-3.3.1.js",
                                "~/content/js/bootstrap.min.js",
                                "~/content/js/modernizr.custom.86080.js",
                                "~/content/js/custom.js"
                              );

            styleCss.Include(
                "~/content/css/bootstrap.css",
                "~/content/css/bootstrap-grid.min.css",
                 "~/content/css/bootstrap-reboot.min.css",
                 "~/content/css/slider-style3.css",
                 "~/content/css/style.css",
                 "~/content/css/responsive.css"
                 );

            ////Add the bundle into BundleCollection

            bundles.Add(styleCss);
            bundles.Add(scriptJs);


            BundleTable.EnableOptimizations = true;
        }
    }
}