# JsonLocalTextRegistration.ProcessNestedDictionary&lt;TValue&gt; method

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

* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)