# ValidationRuleAttribute.Rule property

Gets the type key of the class of the rule on the client side, the one given to the constructor, or else the one of the attribute by the convention of [`GetConventionalRule`](./GetConventionalRule.md). A rule that overrides it to give another key is not found by the server typings generator, so its class is loaded on demand, if it implements LazyLoadInclude.

```csharp
public virtual string Rule { get; }
```

## See Also

* class [ValidationRuleAttribute](../ValidationRuleAttribute.md)