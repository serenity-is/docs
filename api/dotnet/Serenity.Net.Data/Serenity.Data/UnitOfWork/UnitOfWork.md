# UnitOfWork constructor (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`UnitOfWork`](../UnitOfWork.md) class.

```csharp
public UnitOfWork(IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |

## See Also

* class [UnitOfWork](../UnitOfWork.md)

---

# UnitOfWork constructor (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`UnitOfWork`](../UnitOfWork.md) class.

```csharp
public UnitOfWork(IDbConnection connection, bool deferStart)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| deferStart | Defers starting of the transaction until the connection is opened if it has a statechange event, or the first moment connection property is read. If the connection is already open this flag has no effect. If the passed connection does not have a statechange event and is accessed somewhere else (e.g. other than via the UnitOfWork.Connection property), it may cause consistency issues so ensure it is not accessed via other means. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |
| ArgumentNullException | connection |

## See Also

* class [UnitOfWork](../UnitOfWork.md)

---

# UnitOfWork constructor (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`UnitOfWork`](../UnitOfWork.md) class with the specified System.Data.IsolationLevel value.

```csharp
public UnitOfWork(IDbConnection connection, IsolationLevel il, bool deferStart = false)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| il | One of the IsolationLevel values. |
| deferStart | Defers starting of the transaction until the connection is opened if it has a statechange event, or the first moment connection property is read. If the connection is already open this flag has no effect. If the passed connection does not have a statechange event and is accessed somewhere else (e.g. other than via the UnitOfWork.Connection property), it may cause consistency issues so ensure it is not accessed via other means. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |

## See Also

* class [UnitOfWork](../UnitOfWork.md)