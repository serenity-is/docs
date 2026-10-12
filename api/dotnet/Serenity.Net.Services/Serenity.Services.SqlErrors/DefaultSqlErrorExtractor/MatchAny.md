# DefaultSqlErrorExtractor.MatchAny method

Returns the first successful match from the passed regex array, or `null`.

```csharp
protected static Match? MatchAny(string message, Regex[] regexes)
```

| parameter | description |
| --- | --- |
| message | Message to match. |
| regexes | Regexes to try in order. |

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)