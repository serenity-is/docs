# 待审状态

LocalTextRegistry 还支持可选的待审状态。

在一些网站，翻译可能需要在发布之前经过一些版主的审核。

所以你可能将未经审核的文本添加到本地化注册表（local text registry），但希望在批准时，只有版主可以检查它们将如何在直播网站显示。

LocalTextRegistry 允许你将一些文本标记为待审，并只有批准上下文（例如，当版主已登录）可使用这些翻译文本。

## ILocalTextContext 接口

[**命名空间**: *Serenity.Localization*, **程序集**: *Serenity.Core*]

```cs
public interface ILocalTextContext
{
    bool IsApprovalMode { get; }
}
```

实现该接口并通过服务定位器（依赖类）注册它。

IsApprovalMode 属性用来决定当前上下文是否处于审核状态（如，被版主使用）。

```cs
public class MyLocalTextContext : ILocalTextContext
{
    public bool IsApprovalMode
    {
        get
        {
            // use some method to determine if current user is a moderator
            return Authorization.HasPermission("Moderation");
        }
    }
}

void ApplicationStart()
{
    Dependency.Resolve<IDependencyRegistrar>()
        .RegisterInstance<ILocalTextContext>(new MyLocalTextContext());
}
```

## LocalTextRegistry.AddPending 方法

在本地化表（local text table）添加待审文本。只有当前处于待审状态的上下文可使用这些文本。

## 含语言和待审状态的 LocalTextRegistry.TryGet 重载

```cs
public string TryGet(string languageID, string textKey, bool isApprovalMode);
```

该重载获得指定语言的翻译并可以选择使用未审核的文本 (isApprovalMode = true)。

另外只有当 ILocalTextContext 提供者返回的 IsApprovalMode 属性为 true 时， TryGet 重载才返回未审核文本。

## LocalTextRegistry.GetAllAvailableTextsInLanguage 方法

返回语言中所有当前注册翻译的文本键（text keys）字典。

当字典的值（value）被翻译时，key 为本地化文本键（local text keys）。

它也包含回退文本，当文本不能被翻译成目标的语言时，则使用该文本。

