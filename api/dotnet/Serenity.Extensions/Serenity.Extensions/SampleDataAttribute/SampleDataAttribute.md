# SampleDataAttribute constructor

Marks a migration that adds sample data, so it only runs when the migration runner requests either all the sample data via [`AllTag`](./AllTag.md), or the sample data of a module via [`GetTag`](./GetTag.md), e.g. `sample:Dashboards`.

```csharp
public SampleDataAttribute(string key)
```

| parameter | description |
| --- | --- |
| key | The key of the module the sample data belongs to, e.g. `Dashboards`. |

## See Also

* class [SampleDataAttribute](../SampleDataAttribute.md)