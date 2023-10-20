[@serenity-is/corelib](../README.md) / DecimalFiltering

# Class: DecimalFiltering

## Hierarchy

- [`BaseEditorFiltering`](BaseEditorFiltering.md)<[`DecimalEditor`](DecimalEditor.md)\>

  ↳ **`DecimalFiltering`**

## Table of contents

### Constructors

- [constructor](DecimalFiltering.md#constructor)

### Properties

- [editor](DecimalFiltering.md#editor)
- [editorType](DecimalFiltering.md#editortype)

### Methods

- [appendComparisonOperators](DecimalFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](DecimalFiltering.md#appendnullableoperators)
- [argumentNull](DecimalFiltering.md#argumentnull)
- [createEditor](DecimalFiltering.md#createeditor)
- [displayText](DecimalFiltering.md#displaytext)
- [getCriteria](DecimalFiltering.md#getcriteria)
- [getCriteriaField](DecimalFiltering.md#getcriteriafield)
- [getEditorOptions](DecimalFiltering.md#geteditoroptions)
- [getEditorText](DecimalFiltering.md#geteditortext)
- [getEditorValue](DecimalFiltering.md#geteditorvalue)
- [getOperators](DecimalFiltering.md#getoperators)
- [getTitle](DecimalFiltering.md#gettitle)
- [get\_container](DecimalFiltering.md#get_container)
- [get\_field](DecimalFiltering.md#get_field)
- [get\_operator](DecimalFiltering.md#get_operator)
- [initQuickFilter](DecimalFiltering.md#initquickfilter)
- [isNullable](DecimalFiltering.md#isnullable)
- [loadState](DecimalFiltering.md#loadstate)
- [operatorFormat](DecimalFiltering.md#operatorformat)
- [saveState](DecimalFiltering.md#savestate)
- [set\_container](DecimalFiltering.md#set_container)
- [set\_field](DecimalFiltering.md#set_field)
- [set\_operator](DecimalFiltering.md#set_operator)
- [useEditor](DecimalFiltering.md#useeditor)
- [useIdField](DecimalFiltering.md#useidfield)
- [validateEditorValue](DecimalFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new DecimalFiltering**()

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[constructor](BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L483)

## Properties

### editor

• `Protected` **editor**: [`DecimalEditor`](DecimalEditor.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[editor](BaseEditorFiltering.md#editor)

#### Defined in

[src/ui/filtering/filtering.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L315)

___

### editorType

• **editorType**: `any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[editorType](BaseEditorFiltering.md#editortype)

#### Defined in

[src/ui/filtering/filtering.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L298)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[appendComparisonOperators](BaseEditorFiltering.md#appendcomparisonoperators)

#### Defined in

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L92)

___

### appendNullableOperators

▸ `Protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[appendNullableOperators](BaseEditorFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[argumentNull](BaseEditorFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[createEditor](BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L317)

___

### displayText

▸ `Protected` **displayText**(`op`, `values?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |
| `values?` | `any`[] |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[displayText](BaseEditorFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getCriteria](BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getCriteriaField](BaseEditorFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L335)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorOptions](BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L345)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorText](BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L269)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorValue](BaseEditorFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L373)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[getOperators](BaseEditorFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L487)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getTitle](BaseEditorFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_container](BaseEditorFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_field](BaseEditorFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_operator](BaseEditorFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L73)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/QuickFilter.md)<[`Widget`](Widget.md)<`any`\>, `any`\> |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[initQuickFilter](BaseEditorFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L386)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[isNullable](BaseEditorFiltering.md#isnullable)

#### Defined in

[src/ui/filtering/filtering.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L102)

___

### loadState

▸ **loadState**(`state`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `state` | `any` |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[loadState](BaseEditorFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L352)

___

### operatorFormat

▸ `Protected` **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[operatorFormat](BaseEditorFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[saveState](BaseEditorFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L365)

___

### set\_container

▸ **set_container**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `JQuery` |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[set_container](BaseEditorFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L67)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[set_field](BaseEditorFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L57)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[set_operator](BaseEditorFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L77)

___

### useEditor

▸ `Protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[useEditor](BaseEditorFiltering.md#useeditor)

#### Defined in

[src/ui/filtering/filtering.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L302)

___

### useIdField

▸ `Protected` **useIdField**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[useIdField](BaseEditorFiltering.md#useidfield)

#### Defined in

[src/ui/filtering/filtering.ts:331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L331)

___

### validateEditorValue

▸ **validateEditorValue**(`value`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[validateEditorValue](BaseEditorFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)
