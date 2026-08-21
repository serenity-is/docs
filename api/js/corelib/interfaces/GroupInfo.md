[@serenity-is/corelib](../README.md) / GroupInfo

# Interface: GroupInfo\<TItem\>

Defined in: [src/slick/slicktypes.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L28)

Configuration for a single grouping level.

## Type Parameters

### TItem

`TItem`

## Properties

### aggregateChildGroups?

> `optional` **aggregateChildGroups**: `boolean`

Defined in: [src/slick/slicktypes.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L46)

Whether to aggregate child groups as well.

***

### aggregateCollapsed?

> `optional` **aggregateCollapsed**: `boolean`

Defined in: [src/slick/slicktypes.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L48)

Whether collapsed groups still show aggregates.

***

### aggregateEmpty?

> `optional` **aggregateEmpty**: `boolean`

Defined in: [src/slick/slicktypes.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L50)

Whether empty groups still show aggregates.

***

### aggregators?

> `optional` **aggregators**: [`IAggregator`](IAggregator.md)[]

Defined in: [src/slick/slicktypes.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L44)

Aggregators applied to this group level.

***

### collapsed?

> `optional` **collapsed**: `boolean`

Defined in: [src/slick/slicktypes.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L52)

True if groups start collapsed.

***

### comparer()?

> `optional` **comparer**: (`a`, `b`) => `number`

Defined in: [src/slick/slicktypes.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L42)

Comparator for group ordering.

#### Parameters

##### a

`Group`\<`TItem`\>

First group.

##### b

`Group`\<`TItem`\>

Second group.

#### Returns

`number`

Negative / zero / positive.

***

### displayTotalsRow?

> `optional` **displayTotalsRow**: `boolean`

Defined in: [src/slick/slicktypes.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L54)

True to render a totals row for this level.

***

### format()?

> `optional` **format**: (`ctx`) => `FormatterResult`

Defined in: [src/slick/slicktypes.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L38)

Formats the group header. Note: group value is in `ctx.item.value`, not `ctx.value`.

#### Parameters

##### ctx

`FormatterContext`\<`Group`\<`TItem`\>\>

Formatter context for the group row.

#### Returns

`FormatterResult`

Formatter result.

***

### ~~formatter()?~~

> `optional` **formatter**: (`group`) => `string`

Defined in: [src/slick/slicktypes.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L40)

#### Parameters

##### group

`Group`\<`TItem`\>

Group object.

#### Returns

`string`

Formatted group title.

#### Deprecated

Use `format` instead.

***

### getter?

> `optional` **getter**: `string` \| (`item`) => `any`

Defined in: [src/slick/slicktypes.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L30)

Field name or getter for the group value.

***

### getterIsAFn?

> `optional` **getterIsAFn**: `boolean`

Defined in: [src/slick/slicktypes.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L32)

True if `getter` is a function.

***

### lazyTotalsCalculation?

> `optional` **lazyTotalsCalculation**: `boolean`

Defined in: [src/slick/slicktypes.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L56)

True to calculate totals lazily.

***

### predefinedValues?

> `optional` **predefinedValues**: `any`[]

Defined in: [src/slick/slicktypes.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L58)

Predefined group values to ensure groups exist even without data.
