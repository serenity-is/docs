[@serenity-is/corelib](../README.md) / PropertyCondition

# Interface: PropertyCondition

Defined in: [src/base/propertyitem.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L39)

A condition on the value of another field of a form, which a field is shown, made read only or required by,
see [PropertyItem.visibleWhen](PropertyItem.md#visiblewhen), [PropertyItem.readOnlyWhen](PropertyItem.md#readonlywhen) and [PropertyItem.requiredWhen](PropertyItem.md#requiredwhen).

## Properties

### field

> **field**: `string`

Defined in: [src/base/propertyitem.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L41)

The name of the field whose value is checked.

***

### isNot?

> `optional` **isNot**: `boolean`

Defined in: [src/base/propertyitem.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L49)

Whether the condition is the opposite, e.g. met when the field has none of the values, or has no value.

***

### values?

> `optional` **values**: `any`[]

Defined in: [src/base/propertyitem.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/propertyitem.ts#L47)

The values that meet the condition, any of which the field can have, compared as text, e.g. `2` and `"2"`, and
a list value matches when any of its items does. Without values, the condition is met when the field has a value,
i.e. one that is not null, an empty string, an empty list or false.
