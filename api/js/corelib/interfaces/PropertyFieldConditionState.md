[@serenity-is/corelib](../README.md) / PropertyFieldConditionState

# Interface: PropertyFieldConditionState

Defined in: [src/ui/widgets/propertygrid.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L28)

What the conditions of a field, see [PropertyItem.visibleWhen](PropertyItem.md#visiblewhen), [PropertyItem.readOnlyWhen](PropertyItem.md#readonlywhen) and
[PropertyItem.requiredWhen](PropertyItem.md#requiredwhen), make of it for the current values of the other fields. They only add to what the
property item and the mode make of it, e.g. a field hidden by a permission stays hidden.

## Properties

### hidden?

> `optional` **hidden**: `boolean`

Defined in: [src/ui/widgets/propertygrid.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L30)

Whether the field is hidden by a condition of its own, or by one on a field that is hidden by a condition.

***

### readOnly?

> `optional` **readOnly**: `boolean`

Defined in: [src/ui/widgets/propertygrid.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L32)

Whether the field is read only by its conditions.

***

### required?

> `optional` **required**: `boolean`

Defined in: [src/ui/widgets/propertygrid.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L34)

Whether the field is required by its conditions, which a hidden or read only field is not.
