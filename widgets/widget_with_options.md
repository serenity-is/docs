# Widget&lt;TOptions&gt; Generic Class

If a widget requires some additional initialization options, it might be derived from the `Widget<TOptions>` class.

The options passed to the constructor can be accessed in class methods through the protected field `options`.

```cs
public abstract class Widget<TOptions> : Widget
    where TOptions: class, new()
{
    protected Widget(jQueryObject element, TOptions opt = null) { ... }
    protected readonly TOptions options;
}
```
