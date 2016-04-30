# How To: Enable Script Bundling

In Serene template there are about 3MB+ of javascript files which are included by default in _LayoutHead.cshtml.

This might cause bandwidth and performance problems for some systems, especially when a Serenity based site is accessed from mobile devices.

There are several ways to handle these problems, like minification and gzipping to decrease script size, bundling to pack scripts into fewer files, thus reduce number of requests.

You might prefer to use tools like Webpack, Grunt, Gulp, UglifyJS etc, but in case you want a simpler and effective solution with much less manual steps, Serenity comes with a script bundling and minification / compression system out of the box. 

> Please note that this feature requires Serenity 2.0.13+


### ScriptBundles.json

First, you need a *ScriptBundles.json* file under *MyProject.Web/scripts/site* folder. ScriptBundles.json configures which script bundle will contain which files when bundling is turned on. 

This file is included by default in Serene template 2.0.13+ and looks like this:

> Unless you want to add some custom scripts to bundles, you don't need to modify this file.

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


### Enabling Bundling

You should enable bundling (especially minification) only in production. Otherwise it might become very difficult to debug Javascript.

To enable bundling, just change *Enabled* property of *ScriptBundling* application setting in your web.config to true:

```xml
<add key="ScriptBundling" value="
   { Enabled: true, Minimize: false, UseMinJS: false }" />
```

When *Enabled* is false (default) system will do nothing, and you'll work as usual with your script includes. And your page source looks like this:

```xml
<script src="/Scripts/pace.js?v=..."></script>
<script src="/Scripts/rsvp.js?v=..."></script>
<script src="/Scripts/jquery-2.2.3.js?v=..."></script>
<script src="/Scripts/jquery-ui-1.11.4.js?v=..."></script>
<script src="/Scripts/jquery-ui-i18n.js?v=..."></script>
...
...
...
<script src="/Scripts/adminlte/app.js?v=..."></script>
<script src="/Scripts/Site/Serene.Script.js?v=..."></script>
<script src="/Scripts/Site/Serene.Web.js?v=..."></script>
...
```

When *Enabled* is true, it will become like this one:

```xml
<script src="/DynJS.axd/Bundle.Libs.js?v=..."></script>
<script src="/DynJS.axd/Bundle.Site.js?v=..."></script>
...
```


These two bundles are generated in memory and contains all other script files configured in ScriptBundles.json file.

They are also compressed with GZIP and cached in memory (in gzipped form), so now our scripts will consume much less bandwidth and will cause fewer requests to server.

Now our script files will consume 600KB, instead of 3000KB before, a %80 reduction, not bad...


### Enabling Minification

After enabling bundling, you may also enable minification of scripts with the same web.config setting. Set *Minimize* property to true:


```xml
<add key="ScriptBundling" value="
   { Enabled: true, Minimize: true, UseMinJS: false }" />
```


> Please note that *Minimize* property only works when *Enabled* is true, thus when bundling is enabled.

UglifyJS library is used for minification. This will be applied before bundling / gzipping so our bundles will become about %40 smaller, but will be much harder to read, so enable this only in production.

Now our bundled and minified script files will consume 375KB, instead of 3000KB before, a %87 reduction, or 1/8 the initial size.

### UseMinJS Setting

Minification might take some time, and first request to your site might take around 5-40 seconds more, depending on speed of your server.

Other requests will not be affected as minification is only performed once at application start.

Anyway, if you still need more performance at first request, you may ask Serenity to reuse already minified files in disk, if they are available.

Set *UseMinJS* to true:

```xml
<add key="ScriptBundling" value="
    { Enabled: true, Minimize: true, UseMinJS: true }" />
```

When this setting is ON, before minifying a file, let's say *jquery-ui-1.11.4.js*, Serenity will first check to see if a *jquery-ui-1.11.4.min.js* already exists in disk. If so, instead of minifiying with UglifyJS, it will simply use that file. Otherwise, it will run UglifyJS.

Serene comes with minified versions of almost all libraries, including Serenity scripts, so this setting will speed up initial start time.

There is a little risk that you should be careful about. If you manually modify a library script, make sure you minify it manually and modify its .min.js file too, otherwise when bundling is enabled an old version of that script might run at production.


### How Serenity Modifies Your _LayoutHead.cshtml Includes?

If you look at your *_LayoutHead.cshtml* you might spot lines like these:

```
@Html.Script("~/Scripts/jquery.cropzoom.js")
@Html.Script("~/Scripts/jquery.fileupload.js")
@Html.Script("~/Scripts/jquery.iframe-transport.js")
```

When bundling is disabled, these statements generates such HTML code:

```html
<script src="/Scripts/jquery.cropzoom.js"></script>
<script src="/Scripts/jquery.fileupload.js"></script>
<script src="/Scripts/jquery.iframe-transport.js"></script>
```

Html.Script is an extension method of Serenity, so when bundling is enabled, instead of generating this HTML code, Serenity will first check to see if this script is included in a bundle.

For the first script that is included in a bundle, let's say Bundle.Lib.js, Serenity will generate code below:

```html
<script src="/DynJS.axd/Bundle.Libs.js?v=..."></script>
```

But, for other Html.Script calls that is included in same bundle, Serenity will generate nothing. Thus, even though you call Html.Script 50 times, you'll get only one `<script>` output in page code.


### What Is v=p53uqJ... In My Script Tags?

This is a version number, or HASH of your script. Whether bundling is enabled or not, when you use Html.Script, it will add these hash to your script includes. This hash allows browser to cache script until it changes. When content of a script changes, its hash will change too, so browser won't cache and use an older version.

This is the reason you'll never have script caching problems with Serenity apps.
