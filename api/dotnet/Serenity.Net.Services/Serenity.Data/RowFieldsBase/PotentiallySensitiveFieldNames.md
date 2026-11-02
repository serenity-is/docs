# RowFieldsBase.PotentiallySensitiveFieldNames field

Field names that are potentially sensitive (e.g. password hash, secret, API key, 2FA data), and thus should not be selected, filtered, sorted, inserted or updated by default unless the developer explicitly allows it via the corresponding attributes. This is a name based heuristic: rows implementing interfaces like [`IPasswordRow`](../IPasswordRow.md) are additionally protected in request handlers, as their sensitive fields may have arbitrary names.

```csharp
public static readonly IReadOnlySet<string> PotentiallySensitiveFieldNames;
```

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)