[@serenity-is/corelib](../README.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L10)

## Constructors

### Constructor

> **new GridRadioSelectionMixin**(`grid`, `options?`): `GridRadioSelectionMixin`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L19)

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

##### options?

[`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md)

#### Returns

`GridRadioSelectionMixin`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L12)

## Methods

### clear()

> **clear**(): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L58)

#### Returns

`void`

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L76)

#### Returns

`number`

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L88)

#### Returns

`number`

***

### getSelectedKey()

> **getSelectedKey**(): `string`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L67)

#### Returns

`string`

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L62)

#### Returns

`void`

***

### setSelectedKey()

> **setSelectedKey**(`key`): `void`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L100)

#### Parameters

##### key

`string`

#### Returns

`void`

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`, `columnOptions?`): `Column`

Defined in: [src/ui/helpers/gridradioselectionmixin.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridradioselectionmixin.tsx#L105)

#### Parameters

##### getMixin

() => `GridRadioSelectionMixin`

##### columnOptions?

`Partial`\<`Column`\>

#### Returns

`Column`
