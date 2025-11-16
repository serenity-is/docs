[serenity-is/corelib](../README.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L12)

## Constructors

### Constructor

> **new GridRowSelectionMixin**(`grid`, `options?`): `GridRowSelectionMixin`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L21)

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

##### options?

[`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md)

#### Returns

`GridRowSelectionMixin`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L14)

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L103)

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L33)

#### Returns

`void`

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L126)

#### Returns

`number`[]

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L132)

#### Returns

`number`[]

***

### getSelectedKeys()

> **getSelectedKeys**(): `string`[]

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L122)

#### Returns

`string`[]

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L108)

#### Returns

`void`

***

### selectKeys()

> **selectKeys**(`keys`): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L114)

#### Parameters

##### keys

`string`[]

#### Returns

`void`

***

### setSelectedKeys()

> **setSelectedKeys**(`keys`): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L138)

#### Parameters

##### keys

`string`[]

#### Returns

`void`

***

### updateSelectAll()

> **updateSelectAll**(): `void`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L90)

#### Returns

`void`

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`, `columnOptions?`): `Column`

Defined in: [src/ui/helpers/gridrowselectionmixin.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridrowselectionmixin.tsx#L153)

#### Parameters

##### getMixin

() => `GridRowSelectionMixin`

##### columnOptions?

`Partial`\<`Column`\>

#### Returns

`Column`
