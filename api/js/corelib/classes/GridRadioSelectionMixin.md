[@serenity-is/corelib](../README.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

## Constructors

### new GridRadioSelectionMixin()

> **new GridRadioSelectionMixin**(`grid`, `options`?): [`GridRadioSelectionMixin`](GridRadioSelectionMixin.md)

#### Parameters

##### grid

[`IDataGrid`](../interfaces/IDataGrid.md)

##### options?

[`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md)

#### Returns

[`GridRadioSelectionMixin`](GridRadioSelectionMixin.md)

#### Defined in

[src/ui/helpers/slickhelpers.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L179)

## Methods

### clear()

> **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L218)

***

### getSelectedAsInt32()

> **getSelectedAsInt32**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L236)

***

### getSelectedAsInt64()

> **getSelectedAsInt64**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L248)

***

### getSelectedKey()

> **getSelectedKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L227)

***

### resetCheckedAndRefresh()

> **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L222)

***

### setSelectedKey()

> **setSelectedKey**(`key`): `void`

#### Parameters

##### key

`string`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L260)

***

### createSelectColumn()

> `static` **createSelectColumn**(`getMixin`): `Column`\<`any`\>

#### Parameters

##### getMixin

() => [`GridRadioSelectionMixin`](GridRadioSelectionMixin.md)

#### Returns

`Column`\<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.tsx:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.tsx#L265)
