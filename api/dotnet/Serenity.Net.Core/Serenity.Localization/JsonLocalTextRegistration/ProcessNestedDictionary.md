# JsonLocalTextRegistration.ProcessNestedDictionary&lt;TValue&gt; method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts translations from a hierarchical local text dictionary to a simple dictionary.

```csharp
public static void ProcessNestedDictionary<TValue>(IDictionary<string, TValue> nested, 
    string prefix, Dictionary<string, string> target)
```

| parameter | description |
| --- | --- |
| nested | The object parsed from the local text JSON string. |
| prefix | The prefix to prepend before local text keys. |
| target | The target dictionary that will contain the keys and translations. |

## See Also

* class [TValue](../Serenity.Net.Core/../JsonLocalTextRegistration.TValue.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)