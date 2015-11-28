# How To: Upgrade to Serenity 1.8+

Serene template 1.8 replaced old integrated theme with Bootstrap based AdminLTE theme. Serenity default css files (serenity.css and aristo.css) also had some cleanup / changes.

This is to provide a better look, simpler css and a major step towards more Bootstrap integration and less dependency on jQuery UI.

When you update Serenity NuGet packages from 1.7 and older versions to 1.8+, you might have minor issues related to look and feel, altough we tried to keep them to minimum.

If you want to continue using old theme after updating NuGet packages, it is recommended to modify serenity.overrides.less with contents like below:

```less
@import "site.mixins.less";

.opensans {
    font-family: 'Open Sans', 'Segoe UI', Arial, Helvetica, sans-serif;
}

body, td, input, select, .ui-widget, .ui-widget-content, .ui-widget .ui-widget-content,
input[type=text], input[type=email], input[type=password], textarea, .ui-widget textarea,
.s-Form, .s-Form td, .s-Form input, .s-Form select {
    .opensans;
    font-size: 13px;
}

input[type="text"],
input[type="email"],
input[type="tel"],
input[type="search"],
input[type="url"],
input[type="password"],
textarea {
    padding: 3px 6px;
    border: 1px solid #ccc;
    border-radius: 3px;
}
```

> You may also choose to create a new application using 1.8+ Serene template and transfer your custom existing code like less and C# code files.

> This is recommended as several breaking changes are expected for future versions.