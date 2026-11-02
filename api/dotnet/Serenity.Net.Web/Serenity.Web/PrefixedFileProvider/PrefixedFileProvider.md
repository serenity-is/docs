# PrefixedFileProvider constructor

A file provider that exposes the contents of another file provider under a path prefix, e.g. files of a package's wwwroot under "/Serenity.Corelib".

```csharp
public PrefixedFileProvider(string prefix, IFileProvider inner)
```

| parameter | description |
| --- | --- |
| prefix | Path prefix, like "Serenity.Corelib" or "/Serenity.Corelib" |
| inner | Provider for the files under the prefix |

## See Also

* class [PrefixedFileProvider](../PrefixedFileProvider.md)