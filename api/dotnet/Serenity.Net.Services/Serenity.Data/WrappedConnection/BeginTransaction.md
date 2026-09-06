# WrappedConnection.BeginTransaction method (1 of 2)

Begins a database transaction.

```csharp
public IDbTransaction BeginTransaction()
```

## Return Value

An object representing the new transaction.

## See Also

* class [WrappedConnection](../WrappedConnection.md)

---

# WrappedConnection.BeginTransaction method (2 of 2)

Begins a database transaction with the specified IsolationLevel value.

```csharp
public IDbTransaction BeginTransaction(IsolationLevel il)
```

| parameter | description |
| --- | --- |
| il | One of the IsolationLevel values. |

## Return Value

An object representing the new transaction.

## See Also

* class [WrappedConnection](../WrappedConnection.md)