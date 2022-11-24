# DataScript&lt;TData&gt; class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Generic subclass of the [`DataScript`](DataScript.md)

```csharp
public abstract class DataScript<TData> : DataScript
    where TData : class
```

| parameter | description |
| --- | --- |
| TData | Data type |

## Protected Members

| name | description |
| --- | --- |
| [DataScript](DataScript-1/DataScript.md)() | Creates a new instance of the class |
| abstract [GetData](DataScript-1/GetData.md)() | Gets the data object |

## See Also

* class [DataScript](DataScript.md)
* **Source:** *[DataScriptT.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/DataScriptT.cs)*