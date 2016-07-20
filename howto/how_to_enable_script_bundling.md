# 如何启用脚本合并（Script Bundling）？

在 Serene 模板中，_LayoutHead.cshtml 默认包含了 3MB+ 的 javascript 引用文件。

这可能导致系统出现一些带宽和性能问题，特别是使用移动设备访问基于 Serenity 的站点。

有几种方式可以处理这些问题，如压缩文件以减少脚本大小；合并打包脚本到较少的文件，从而减少请求的数量。

你可能更喜欢使用工具，如 Webpack、Grunt、Gulp、UglifyJS 等，但如果你想要更简单有效且更少手工操作的解决方案，Serenity 自带的脚本合并和压缩系统可开箱即用。

> 请注意，该功能要求  Serenity 2.0.13+ 。


### ScriptBundles.json

首先，你需要在 *MyProject.Web/scripts/site* 文件夹下添加一个文件 *ScriptBundles.json*。ScriptBundles.json 配置启用合并时，合并脚本将包含这些文件。

在 Serene 模板 2.0.13+ 中默认包含该文件，它看起来像：

> 除非你想要向包中添加一些自定义的脚本，否则你不需要修改此文件。

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

在这里我们定义两个不同的合并配置，*Libs* 和 *Site*，对应于动态脚本文件：

*Bundle.Site.js* 配置为包含这三个 JS 文件（在列出的顺序）：

````
"~/Scripts/adminlte/app.js",
"~/Scripts/Site/Serene.Script.js",
"~/Scripts/Site/Serene.Web.js"
```

而 *Bundle.Libs.js* 包含所有其他 javascript 文件。

> 默认情况下，我们这里使用 2 个合并包（bundles），但如果你需要不同的配置，只要注意依赖关系，也可以使用一个、三个或更多的合并包。

在这里，合并包（bundle）内的顺序是非常重要的。必须按在 _LayoutHead.cshtml 出现的顺序包含脚本。

在你添加另外的客户脚本时，请确保把它放在所有依赖脚本后面。

> 例如，如果在 jquery 前加载 jquery 插件，你将得到错误。

同时，也要确保在两个合并包（bundles）中不能包含同一文件。


### Enabling Bundling

你应该只在生产发布时启用合并（特别是压缩）。否则 Javascript 将会难以调试。

为了启用合并，只需要把 web.config 中 *ScriptBundling* 的 *Enabled* 属性改为 true：

```xml
<add key="ScriptBundling" value="
   { Enabled: true, Minimize: false, UseMinJS: false }" />
```

当 *Enabled* 是 false （默认情况）时，系统不会做任何事，并且你包含的脚本是未经压缩的。你的页面源代码看起来是这样的：

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

当 *Enabled* 为 true 时，脚本将被合并成为：

```xml
<script src="/DynJS.axd/Bundle.Libs.js?v=..."></script>
<script src="/DynJS.axd/Bundle.Site.js?v=..."></script>
...
```


这两个包在内存中生成，并包含所有在 ScriptBundles.json 文件配置的脚本。

他们同样使用 GZIP 压缩并在内存中缓存（以压缩的形式），因此我们的脚本将消耗更少的带宽和服务请求。

现在，我们的脚本文件压缩到 600KB，而不是之前的 3000KB，减少了 80% 的大小。


### Enabling Minification

在启用合并之后，你也可以在 web.config 设置中启用脚本压缩，把 *Minimize* 属性设置为 true:


```xml
<add key="ScriptBundling" value="
   { Enabled: true, Minimize: true, UseMinJS: false }" />
```


> 请注意，*Minimize* 属性只有同时启用合并属性才能工作。

UglifyJS 库是用来压缩 js 文件。它被用在 合并/压缩 之前，因此我们的合并将会减少 40%，但是更难以阅读，因此只在生产发布时启用压缩设置。

现在我们合并及压缩后的脚本文件将变为 375 KB，而不是之前的 3000 KB，与初始大小相比降低了 87% 或 1/8。

### UseMinJS Setting

压缩操作将花点时间，并且第一次请求站点时，根据服务器的速度，可能需要花费 5-40 秒甚至更长时间。

由于压缩只在应用程序启动时执行一次，所以不会影响其他请求。

无论如何，如果在第一个请求时，你还需要更高的性能，你可以要求 Serenity 重用在磁盘上可用的已压缩文件。

把 *UseMinJS* 设置为 true：

```xml
<add key="ScriptBundling" value="
    { Enabled: true, Minimize: true, UseMinJS: true }" />
```

当该设置为 ON 时，在压缩文件前，例如 *jquery-ui-1.11.4.js*，Serenity 将首先检查 *jquery-ui-1.11.4.min.js* 文件是否存在磁盘上。如果存在，将直接使用该文件，而不再使用 UglifyJS 压缩文件。否则它将运行 UglifyJS 压缩文件。

Serene 包含所有脚本库的压缩版本，也包括 Serenity 的脚本，因此该设置将加速初始启动时间。

还有一个你应该小心避免的风险。如果你手动修改脚本库，请确保你手动压缩并同时修改它的 .min.js 文件，否则启用合并时，生产环境可能会运行旧版本的脚本。


### Serenity 如何修改 _LayoutHead.cshtml 包含的脚本文件？

如果查看 *_LayoutHead.cshtml*，你可能会注意到文件中的这些代码：

```
@Html.Script("~/Scripts/jquery.cropzoom.js")
@Html.Script("~/Scripts/jquery.fileupload.js")
@Html.Script("~/Scripts/jquery.iframe-transport.js")
```

当禁用合并时，这些声明生成如下 HTML 代码：

```html
<script src="/Scripts/jquery.cropzoom.js"></script>
<script src="/Scripts/jquery.fileupload.js"></script>
<script src="/Scripts/jquery.iframe-transport.js"></script>
```

Html.Script 是 Serenity 的扩展方法，因此当开启合并时，Serenity 将首先检查合并内容是否包含该脚本，而不是生成 HTML 代码。

假设合并包含 Bundle.Lib.js 脚本，Serenity 将生成下面的代码：

```html
<script src="/DynJS.axd/Bundle.Libs.js?v=..."></script>
```

但是，对于同一合并中包括其他 Html.Script 调用，Serenity 将不会生成任何东西。因此，即使你调用 Html.Script 50 次，在页代码中只会得到一个 `<script>` 的输出。


### 脚本标签中的 v=p53uqJ... 是什么？

这是脚本的版本号或哈希值。不管是否启用合并，当你使用 Html.Script 时，都会在包含的脚本中添加这些哈希值。该哈希值允许浏览器缓存脚本直到哈希值发生变化。当脚本内容更改时，其哈希值也会变化，所以浏览器不会缓存并使用较旧版本的脚本。

这就是使用 Serenity 应用程序不会有脚本缓存问题的原因。
