# 主题 

Serene 默认是蓝黑色主题。可在屏幕右上角用户名旁边的设置按钮  <i class="fa fa-gears"></i>中修改网站主题。

![Serene Dashboard Yellow Light](img/serene_dashboard_light.png)

此功能是通过替换页面中 body 的CSS样式实现的。

如果你查看源代码，你可能会发现像下面 '<body>' 标签中的皮肤样式 ︰

```html
<body id="s-DashboardPage" class="fixed sidebar-mini hold-transition 
    skin-blue has-layout-event">
```

当你选择浅黄色的主题时，它实际上是将 body 标签的 "skin-blue" 样式更改为 "skin-yellow-light"：

```html
<body id="s-DashboardPage" class="fixed sidebar-mini hold-transition 
    skin-yellow-light has-layout-event">
```

这是在内存中完成，所以不需要重新加载页面。

别外，*"浅黄色"* 将作为 *"主题偏好"*" 的内容保存在浏览器的 cookie 中，所以下次你启动 Serene 时，它会记住你的偏好，将显示浅黄色主题。

这些主题皮肤文件位于 Serene.Web 项目的"Content/adminlte/skins/"目录下。如果打开该目录文件，你将看到下面的文件 ︰

```
_all-skins.less
skin.black-light.less
site.blue.less
site.yellow-light.less
site.yellow.less
```

我们使用 LESS 生成 CSS，所以如果你要修改样式文件，你应该修改 LESS 文件而不是 CSS 文件，当你编译项目的时候，LESS 文件会编译生成 CSS文件（使用 Node 以开发模式编译 Less）。

此操作是在 Serene.Web.csproj 文件中的生成步骤中配置︰

```xml
...
<Target Name="CompileSiteLess" AfterTargets="AfterBuild">
    <Exec Command="&quot;$(ProjectDir)tools\node\lessc.cmd&quot;
        &quot;$(ProjectDir)Content\site\site.less&quot; &gt;
        &quot;$(ProjectDir)Content\site\site.css&quot;">
    </Exec>
</Target>
...
```

这里 *site.less* 与对应编译后的 css 文件存放在同一目录中。

> 关于 LESS 编译器及其语法的更多信息，请查看 http://lesscss.org/。
