[serenity-is/sleekgrid](../README.md) / LayoutEngine

# Interface: LayoutEngine

Defined in: [src/layouts/layout-engine.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L6)

## Properties

### layoutName

> **layoutName**: `string`

Defined in: [src/layouts/layout-engine.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L7)

***

### supportFrozenBottom?

> `optional` **supportFrozenBottom**: `boolean`

Defined in: [src/layouts/layout-engine.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L17)

***

### supportFrozenRows?

> `optional` **supportFrozenRows**: `boolean`

Defined in: [src/layouts/layout-engine.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L16)

***

### supportPinnedCols?

> `optional` **supportPinnedCols**: `boolean`

Defined in: [src/layouts/layout-engine.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L14)

***

### supportPinnedEnd?

> `optional` **supportPinnedEnd**: `boolean`

Defined in: [src/layouts/layout-engine.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L15)

## Methods

### adjustFrozenRowsOption()?

> `optional` **adjustFrozenRowsOption**(): `void`

Defined in: [src/layouts/layout-engine.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L10)

#### Returns

`void`

***

### afterSetOptions()

> **afterSetOptions**(`args`): `void`

Defined in: [src/layouts/layout-engine.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L11)

#### Parameters

##### args

[`GridOptions`](GridOptions.md)

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/layouts/layout-engine.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L9)

#### Returns

`void`

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/layout-engine.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L8)

#### Parameters

##### host

[`LayoutHost`](LayoutHost.md)

#### Returns

`void`

***

### reorderViewColumns()?

> `optional` **reorderViewColumns**(`viewCols`, `refs`): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/layouts/layout-engine.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L13)

this might be called before init, chicken egg situation

#### Parameters

##### viewCols

[`Column`](Column.md)\<`any`\>[]

##### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

#### Returns

[`Column`](Column.md)\<`any`\>[]
