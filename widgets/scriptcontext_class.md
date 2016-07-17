# ScriptContext 类

C# 不支持全局方法，因此 jQuery 的 `$` 函数在 Saltarelle 中不能像在 Javascript 那样使用。

在 Javascript 中的表达式 `$('#SomeElementId)` 对应于 Saltarelle 的 C# 代码 `jQuery.Select("#SomeElementId")`。

一种替代方法，可以使用 *ScriptContext* ：

```cs
public class ScriptContext
{
    [InlineCode("$({p})")]
    protected static jQueryObject J(object p);
    [InlineCode("$({p}, {context})")]
    protected static jQueryObject J(object p, object context);
}
```

由于 `$` 在 C# 中不是有效的方法名称，可以选择 `J` 代替。在 ScriptContext 子类中，jQuery.Select() 函数可以简单地使用 `J()` 调用。

```cs

public class SampleClass : ScriptContext
{
    public void SomeMethod()
    {
        J("#SomeElementId").AddClass("abc");
    }
}
```
