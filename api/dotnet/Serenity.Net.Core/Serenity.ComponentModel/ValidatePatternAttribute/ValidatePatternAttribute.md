# ValidatePatternAttribute constructor

Requires a text to match a regular expression as a whole, which the forms also check. The expression is matched with ECMAScript semantics on the server, as the browsers match it, so it should only use what both have, e.g. no named groups or lookbehinds. An empty value is valid, as being required is [`RequiredAttribute`](../RequiredAttribute.md)'s concern.

```csharp
public ValidatePatternAttribute(string pattern)
```

| parameter | description |
| --- | --- |
| pattern | The regular expression, without anchors, as the whole text has to match it. |

## See Also

* class [ValidatePatternAttribute](../ValidatePatternAttribute.md)