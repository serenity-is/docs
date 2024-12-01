[@serenity-is/corelib](../README.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

## Constructors

### new GridRowSelectionMixin()

> **new GridRowSelectionMixin**(`grid`, `options`?): [`GridRowSelectionMixin`](GridRowSelectionMixin.md)

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

##### options?

[`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md)

#### Returns

[`GridRowSelectionMixin`](GridRowSelectionMixin.md)

#### Defined in

[src/ui/helpers/slickhelpers.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L27)

## Methods

### clear()

> **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L94)

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L117)

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L123)

***

### getSelectedKeys()

> **getSelectedKeys**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/helpers/slickhelpers.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L113)

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L99)

***

### selectKeys()

> **selectKeys**(`keys`): `void`

#### Parameters

##### keys

`string`[]

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L105)

***

### setSelectedKeys()

> **setSelectedKeys**(`keys`): `void`

#### Parameters

##### keys

`string`[]

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L129)

***

### updateSelectAll()

> **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L81)

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`): `Column`\<`any`\>

#### Parameters

##### getMixin

() => [`GridRowSelectionMixin`](GridRowSelectionMixin.md)

#### Returns

`Column`\<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L144)
