# MethodChainingExtensions.With&lt;TChain&gt; method (1 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself without breaking a call chain.

```csharp
public static TChain With<TChain>(this TChain chain, Action<TChain> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as parameter. |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1&gt; method (2 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring an inline object without breaking a call chain.

```csharp
public static TChain With<TChain, TParam1>(this TChain chain, TParam1 param1, 
    Action<TChain, TParam1> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2&gt; method (3 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring two inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2>(this TChain chain, TParam1 param1, 
    TParam2 param2, Action<TChain, TParam1, TParam2> action)
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3&gt; method (4 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring three inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2, TParam3>(this TChain chain, TParam1 param1, 
    TParam2 param2, TParam3 param3, Action<TChain, TParam1, TParam2, TParam3> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4&gt; method (5 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring four inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2, TParam3, TParam4>(this TChain chain, 
    TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4,TParam5&gt; method (6 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring five inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2, TParam3, TParam4, TParam5>(this TChain chain, 
    TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4, TParam5> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |
| param5 | An object that will be passed to action as sixth parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* class [TParam5](../Serenity.Net.Data/../MethodChainingExtensions.TParam5.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4,TParam5,TParam6&gt; method (7 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring six inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(
    this TChain chain, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, 
    TParam5 param5, TParam6 param6, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |
| param5 | An object that will be passed to action as sixth parameter |
| param6 | An object that will be passed to action as seventh parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* class [TParam5](../Serenity.Net.Data/../MethodChainingExtensions.TParam5.md)
* class [TParam6](../Serenity.Net.Data/../MethodChainingExtensions.TParam6.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4,TParam5,TParam6,TParam7&gt; method (8 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring seven inline objects without breaking call chain.

```csharp
public static TChain With<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(
    this TChain chain, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, 
    TParam5 param5, TParam6 param6, TParam7 param7, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |
| param5 | An object that will be passed to action as sixth parameter |
| param6 | An object that will be passed to action as seventh parameter |
| param7 | An object that will be passed to action as eight parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* class [TParam5](../Serenity.Net.Data/../MethodChainingExtensions.TParam5.md)
* class [TParam6](../Serenity.Net.Data/../MethodChainingExtensions.TParam6.md)
* class [TParam7](../Serenity.Net.Data/../MethodChainingExtensions.TParam7.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4,TParam5,TParam6,TParam7,TParam8&gt; method (9 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring seven inline objects without breaking call chain.

```csharp
public static TChain 
    With<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
    this TChain chain, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, 
    TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |
| param5 | An object that will be passed to action as sixth parameter |
| param6 | An object that will be passed to action as seventh parameter |
| param7 | An object that will be passed to action as eight parameter |
| param8 | An object that will be passed to action as ninth parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* class [TParam5](../Serenity.Net.Data/../MethodChainingExtensions.TParam5.md)
* class [TParam6](../Serenity.Net.Data/../MethodChainingExtensions.TParam6.md)
* class [TParam7](../Serenity.Net.Data/../MethodChainingExtensions.TParam7.md)
* class [TParam8](../Serenity.Net.Data/../MethodChainingExtensions.TParam8.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)

---

# MethodChainingExtensions.With&lt;TChain,TParam1,TParam2,TParam3,TParam4,TParam5,TParam6,TParam7,TParam8,TParam9&gt; method (10 of 10)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself, while declaring seven inline objects without breaking call chain.

```csharp
public static TChain 
    With<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(
    this TChain chain, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, 
    TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, 
    Action<TChain, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as first parameter. |
| param1 | An object that will be passed to action as second parameter |
| param2 | An object that will be passed to action as third parameter |
| param3 | An object that will be passed to action as fourth parameter |
| param4 | An object that will be passed to action as fifth parameter |
| param5 | An object that will be passed to action as sixth parameter |
| param6 | An object that will be passed to action as seventh parameter |
| param7 | An object that will be passed to action as eight parameter |
| param8 | An object that will be passed to action as ninth parameter |
| param9 | An object that will be passed to action as tenth parameter |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../MethodChainingExtensions.TChain.md)
* class [TParam1](../Serenity.Net.Data/../MethodChainingExtensions.TParam1.md)
* class [TParam2](../Serenity.Net.Data/../MethodChainingExtensions.TParam2.md)
* class [TParam3](../Serenity.Net.Data/../MethodChainingExtensions.TParam3.md)
* class [TParam4](../Serenity.Net.Data/../MethodChainingExtensions.TParam4.md)
* class [TParam5](../Serenity.Net.Data/../MethodChainingExtensions.TParam5.md)
* class [TParam6](../Serenity.Net.Data/../MethodChainingExtensions.TParam6.md)
* class [TParam7](../Serenity.Net.Data/../MethodChainingExtensions.TParam7.md)
* class [TParam8](../Serenity.Net.Data/../MethodChainingExtensions.TParam8.md)
* class [TParam9](../Serenity.Net.Data/../MethodChainingExtensions.TParam9.md)
* interface [IChainable](../IChainable.md)
* class [MethodChainingExtensions](../MethodChainingExtensions.md)