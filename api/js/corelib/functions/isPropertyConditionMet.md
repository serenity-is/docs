[@serenity-is/corelib](../README.md) / isPropertyConditionMet

# Function: isPropertyConditionMet()

> **isPropertyConditionMet**(`condition`, `value`): `boolean`

Defined in: [src/ui/widgets/propertyconditions.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertyconditions.ts#L34)

Gets whether the value of a field meets a condition: it has one of the values of the condition, compared as text,
or a list value has one of them as an item, or, without values, it has a value at all, see [hasPropertyValue](hasPropertyValue.md).
The result is the opposite for a condition with `isNot`.

## Parameters

### condition

[`PropertyCondition`](../interfaces/PropertyCondition.md)

The condition.

### value

`any`

The value of the field the condition is on.

## Returns

`boolean`
