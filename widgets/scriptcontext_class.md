# ScriptContext Class

C#, doesn't support global methods, so jQuery's `$` function can't be used as simply in Saltarelle as it is in Javascript.

A simple expression like `$('#SomeElementId)` in Javascript corresponds to Saltarelle C# code `jQuery.Select("#SomeElementId")`.

As a workaround, *ScriptContext* class can be used:

```cs
public class ScriptContext
{
    [InlineCode("$({p})")]
    protected static jQueryObject J(object p);
    [InlineCode("$({p}, {context})")]
    protected static jQueryObject J(object p, object context);
}
```

As `$` is not a valid method name in C#, `J` is chosen instead. In subclasses of ScriptContext, jQuery.Select() function can be called briefly as `J()`.

```cs

public class SampleClass : ScriptContext
{
    public void SomeMethod()
    {
        J("#SomeElementId").AddClass("abc");
    }
}
```
