[@serenity-is/corelib](../README.md) / BaseEditorFiltering

# Class: BaseEditorFiltering<TEditor\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](Widget.md)<`any`\> |

## Hierarchy

- [`BaseFiltering`](BaseFiltering.md)

  ↳ **`BaseEditorFiltering`**

  ↳↳ [`DateFiltering`](DateFiltering.md)

  ↳↳ [`DateTimeFiltering`](DateTimeFiltering.md)

  ↳↳ [`DecimalFiltering`](DecimalFiltering.md)

  ↳↳ [`EditorFiltering`](EditorFiltering.md)

  ↳↳ [`EnumFiltering`](EnumFiltering.md)

  ↳↳ [`IntegerFiltering`](IntegerFiltering.md)

  ↳↳ [`LookupFiltering`](LookupFiltering.md)

  ↳↳ [`ServiceLookupFiltering`](ServiceLookupFiltering.md)

## Table of contents

### Constructors

- [constructor](BaseEditorFiltering.md#constructor)

### Properties

- [editor](BaseEditorFiltering.md#editor)
- [editorType](BaseEditorFiltering.md#editortype)

### Methods

- [appendComparisonOperators](BaseEditorFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](BaseEditorFiltering.md#appendnullableoperators)
- [argumentNull](BaseEditorFiltering.md#argumentnull)
- [createEditor](BaseEditorFiltering.md#createeditor)
- [displayText](BaseEditorFiltering.md#displaytext)
- [getCriteria](BaseEditorFiltering.md#getcriteria)
- [getCriteriaField](BaseEditorFiltering.md#getcriteriafield)
- [getEditorOptions](BaseEditorFiltering.md#geteditoroptions)
- [getEditorText](BaseEditorFiltering.md#geteditortext)
- [getEditorValue](BaseEditorFiltering.md#geteditorvalue)
- [getOperators](BaseEditorFiltering.md#getoperators)
- [getTitle](BaseEditorFiltering.md#gettitle)
- [get\_container](BaseEditorFiltering.md#get_container)
- [get\_field](BaseEditorFiltering.md#get_field)
- [get\_operator](BaseEditorFiltering.md#get_operator)
- [initQuickFilter](BaseEditorFiltering.md#initquickfilter)
- [isNullable](BaseEditorFiltering.md#isnullable)
- [loadState](BaseEditorFiltering.md#loadstate)
- [operatorFormat](BaseEditorFiltering.md#operatorformat)
- [saveState](BaseEditorFiltering.md#savestate)
- [set\_container](BaseEditorFiltering.md#set_container)
- [set\_field](BaseEditorFiltering.md#set_field)
- [set\_operator](BaseEditorFiltering.md#set_operator)
- [useEditor](BaseEditorFiltering.md#useeditor)
- [useIdField](BaseEditorFiltering.md#useidfield)
- [validateEditorValue](BaseEditorFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new BaseEditorFiltering**<`TEditor`\>(`editorType`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](Widget.md)<`any`, `TEditor`\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | `any` |

#### Overrides

[BaseFiltering](BaseFiltering.md).[constructor](BaseFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L298)

## Properties

### editor

• `Protected` **editor**: `TEditor`

#### Defined in

[src/ui/filtering/filtering.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L315)

___

### editorType

• **editorType**: `any`

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

[BaseFiltering](BaseFiltering.md).[appendComparisonOperators](BaseFiltering.md#appendcomparisonoperators)

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

[BaseFiltering](BaseFiltering.md).[appendNullableOperators](BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

___

### argumentNull

▸ `Protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[argumentNull](BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L238)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Overrides

[BaseFiltering](BaseFiltering.md).[createEditor](BaseFiltering.md#createeditor)

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

[BaseFiltering](BaseFiltering.md).[displayText](BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteria](BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L155)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Overrides

[BaseFiltering](BaseFiltering.md).[getCriteriaField](BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L335)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L345)

___

### getEditorText

▸ **getEditorText**(): `any`

#### Returns

`any`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorText](BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L269)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](BaseFiltering.md).[getEditorValue](BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L373)

___

### getOperators

▸ `Abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getOperators](BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L81)

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

[BaseFiltering](BaseFiltering.md).[getTitle](BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

___

### get\_container

▸ **get_container**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_container](BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L63)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_field](BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L53)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_operator](BaseFiltering.md#get_operator)

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

#### Overrides

[BaseFiltering](BaseFiltering.md).[initQuickFilter](BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L386)

___

### isNullable

▸ `Protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[isNullable](BaseFiltering.md#isnullable)

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

#### Overrides

[BaseFiltering](BaseFiltering.md).[loadState](BaseFiltering.md#loadstate)

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

[BaseFiltering](BaseFiltering.md).[operatorFormat](BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L131)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](BaseFiltering.md).[saveState](BaseFiltering.md#savestate)

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

[BaseFiltering](BaseFiltering.md).[set_container](BaseFiltering.md#set_container)

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

[BaseFiltering](BaseFiltering.md).[set_field](BaseFiltering.md#set_field)

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

[BaseFiltering](BaseFiltering.md).[set_operator](BaseFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L77)

___

### useEditor

▸ `Protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L302)

___

### useIdField

▸ `Protected` **useIdField**(): `boolean`

#### Returns

`boolean`

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

[BaseFiltering](BaseFiltering.md).[validateEditorValue](BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)
