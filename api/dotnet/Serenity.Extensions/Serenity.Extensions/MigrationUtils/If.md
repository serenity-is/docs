# MigrationUtils.If&lt;TSyntax&gt; method

Invokes the callback only when the predicate is true, otherwise returns the syntax unchanged.

```csharp
public static TSyntax If<TSyntax>(this TSyntax syntax, bool predicate, 
    Func<TSyntax, TSyntax> callback)
    where TSyntax : IFluentSyntax
```

| parameter | description |
| --- | --- |
| TSyntax | The fluent syntax type. |
| syntax | The syntax builder. |
| predicate | The condition to evaluate. |
| callback | The callback to invoke when the predicate is true. |

## Return Value

The syntax builder.

## See Also

* class [MigrationUtils](../MigrationUtils.md)