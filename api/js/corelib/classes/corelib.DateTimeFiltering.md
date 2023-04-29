[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DateTimeFiltering

# Class: DateTimeFiltering

[corelib](../modules/corelib.md).DateTimeFiltering

## Hierarchy

- [`BaseEditorFiltering`](corelib.BaseEditorFiltering.md)<[`DateEditor`](corelib.DateEditor.md)\>

  ↳ **`DateTimeFiltering`**

## Table of contents

### Constructors

- [constructor](corelib.DateTimeFiltering.md#constructor)

### Properties

- [editor](corelib.DateTimeFiltering.md#editor)
- [editorType](corelib.DateTimeFiltering.md#editortype)

### Methods

- [appendComparisonOperators](corelib.DateTimeFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](corelib.DateTimeFiltering.md#appendnullableoperators)
- [argumentNull](corelib.DateTimeFiltering.md#argumentnull)
- [createEditor](corelib.DateTimeFiltering.md#createeditor)
- [displayText](corelib.DateTimeFiltering.md#displaytext)
- [getCriteria](corelib.DateTimeFiltering.md#getcriteria)
- [getCriteriaField](corelib.DateTimeFiltering.md#getcriteriafield)
- [getEditorOptions](corelib.DateTimeFiltering.md#geteditoroptions)
- [getEditorText](corelib.DateTimeFiltering.md#geteditortext)
- [getEditorValue](corelib.DateTimeFiltering.md#geteditorvalue)
- [getOperators](corelib.DateTimeFiltering.md#getoperators)
- [getTitle](corelib.DateTimeFiltering.md#gettitle)
- [get\_container](corelib.DateTimeFiltering.md#get_container)
- [get\_field](corelib.DateTimeFiltering.md#get_field)
- [get\_operator](corelib.DateTimeFiltering.md#get_operator)
- [initQuickFilter](corelib.DateTimeFiltering.md#initquickfilter)
- [isNullable](corelib.DateTimeFiltering.md#isnullable)
- [loadState](corelib.DateTimeFiltering.md#loadstate)
- [operatorFormat](corelib.DateTimeFiltering.md#operatorformat)
- [saveState](corelib.DateTimeFiltering.md#savestate)
- [set\_container](corelib.DateTimeFiltering.md#set_container)
- [set\_field](corelib.DateTimeFiltering.md#set_field)
- [set\_operator](corelib.DateTimeFiltering.md#set_operator)
- [useEditor](corelib.DateTimeFiltering.md#useeditor)
- [useIdField](corelib.DateTimeFiltering.md#useidfield)
- [validateEditorValue](corelib.DateTimeFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new DateTimeFiltering**()

#### Overrides

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[constructor](corelib.BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;419)

## Properties

### editor

• `Protected` **editor**: [`DateEditor`](corelib.DateEditor.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[editor](corelib.BaseEditorFiltering.md#editor)

#### Defined in

[src/ui/filtering/filtering.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;315)

___

### editorType

• **editorType**: `any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[editorType](corelib.BaseEditorFiltering.md#editortype)

#### Defined in

[src/ui/filtering/filtering.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;298)

## Methods

### appendComparisonOperators

▸ `Protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[appendComparisonOperators](corelib.BaseEditorFiltering.md#appendcomparisonoperators)

#### Defined in

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;92)

___

### appendNullableOperators

▸ `Protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[appendNullableOperators](corelib.BaseEditorFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;83)

___

### argumentNull

▸ `Protected` **argumentNull**(): [`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Returns

[`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[argumentNull](corelib.BaseEditorFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[createEditor](corelib.BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;317)

___

### displayText

▸ `Protected` **displayText**(`op`, `values?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |
| `values?` | `any`[] |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[displayText](corelib.BaseEditorFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Overrides

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getCriteria](corelib.BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;428)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getCriteriaField](corelib.BaseEditorFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;335)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorOptions](corelib.BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;345)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorText](corelib.BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;269)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorValue](corelib.BaseEditorFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;373)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Overrides

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getOperators](corelib.BaseEditorFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;423)

___

### getTitle

▸ `Protected` **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getTitle](corelib.BaseEditorFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_container](corelib.BaseEditorFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_field](corelib.BaseEditorFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_operator](corelib.BaseEditorFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;73)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`Widget`](corelib.Widget.md)<`any`\>, `any`\> |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[initQuickFilter](corelib.BaseEditorFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;386)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[isNullable](corelib.BaseEditorFiltering.md#isnullable)

#### Defined in

[src/ui/filtering/filtering.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;102)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[loadState](corelib.BaseEditorFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;352)

___

### operatorFormat

▸ `Protected` **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[operatorFormat](corelib.BaseEditorFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[saveState](corelib.BaseEditorFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;365)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[set_container](corelib.BaseEditorFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;67)

___

### set\_field

▸ **set_field**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[set_field](corelib.BaseEditorFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;57)

___

### set\_operator

▸ **set_operator**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterOperator`](../interfaces/corelib.FilterOperator.md) |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[set_operator](corelib.BaseEditorFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;77)

___

### useEditor

▸ `Protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[useEditor](corelib.BaseEditorFiltering.md#useeditor)

#### Defined in

[src/ui/filtering/filtering.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;302)

___

### useIdField

▸ `Protected` **useIdField**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[useIdField](corelib.BaseEditorFiltering.md#useidfield)

#### Defined in

[src/ui/filtering/filtering.ts:331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;331)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[validateEditorValue](corelib.BaseEditorFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;242)
