# 本地化

大多数 web 应用程序必须支持多种语言。例如：Youtube、 Wikipedia、 Facebook 网站都支持多语言。 

当用户第一次访问网站时，根据用户浏览器（预先设置的地区）自动选择显示的语言。

如果自动选择的语言不是用户所期望的，用户可以设置他们的首选语言，用户的选择存储在客户端 cookie（或服务器端用户简介表（user profile table））。

一旦选择了语言，所有的文本都将显示为所选的语言。

Serenity 平台从开始设计之初就考虑到本地化功能。

如果你在使用 *Serenity 基本应用程序示例*，你可以通过设置浏览器语言或更改 web.config 的设置来查看本地化功能： 

```xml
<system.web>
    <globalization culture="en-US" uiCulture="auto:en-US" />
</system.web>
```

在这里，*UI 文化（culture）* 设置为 *自动*，如果自动检测失败，则使用 EN-US 。

![Customer Screen English](img/localization_customer_english.jpg)

像下面这样修改该配置，并刷新浏览器，你的网站将使用土耳其语。

```xml
<system.web>
    <globalization culture="en-US" uiCulture="tr" />
</system.web>
```

![Customer Screen Turkish](img/localization_customer_turkish.jpg)

> 在这里，数据没有被翻译，但也可以使用一些像文化扩展表（culture extension tables）的方法来翻译用户输入的数据。
