# SqlSettings.DefaultComparer property

Gets or sets the default comparer used to compare string field values (e.g. for change detection or dirty tracking) when a field, row or connection does not specify one. Returns the local comparer if any is set through [`SetLocalComparer`](./SetLocalComparer.md), otherwise the default comparer. Defaults to CurrentCulture. This should only be set on application start. The local comparer should be used for unit tests.

```csharp
public static IComparer DefaultComparer { get; set; }
```

## See Also

* class [SqlSettings](../SqlSettings.md)