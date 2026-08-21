[@serenity-is/corelib](../README.md) / AttributeSpecifier

# Type Alias: AttributeSpecifier

> **AttributeSpecifier** = [`CustomAttribute`](../classes/CustomAttribute.md) \| () => [`CustomAttribute`](../classes/CustomAttribute.md) \| () => [`CustomAttribute`](../classes/CustomAttribute.md)

Defined in: [src/base/system.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L590)

Union of forms accepted where an attribute can be specified: an attribute instance, an attribute class (instantiated with `new`), or a factory function returning an attribute. Factories are marked with `isAttributeFactory === true`.
