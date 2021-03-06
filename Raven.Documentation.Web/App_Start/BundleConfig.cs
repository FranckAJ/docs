﻿using System.Web;
using System.Web.Optimization;

namespace Raven.Documentation.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new ScriptBundle("~/bundles/prism")
				.Include("~/Scripts/prism.js"));

			bundles.Add(new StyleBundle("~/Content/css")
				.Include(
					"~/Content/bootstrap.css",
					"~/Content/font-awesome.css",
					"~/Content/prism.css",
					"~/Content/site.css"));

			// Set EnableOptimizations to false for debugging. For more information,
			// visit http://go.microsoft.com/fwlink/?LinkId=301862
#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
		}
	}
}
