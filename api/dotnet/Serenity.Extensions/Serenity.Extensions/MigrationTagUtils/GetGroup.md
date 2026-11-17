# MigrationTagUtils.GetGroup method

Gets the dimension of a tag as written, e.g. `db` for `db:Default`, `env` for `env:Staging`, and an empty string for a tag that has no dimension, e.g. `Core` or the legacy `DefaultDB`.

```csharp
public static string GetGroup(string? tag)
```

| parameter | description |
| --- | --- |
| tag | The tag. Can be `null` or empty. |

## Return Value

The dimension of the tag.

## Remarks

This is the dimension of the tag's syntax, so a legacy `DefaultDB` tag is reported as having no dimension, even though [`MatchesTags`](./MatchesTags.md) treats it as `db:Default` when that database is requested by the migration runner.

## See Also

* class [MigrationTagUtils](../MigrationTagUtils.md)