# CaptureLogAttribute constructor

Enables capture logging for a row type.

```csharp
public CaptureLogAttribute(Type logRow)
```

| parameter | description |
| --- | --- |
| logRow | The log row type used for this row type the attribute is placed on. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *logRow* is `null`. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* class [CaptureLogAttribute](../CaptureLogAttribute.md)