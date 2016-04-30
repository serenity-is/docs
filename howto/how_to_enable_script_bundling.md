# How To: Enable Script Bundling

In Serene template there are about 1MB+ of javascript files which are included by default in _LayoutHead.cshtml.

This might cause bandwidth and performance problems for some systems, especially when a Serenity based site is accessed from mobile devices.

There are several ways to handle these problems, like minification and gzipping to decrease script size, bundling to pack scripts into fewer files, thus reduce number of requests.

You might prefer to use tools like Webpack, Grunt, Gulp, UglifyJS etc, but in case you want a simpler and effective solution with much less manual steps, Serenity comes with a script bundling and minification / compression system out of the box. 

> Please note that this feature requires Serenity 2.0.13+


### ScriptBundles.json

First, you need a *ScriptBundles.json* file under *MyProject.Web/scripts/site* folder. ScriptBundles.json configures which script bundle will contain which files when bundling is turned on. This file is included by default in Serene template 2.0.13+ and looks like this:

```json
{
    "Libs": [
        "~/Scripts/pace.js",
        "~/Scripts/rsvp.js",
        "~/Scripts/jquery-{version}.js",
        "~/Scripts/jquery-ui-{version}.js",
        "~/Scripts/jquery-ui-i18n.js",
        "~/Scripts/jquery.validate.js",
        "~/Scripts/jquery.blockUI.js",
        "~/Scripts/jquery.cookie.js",
        "~/Scripts/jquery.json.js",
        "~/Scripts/jquery.autoNumeric.js",
        "~/Scripts/jquery.colorbox.js",
        "~/Scripts/jquery.dialogextendQ.js",
        "~/Scripts/jquery.event.drag.js",
        "~/Scripts/jquery.scrollintoview.js",
        "~/Scripts/jsrender.js",
        "~/Scripts/select2.js",
        "~/Scripts/toastr.js",
        "~/Scripts/SlickGrid/slick.core.js",
        "~/Scripts/SlickGrid/slick.grid.js",
        "~/Scripts/SlickGrid/slick.groupitemmetadataprovider.js",
        "~/Scripts/SlickGrid/Plugins/slick.autotooltips.js",
        "~/Scripts/SlickGrid/Plugins/slick.headerbuttons.js",
        "~/Scripts/SlickGrid/Plugins/slick.rowselectionmodel.js",
        "~/Scripts/SlickGrid/Plugins/slick.rowmovemanager.js",
        "~/Scripts/bootstrap.js",
        "~/Scripts/Saltarelle/mscorlib.js",
        "~/Scripts/Saltarelle/linq.js",
        "~/Scripts/Serenity/Serenity.CoreLib.js",
        "~/Scripts/Serenity/Serenity.Script.UI.js",
        "~/Scripts/Serenity/Serenity.Externals.js",
        "~/Scripts/Serenity/Serenity.Externals.Slick.js",
        "~/Scripts/jquery.cropzoom.js",
        "~/Scripts/jquery.fileupload.js",
        "~/Scripts/jquery.iframe-transport.js",
        "~/Scripts/jquery.slimscroll.js",
        "~/Scripts/mousetrap.js",
        "~/Scripts/fastclick/fastclick.js"
    ],
    "Site": [
        "~/Scripts/adminlte/app.js",
        "~/Scripts/Site/Serene.Script.js",
        "~/Scripts/Site/Serene.Web.js"
    ]
}
```

Here we define two distinct bundles, *Libs* and *Site*, corresponding to *Bundle.Libs.js* and *Bundle.Site.js* dynamic script files.

*Bundle.Site.js* is configured to contain these three JS files (in the listed order):

````
"~/Scripts/adminlte/app.js",
"~/Scripts/Site/Serene.Script.js",
"~/Scripts/Site/Serene.Web.js"
```

While *Bundle.Libs.js* contains all other javascript files.

> Here we used 2 bundles by default, but it is possible to use one, three or more in case you need a different configuration. Just be careful about dependencies.

Here, the ordering inside a bundle (package) is very important. You must include scripts in the order they appear in your *_LayoutHead.cshtml*. 

When you will add another custom script, make sure that it is placed after all its dependencies. 

> For example, if you include a jquery plugin before jquery is loaded itself, you'll have errors.

Also make sure that you don't include same file in two bundles.

