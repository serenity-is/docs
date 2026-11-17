# SampleDataAttribute class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Marks a migration that adds sample data, so it only runs when the migration runner requests either all the sample data via [`AllTag`](./SampleDataAttribute/AllTag.md), or the sample data of a module via [`GetTag`](./SampleDataAttribute/GetTag.md), e.g. `sample:Dashboards`.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class SampleDataAttribute : TagsAttribute
```

| parameter | description |
| --- | --- |
| key | The key of the module the sample data belongs to, e.g. `Dashboards`. |

## Public Members

| name | description |
| --- | --- |
| [SampleDataAttribute](SampleDataAttribute/SampleDataAttribute.md)(…) | Marks a migration that adds sample data, so it only runs when the migration runner requests either all the sample data via [`AllTag`](./SampleDataAttribute/AllTag.md), or the sample data of a module via [`GetTag`](./SampleDataAttribute/GetTag.md), e.g. `sample:Dashboards`. |
| const [AllTag](SampleDataAttribute/AllTag.md) | The tag that requests the sample data of all modules, i.e. `sample:All`. |
| static [GetTag](SampleDataAttribute/GetTag.md)(…) | Gets the tag that requests the sample data of the module with the specified key. |

## See Also

* **Source:** *[SampleDataAttribute.cs](https://github.com/serenity-is/Serenity/blob/aab75cea931a5cb4bf3e3be49c31543373944904/common-features/src/extensions/Modules/MigrationUtils/SampleDataAttribute.cs)*