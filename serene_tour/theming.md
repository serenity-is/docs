# Theming

Serene initially starts with a dark theme. On top right of the screen, next to *Theme* label, click the light gray circle and theme will change to a light one.

![Serene Dashboard Light](img/serene_dashboard_light.jpg)

This feature is implemented by replacing HREF of a CSS stylesheet resource in the page.

If you look at the source, you may spot a stylesheet link like below inside `<head>` section:

```html
<link id="SiteThemeCss" href="/Content/site/site.theme.default.css"
    rel="stylesheet" type="text/css" />
```

When you click the lighter circle, it actually changes to this:

```html
<link id="SiteThemeCss" href="/Content/site/site.theme.light.css"
    rel="stylesheet" type="text/css" />
```

This is done in memory so  page reload is not required.

Also a cookie, *"ThemePreference"*" with the content *"light"* is added to your browser. So next time you launch Serene, it will remember your preference and start with a light theme.

These theme files are located under "Content/site/" of the Serene.Web project. If you look there you can see files with names:

```
site.theme.default.less
site.theme.default.css
site.theme.light.less
site.theme.light.css
```

We are using LESS for CSS generation so you should try editing LESS files, not CSS. Next time you build your project, LESS files will be compiled to CSS (using *Less.js* compiler for *Node*).

This operation is configured with a build step in Serene.Web.csproj file:

```xml
...
<Target Name="CompileSiteLess" AfterTargets="AfterBuild">
    <Exec Command="&quot;$(ProjectDir)tools\node\lessc.cmd&quot;
        &quot;$(ProjectDir)Content\site\site.less&quot; &gt;
        &quot;$(ProjectDir)Content\site\site.css&quot;">
    </Exec>
    <Exec Command="&quot;$(ProjectDir)tools\node\lessc.cmd&quot;
        &quot;$(ProjectDir)Content\site\site.theme.default.less&quot; &gt;
        &quot;$(ProjectDir)Content\site\site.theme.default.css&quot;">
    </Exec>
    <Exec Command="&quot;$(ProjectDir)tools\node\lessc.cmd&quot;
        &quot;$(ProjectDir)Content\site\site.theme.light.less&quot; &gt;
        &quot;$(ProjectDir)Content\site\site.theme.light.css&quot;">
    </Exec>
</Target>
...
```

Here *site.less*, *site.theme.default.less* and *site.theme.light.less* files are compiled to their corresponding css files in the same directory.

> See http://lesscss.org/ for more information on LESS compiler and its syntax.
