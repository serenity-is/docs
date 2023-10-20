[@serenity-is/corelib](../README.md) / DateTimeFiltering

# Class: DateTimeFiltering

## Hierarchy

- [`BaseEditorFiltering`](BaseEditorFiltering.md)<[`DateEditor`](DateEditor.md)\>

  ↳ **`DateTimeFiltering`**

## Table of contents

### Constructors

- [constructor](DateTimeFiltering.md#constructor)

### Properties

- [editor](DateTimeFiltering.md#editor)
- [editorType](DateTimeFiltering.md#editortype)

### Methods

- [appendComparisonOperators](DateTimeFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](DateTimeFiltering.md#appendnullableoperators)
- [argumentNull](DateTimeFiltering.md#argumentnull)
- [createEditor](DateTimeFiltering.md#createeditor)
- [displayText](DateTimeFiltering.md#displaytext)
- [getCriteria](DateTimeFiltering.md#getcriteria)
- [getCriteriaField](DateTimeFiltering.md#getcriteriafield)
- [getEditorOptions](DateTimeFiltering.md#geteditoroptions)
- [getEditorText](DateTimeFiltering.md#geteditortext)
- [getEditorValue](DateTimeFiltering.md#geteditorvalue)
- [getOperators](DateTimeFiltering.md#getoperators)
- [getTitle](DateTimeFiltering.md#gettitle)
- [get\_container](DateTimeFiltering.md#get_container)
- [get\_field](DateTimeFiltering.md#get_field)
- [get\_operator](DateTimeFiltering.md#get_operator)
- [initQuickFilter](DateTimeFiltering.md#initquickfilter)
- [isNullable](DateTimeFiltering.md#isnullable)
- [loadState](DateTimeFiltering.md#loadstate)
- [operatorFormat](DateTimeFiltering.md#operatorformat)
- [saveState](DateTimeFiltering.md#savestate)
- [set\_container](DateTimeFiltering.md#set_container)
- [set\_field](DateTimeFiltering.md#set_field)
- [set\_operator](DateTimeFiltering.md#set_operator)
- [useEditor](DateTimeFiltering.md#useeditor)
- [useIdField](DateTimeFiltering.md#useidfield)
- [validateEditorValue](DateTimeFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new DateTimeFiltering**()

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[constructor](BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L419)

## Properties

### editor

• `Protected` **editor**: [`DateEditor`](DateEditor.md)

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

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[getCriteria](BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L428)

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

[src/ui/filtering/filtering.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L423)

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
