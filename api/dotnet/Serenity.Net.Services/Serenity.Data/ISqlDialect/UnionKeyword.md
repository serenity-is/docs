# ISqlDialect.UnionKeyword method

Gets the union keyword for the specified union type.

```csharp
public string UnionKeyword(SqlUnionType unionType)
```

| parameter | description |
| --- | --- |
| unionType | Type of the union. |

## Return Value

The union keyword.

## Remarks

Throws NotImplementedException for union types the dialect doesn't support (e.g. INTERSECT / EXCEPT on MySQL and Firebird).

## See Also

* enum [SqlUnionType](../SqlUnionType.md)
* interface [ISqlDialect](../ISqlDialect.md)