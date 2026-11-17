# StringEnumMember constructor

Initializes a new instance of the [`StringEnumMember`](../StringEnumMember.md) class.

```csharp
public StringEnumMember(string name, string value, string? textKey, string? text, bool isVisible)
```

| parameter | description |
| --- | --- |
| name | The name of the member, which is the name of its field. |
| value | The string value of the member. |
| textKey | The local text key of the member, if it has a text attribute with a key. |
| text | The invariant text of the member, if it has a text attribute. |
| isVisible | Whether the member is sent to the client, i.e. it is not hidden with [`IgnoreUIFieldAttribute`](../../Serenity.ComponentModel/IgnoreUIFieldAttribute.md) or [`TransformIgnoreAttribute`](../../Serenity.ComponentModel/TransformIgnoreAttribute.md). |

## See Also

* class [StringEnumMember](../StringEnumMember.md)