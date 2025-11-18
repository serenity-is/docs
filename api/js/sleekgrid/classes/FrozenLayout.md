[@serenity-is/sleekgrid](../README.md) / FrozenLayout

# Class: FrozenLayout

Defined in: [src/layouts/frozen-layout.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L7)

## Implements

- [`LayoutEngine`](../interfaces/LayoutEngine.md)

## Constructors

### Constructor

> **new FrozenLayout**(): `FrozenLayout`

#### Returns

`FrozenLayout`

## Properties

### layoutName

> `readonly` **layoutName**: `"FrozenLayout"` = `"FrozenLayout"`

Defined in: [src/layouts/frozen-layout.tsx:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L61)

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`layoutName`](../interfaces/LayoutEngine.md#layoutname)

***

### supportFrozenRows

> **supportFrozenRows**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L64)

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportFrozenRows`](../interfaces/LayoutEngine.md#supportfrozenrows)

***

### supportPinnedCols

> **supportPinnedCols**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:63](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L63)

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportPinnedCols`](../interfaces/LayoutEngine.md#supportpinnedcols)

## Methods

### adjustFrozenRowsOption()

> **adjustFrozenRowsOption**(): `void`

Defined in: [src/layouts/frozen-layout.tsx:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L52)

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`adjustFrozenRowsOption`](../interfaces/LayoutEngine.md#adjustfrozenrowsoption)

***

### afterSetOptions()

> **afterSetOptions**(`arg`): `void`

Defined in: [src/layouts/frozen-layout.tsx:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L42)

#### Parameters

##### arg

[`GridOptions`](../interfaces/GridOptions.md)

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`afterSetOptions`](../interfaces/LayoutEngine.md#aftersetoptions)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/layouts/frozen-layout.tsx:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L57)

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`destroy`](../interfaces/LayoutEngine.md#destroy)

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/frozen-layout.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L11)

#### Parameters

##### host

[`LayoutHost`](../interfaces/LayoutHost.md)

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`init`](../interfaces/LayoutEngine.md#init)

***

### reorderViewColumns()

> **reorderViewColumns**(`viewCols`, `refs`): [`Column`](../interfaces/Column.md)\<`any`\>[]

Defined in: [src/layouts/frozen-layout.tsx:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L34)

this might be called before init, chicken egg situation

#### Parameters

##### viewCols

[`Column`](../interfaces/Column.md)\<`any`\>[]

##### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

#### Returns

[`Column`](../interfaces/Column.md)\<`any`\>[]

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`reorderViewColumns`](../interfaces/LayoutEngine.md#reorderviewcolumns)
