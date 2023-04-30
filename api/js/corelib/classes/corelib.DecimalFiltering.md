[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DecimalFiltering

# Class: DecimalFiltering

[corelib](../modules/corelib.md).DecimalFiltering

## Hierarchy

- [`BaseEditorFiltering`](corelib.BaseEditorFiltering.md)<[`DecimalEditor`](corelib.DecimalEditor.md)\>

  ↳ **`DecimalFiltering`**

## Table of contents

### Constructors

- [constructor](corelib.DecimalFiltering.md#constructor)

### Properties

- [editor](corelib.DecimalFiltering.md#editor)
- [editorType](corelib.DecimalFiltering.md#editortype)

### Methods

- [appendComparisonOperators](corelib.DecimalFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](corelib.DecimalFiltering.md#appendnullableoperators)
- [argumentNull](corelib.DecimalFiltering.md#argumentnull)
- [createEditor](corelib.DecimalFiltering.md#createeditor)
- [displayText](corelib.DecimalFiltering.md#displaytext)
- [getCriteria](corelib.DecimalFiltering.md#getcriteria)
- [getCriteriaField](corelib.DecimalFiltering.md#getcriteriafield)
- [getEditorOptions](corelib.DecimalFiltering.md#geteditoroptions)
- [getEditorText](corelib.DecimalFiltering.md#geteditortext)
- [getEditorValue](corelib.DecimalFiltering.md#geteditorvalue)
- [getOperators](corelib.DecimalFiltering.md#getoperators)
- [getTitle](corelib.DecimalFiltering.md#gettitle)
- [get\_container](corelib.DecimalFiltering.md#get_container)
- [get\_field](corelib.DecimalFiltering.md#get_field)
- [get\_operator](corelib.DecimalFiltering.md#get_operator)
- [initQuickFilter](corelib.DecimalFiltering.md#initquickfilter)
- [isNullable](corelib.DecimalFiltering.md#isnullable)
- [loadState](corelib.DecimalFiltering.md#loadstate)
- [operatorFormat](corelib.DecimalFiltering.md#operatorformat)
- [saveState](corelib.DecimalFiltering.md#savestate)
- [set\_container](corelib.DecimalFiltering.md#set_container)
- [set\_field](corelib.DecimalFiltering.md#set_field)
- [set\_operator](corelib.DecimalFiltering.md#set_operator)
- [useEditor](corelib.DecimalFiltering.md#useeditor)
- [useIdField](corelib.DecimalFiltering.md#useidfield)
- [validateEditorValue](corelib.DecimalFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new DecimalFiltering**()

#### Overrides

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[constructor](corelib.BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L483)

## Properties

### editor

• `Protected` **editor**: [`DecimalEditor`](corelib.DecimalEditor.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[editor](corelib.BaseEditorFiltering.md#editor)

#### Defined in

[src/ui/filtering/filtering.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L315)

___

### editorType

• **editorType**: `any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[editorType](corelib.BaseEditorFiltering.md#editortype)

#### Defined in

[src/ui/filtering/filtering.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L298)

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

[src/ui/filtering/filtering.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L92)

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

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): [`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Returns

[`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[argumentNull](corelib.BaseEditorFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[createEditor](corelib.BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L317)

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

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getCriteria](corelib.BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getCriteriaField](corelib.BaseEditorFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L335)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorOptions](corelib.BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L345)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorText](corelib.BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L269)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getEditorValue](corelib.BaseEditorFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L373)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Overrides

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[getOperators](corelib.BaseEditorFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L487)

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

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_container](corelib.BaseEditorFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_field](corelib.BaseEditorFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[get_operator](corelib.BaseEditorFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L73)

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

[src/ui/filtering/filtering.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L386)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[isNullable](corelib.BaseEditorFiltering.md#isnullable)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[loadState](corelib.BaseEditorFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L352)

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

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[saveState](corelib.BaseEditorFiltering.md#savestate)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[set_container](corelib.BaseEditorFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L67)

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

[src/ui/filtering/filtering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L57)

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

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L77)

___

### useEditor

▸ `Protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[useEditor](corelib.BaseEditorFiltering.md#useeditor)

#### Defined in

[src/ui/filtering/filtering.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L302)

___

### useIdField

▸ `Protected` **useIdField**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[useIdField](corelib.BaseEditorFiltering.md#useidfield)

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

[BaseEditorFiltering](corelib.BaseEditorFiltering.md).[validateEditorValue](corelib.BaseEditorFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)
