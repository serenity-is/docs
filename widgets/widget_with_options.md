# Widget < TOptions > 泛型类

如果部件需要一些额外的初始化选项，可以从 `Widget< TOptions >` 类派生。

在类方法中可以通过受保护的字段 `options` 访问传递给构造函数的选项。

```cs
public abstract class Widget< TOptions > : Widget
    where TOptions: class, new()
{
    protected Widget(jQueryObject element, TOptions opt = null) { ... }
    protected readonly TOptions options;
}
```
