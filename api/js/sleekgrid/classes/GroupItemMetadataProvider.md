[@serenity-is/sleekgrid](../README.md) / GroupItemMetadataProvider

# Class: GroupItemMetadataProvider

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)

## Constructors

### new GroupItemMetadataProvider()

> **new GroupItemMetadataProvider**(`opt`?): [`GroupItemMetadataProvider`](GroupItemMetadataProvider.md)

#### Parameters

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

[`GroupItemMetadataProvider`](GroupItemMetadataProvider.md)

#### Defined in

[data/groupitemmetadataprovider.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L29)

## Properties

### getGroupRowMetadata()

> **getGroupRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)\<`any`\>

#### Parameters

##### item

[`Group`](Group.md)\<`any`\>

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)\<`any`\>

#### Defined in

[data/groupitemmetadataprovider.ts:193](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L193)

***

### getTotalsRowMetadata()

> **getTotalsRowMetadata**: (`item`) => [`ItemMetadata`](../interfaces/ItemMetadata.md)\<`any`\>

#### Parameters

##### item

[`GroupTotals`](GroupTotals.md)\<`any`\>

#### Returns

[`ItemMetadata`](../interfaces/ItemMetadata.md)\<`any`\>

#### Defined in

[data/groupitemmetadataprovider.ts:217](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L217)

***

### grid

> `protected` **grid**: [`Grid`](Grid.md)\<`any`\>

#### Defined in

[data/groupitemmetadataprovider.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L26)

***

### pluginName

> `readonly` **pluginName**: `"GroupItemMetadataProvider"` = `"GroupItemMetadataProvider"`

#### Implementation of

[`IPlugin`](../interfaces/IPlugin.md).[`pluginName`](../interfaces/IPlugin.md#pluginname)

#### Defined in

[data/groupitemmetadataprovider.ts:77](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L77)

***

### defaults

> `readonly` `static` **defaults**: [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Defined in

[data/groupitemmetadataprovider.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L37)

## Methods

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Implementation of

[`IPlugin`](../interfaces/IPlugin.md).[`destroy`](../interfaces/IPlugin.md#destroy)

#### Defined in

[data/groupitemmetadataprovider.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L79)

***

### getOptions()

> **getOptions**(): [`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Defined in

[data/groupitemmetadataprovider.ts:86](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L86)

***

### groupCellPosition()

> **groupCellPosition**(): `object`

#### Returns

`object`

##### cell

> **cell**: `number` = `0`

##### colspan

> **colspan**: `number` \| `"*"`

#### Defined in

[data/groupitemmetadataprovider.ts:156](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L156)

***

### handleGridClick()

> **handleGridClick**(`e`, `args`): `void`

#### Parameters

##### e

`MouseEvent`

##### args

[`ArgsCell`](../interfaces/ArgsCell.md)

#### Returns

`void`

#### Defined in

[data/groupitemmetadataprovider.ts:94](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L94)

***

### handleGridKeyDown()

> **handleGridKeyDown**(`e`, `args`): `void`

#### Parameters

##### e

`KeyboardEvent`

##### args

[`ArgsCell`](../interfaces/ArgsCell.md)

#### Returns

`void`

#### Defined in

[data/groupitemmetadataprovider.ts:120](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L120)

***

### init()

> **init**(`grid`): `void`

#### Parameters

##### grid

[`Grid`](Grid.md)\<`any`\>

#### Returns

`void`

#### Implementation of

[`IPlugin`](../interfaces/IPlugin.md).[`init`](../interfaces/IPlugin.md#init)

#### Defined in

[data/groupitemmetadataprovider.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L71)

***

### setOptions()

> **setOptions**(`value`): `void`

#### Parameters

##### value

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

`void`

#### Defined in

[data/groupitemmetadataprovider.ts:90](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L90)

***

### defaultGroupFormat()

> `static` **defaultGroupFormat**(`ctx`, `opt`?): `string`

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

##### opt?

[`GroupItemMetadataProviderOptions`](../interfaces/GroupItemMetadataProviderOptions.md)

#### Returns

`string`

#### Defined in

[data/groupitemmetadataprovider.ts:53](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L53)

***

### defaultTotalsFormat()

> `static` **defaultTotalsFormat**(`ctx`, `grid`?): `string`

#### Parameters

##### ctx

[`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

##### grid?

[`Grid`](Grid.md)\<`any`\>

#### Returns

`string`

#### Defined in

[data/groupitemmetadataprovider.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L63)
