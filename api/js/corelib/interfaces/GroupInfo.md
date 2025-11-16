[serenity-is/corelib](../README.md) / GroupInfo

# Interface: GroupInfo\<TItem\>

Defined in: [src/slick/slicktypes.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L24)

## Type Parameters

### TItem

`TItem`

## Properties

### aggregateChildGroups?

> `optional` **aggregateChildGroups**: `boolean`

Defined in: [src/slick/slicktypes.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L37)

***

### aggregateCollapsed?

> `optional` **aggregateCollapsed**: `boolean`

Defined in: [src/slick/slicktypes.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L38)

***

### aggregateEmpty?

> `optional` **aggregateEmpty**: `boolean`

Defined in: [src/slick/slicktypes.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L39)

***

### aggregators?

> `optional` **aggregators**: [`IAggregator`](IAggregator.md)[]

Defined in: [src/slick/slicktypes.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L36)

***

### collapsed?

> `optional` **collapsed**: `boolean`

Defined in: [src/slick/slicktypes.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L40)

***

### comparer()?

> `optional` **comparer**: (`a`, `b`) => `number`

Defined in: [src/slick/slicktypes.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L35)

#### Parameters

##### a

`Group`\<`TItem`\>

##### b

`Group`\<`TItem`\>

#### Returns

`number`

***

### displayTotalsRow?

> `optional` **displayTotalsRow**: `boolean`

Defined in: [src/slick/slicktypes.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L41)

***

### format()?

> `optional` **format**: (`ctx`) => `FormatterResult`

Defined in: [src/slick/slicktypes.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L32)

The format function for the group value. Note that the group item is in ctx.item and its value 
is in ctx.item.value, not in ctx.value as it is set by the grid to ctx.item["__groupdisplaycolumnfield__"]
so never use or rely on ctx.value here!

#### Parameters

##### ctx

`FormatterContext`\<`Group`\<`TItem`\>\>

#### Returns

`FormatterResult`

***

### formatter()?

> `optional` **formatter**: (`group`) => `string`

Defined in: [src/slick/slicktypes.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L34)

#### Parameters

##### group

`Group`\<`TItem`\>

#### Returns

`string`

#### Obsolete

use format

***

### getter?

> `optional` **getter**: `string` \| (`item`) => `any`

Defined in: [src/slick/slicktypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L25)

***

### getterIsAFn?

> `optional` **getterIsAFn**: `boolean`

Defined in: [src/slick/slicktypes.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L26)

***

### lazyTotalsCalculation?

> `optional` **lazyTotalsCalculation**: `boolean`

Defined in: [src/slick/slicktypes.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L42)

***

### predefinedValues?

> `optional` **predefinedValues**: `any`[]

Defined in: [src/slick/slicktypes.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L43)
