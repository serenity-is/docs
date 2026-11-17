# TargetDBAttribute constructor

Marks a migration to run only on the specified database type.

```csharp
public TargetDBAttribute(string db)
```

## Remarks

Both the [`TagPrefix`](./TagPrefix.md) and a legacy `DatabaseKey + "DB"` form of the tag are declared, so data migrations that still generate the requested tags in the legacy form (e.g. `DefaultDB`) keep matching. As TagsAttribute is applied once and the behavior is RequireAny, the extra tag cannot restrict matching for runners that do not group tags by dimension.

## See Also

* class [TargetDBAttribute](../TargetDBAttribute.md)