[sleekgrid](../README.md) / GroupItemMetadataProvider

# Class: GroupItemMetadataProvider

Defined in: [src/data/groupitemmetadataprovider.tsx:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L26)

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)

## Constructors

### Constructor

> **new GroupItemMetadataProvider**(`opt?`): `GroupItemMetadataProvider`

Defined in: [src/data/groupitemmetadataprovider.tsx:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L30)

#### Parameters

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

`GroupItemMetadataProvider`

## Properties

### getGroupRowMetadata()

> **getGroupRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:223](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L223)

#### Parameters

##### item

[`Group`](Group.md)

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)

***

### getTotalsRowMetadata()

> **getTotalsRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:247](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L247)

#### Parameters

##### item

[`IGroupTotals`](../interfaces/IGroupTotals.md)

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)

***

### grid

> `protected` **grid**: [`ISleekGrid`](../interfaces/ISleekGrid.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L27)

***

### pluginName

> `readonly` **pluginName**: `"GroupItemMetadataProvider"` = `"GroupItemMetadataProvider"`

Defined in: [src/data/groupitemmetadataprovider.tsx:107](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L107)

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`pluginName`](../interfaces/GridPlugin.md#pluginname)

***

### defaults

> `readonly` `static` **defaults**: [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L38)

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:109](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L109)

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`destroy`](../interfaces/GridPlugin.md#destroy)

***

### getOptions()

> **getOptions**(): [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:116](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L116)

#### Returns

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

***

### groupCellPosition()

> **groupCellPosition**(): `object`

Defined in: [src/data/groupitemmetadataprovider.tsx:186](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L186)

#### Returns

`object`

##### cell

> **cell**: `number` = `0`

##### colspan

> **colspan**: `number` \| `"*"`

***

### handleGridClick()

> **handleGridClick**(`e`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:124](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L124)

#### Parameters

##### e

[`CellMouseEvent`](../type-aliases/CellMouseEvent.md)

#### Returns

`void`

***

### handleGridKeyDown()

> **handleGridKeyDown**(`e`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L150)

#### Parameters

##### e

[`CellKeyboardEvent`](../type-aliases/CellKeyboardEvent.md)

#### Returns

`void`

***

### init()

> **init**(`grid`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L101)

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

#### Returns

`void`

#### Implementation of

[`GridPlugin`](../interfaces/GridPlugin.md).[`init`](../interfaces/GridPlugin.md#init)

***

### setOptions()

> **setOptions**(`value`): `void`

Defined in: [src/data/groupitemmetadataprovider.tsx:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L120)

#### Parameters

##### value

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

`void`

***

### defaultGroupFormat()

> `static` **defaultGroupFormat**(`ctx`, `opt?`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L54)

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### defaultTotalsFormat()

> `static` **defaultTotalsFormat**(`ctx`, `grid?`): [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/data/groupitemmetadataprovider.tsx:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L85)

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)

##### grid?

[`ISleekGrid`](../interfaces/ISleekGrid.md)

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)
