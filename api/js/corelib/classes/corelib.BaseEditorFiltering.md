[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / BaseEditorFiltering

# Class: BaseEditorFiltering<TEditor\>

[corelib](../modules/corelib.md).BaseEditorFiltering

## Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](corelib.Widget.md)<`any`\> |

## Hierarchy

- [`BaseFiltering`](corelib.BaseFiltering.md)

  ↳ **`BaseEditorFiltering`**

  ↳↳ [`DateFiltering`](corelib.DateFiltering.md)

  ↳↳ [`DateTimeFiltering`](corelib.DateTimeFiltering.md)

  ↳↳ [`DecimalFiltering`](corelib.DecimalFiltering.md)

  ↳↳ [`EditorFiltering`](corelib.EditorFiltering.md)

  ↳↳ [`EnumFiltering`](corelib.EnumFiltering.md)

  ↳↳ [`IntegerFiltering`](corelib.IntegerFiltering.md)

  ↳↳ [`LookupFiltering`](corelib.LookupFiltering.md)

  ↳↳ [`ServiceLookupFiltering`](corelib.ServiceLookupFiltering.md)

## Table of contents

### Constructors

- [constructor](corelib.BaseEditorFiltering.md#constructor)

### Properties

- [editor](corelib.BaseEditorFiltering.md#editor)
- [editorType](corelib.BaseEditorFiltering.md#editortype)

### Methods

- [appendComparisonOperators](corelib.BaseEditorFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](corelib.BaseEditorFiltering.md#appendnullableoperators)
- [argumentNull](corelib.BaseEditorFiltering.md#argumentnull)
- [createEditor](corelib.BaseEditorFiltering.md#createeditor)
- [displayText](corelib.BaseEditorFiltering.md#displaytext)
- [getCriteria](corelib.BaseEditorFiltering.md#getcriteria)
- [getCriteriaField](corelib.BaseEditorFiltering.md#getcriteriafield)
- [getEditorOptions](corelib.BaseEditorFiltering.md#geteditoroptions)
- [getEditorText](corelib.BaseEditorFiltering.md#geteditortext)
- [getEditorValue](corelib.BaseEditorFiltering.md#geteditorvalue)
- [getOperators](corelib.BaseEditorFiltering.md#getoperators)
- [getTitle](corelib.BaseEditorFiltering.md#gettitle)
- [get\_container](corelib.BaseEditorFiltering.md#get_container)
- [get\_field](corelib.BaseEditorFiltering.md#get_field)
- [get\_operator](corelib.BaseEditorFiltering.md#get_operator)
- [initQuickFilter](corelib.BaseEditorFiltering.md#initquickfilter)
- [isNullable](corelib.BaseEditorFiltering.md#isnullable)
- [loadState](corelib.BaseEditorFiltering.md#loadstate)
- [operatorFormat](corelib.BaseEditorFiltering.md#operatorformat)
- [saveState](corelib.BaseEditorFiltering.md#savestate)
- [set\_container](corelib.BaseEditorFiltering.md#set_container)
- [set\_field](corelib.BaseEditorFiltering.md#set_field)
- [set\_operator](corelib.BaseEditorFiltering.md#set_operator)
- [useEditor](corelib.BaseEditorFiltering.md#useeditor)
- [useIdField](corelib.BaseEditorFiltering.md#useidfield)
- [validateEditorValue](corelib.BaseEditorFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new BaseEditorFiltering**<`TEditor`\>(`editorType`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](corelib.Widget.md)<`any`, `TEditor`\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | `any` |

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[constructor](corelib.BaseFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;298)

## Properties

### editor

• `Protected` **editor**: `TEditor`

#### Defined in

[src/ui/filtering/filtering.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;315)

___

### editorType

• **editorType**: `any`

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

[BaseFiltering](corelib.BaseFiltering.md).[appendComparisonOperators](corelib.BaseFiltering.md#appendcomparisonoperators)

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

[BaseFiltering](corelib.BaseFiltering.md).[appendNullableOperators](corelib.BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;83)

___

### argumentNull

▸ `Protected` **argumentNull**(): [`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Returns

[`ArgumentNullException`](corelib_q.ArgumentNullException.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[argumentNull](corelib.BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[createEditor](corelib.BaseFiltering.md#createeditor)

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

[BaseFiltering](corelib.BaseFiltering.md).[displayText](corelib.BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/corelib.CriteriaWithText.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getCriteria](corelib.BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;155)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[getCriteriaField](corelib.BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;335)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;345)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getEditorText](corelib.BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;269)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[getEditorValue](corelib.BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;373)

___

### getOperators

▸ `Abstract` **getOperators**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)[]

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[getOperators](corelib.BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;81)

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

[BaseFiltering](corelib.BaseFiltering.md).[getTitle](corelib.BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_container](corelib.BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_field](corelib.BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/corelib.FilterOperator.md)

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[get_operator](corelib.BaseFiltering.md#get_operator)

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

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[initQuickFilter](corelib.BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;386)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](corelib.BaseFiltering.md).[isNullable](corelib.BaseFiltering.md#isnullable)

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

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[loadState](corelib.BaseFiltering.md#loadstate)

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

[BaseFiltering](corelib.BaseFiltering.md).[operatorFormat](corelib.BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](corelib.BaseFiltering.md).[saveState](corelib.BaseFiltering.md#savestate)

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

[BaseFiltering](corelib.BaseFiltering.md).[set_container](corelib.BaseFiltering.md#set_container)

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

[BaseFiltering](corelib.BaseFiltering.md).[set_field](corelib.BaseFiltering.md#set_field)

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

[BaseFiltering](corelib.BaseFiltering.md).[set_operator](corelib.BaseFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;77)

___

### useEditor

▸ `Protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;302)

___

### useIdField

▸ `Protected` **useIdField**(): `boolean`

#### Returns

`boolean`

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

[BaseFiltering](corelib.BaseFiltering.md).[validateEditorValue](corelib.BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#line&#x3D;242)
