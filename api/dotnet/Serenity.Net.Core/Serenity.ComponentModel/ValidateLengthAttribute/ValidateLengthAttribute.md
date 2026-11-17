# ValidateLengthAttribute constructor

Requires a text to have no more than a number of characters, and no fewer than MinimumLength when it is set, which the forms also check. An empty value is valid, as being required is [`RequiredAttribute`](../RequiredAttribute.md)'s concern.

```csharp
public ValidateLengthAttribute(int maximumLength)
```

| parameter | description |
| --- | --- |
| maximumLength | The most characters the text can have. |

## See Also

* class [ValidateLengthAttribute](../ValidateLengthAttribute.md)