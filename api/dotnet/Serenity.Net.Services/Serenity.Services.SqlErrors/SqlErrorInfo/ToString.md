# SqlErrorInfo.ToString method

Formats this error info as a localized validation message.

```csharp
public string ToString(ITextLocalizer localizer, SqlErrorFormatOptions? options = null)
```

| parameter | description |
| --- | --- |
| localizer | Text localizer. |
| options | Optional formatting options, e.g. the operation that caused the error. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *localizer* is `null`. |

## See Also

* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [SqlErrorFormatOptions](../SqlErrorFormatOptions.md)
* class [SqlErrorInfo](../SqlErrorInfo.md)