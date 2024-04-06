[@serenity-is/corelib](../README.md) / ServiceLookupFiltering

# Class: ServiceLookupFiltering

## Hierarchy

- [`BaseEditorFiltering`](BaseEditorFiltering.md)\<[`ServiceLookupEditor`](ServiceLookupEditor.md)\>

  ↳ **`ServiceLookupFiltering`**

## Table of contents

### Constructors

- [constructor](ServiceLookupFiltering.md#constructor)

### Properties

- [editor](ServiceLookupFiltering.md#editor)
- [editorTypeRef](ServiceLookupFiltering.md#editortyperef)

### Methods

- [appendComparisonOperators](ServiceLookupFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](ServiceLookupFiltering.md#appendnullableoperators)
- [argumentNull](ServiceLookupFiltering.md#argumentnull)
- [createEditor](ServiceLookupFiltering.md#createeditor)
- [displayText](ServiceLookupFiltering.md#displaytext)
- [getCriteria](ServiceLookupFiltering.md#getcriteria)
- [getCriteriaField](ServiceLookupFiltering.md#getcriteriafield)
- [getEditorOptions](ServiceLookupFiltering.md#geteditoroptions)
- [getEditorText](ServiceLookupFiltering.md#geteditortext)
- [getEditorValue](ServiceLookupFiltering.md#geteditorvalue)
- [getOperators](ServiceLookupFiltering.md#getoperators)
- [getTitle](ServiceLookupFiltering.md#gettitle)
- [get\_container](ServiceLookupFiltering.md#get_container)
- [get\_field](ServiceLookupFiltering.md#get_field)
- [get\_operator](ServiceLookupFiltering.md#get_operator)
- [initQuickFilter](ServiceLookupFiltering.md#initquickfilter)
- [isNullable](ServiceLookupFiltering.md#isnullable)
- [loadState](ServiceLookupFiltering.md#loadstate)
- [operatorFormat](ServiceLookupFiltering.md#operatorformat)
- [saveState](ServiceLookupFiltering.md#savestate)
- [set\_container](ServiceLookupFiltering.md#set_container)
- [set\_field](ServiceLookupFiltering.md#set_field)
- [set\_operator](ServiceLookupFiltering.md#set_operator)
- [useEditor](ServiceLookupFiltering.md#useeditor)
- [useIdField](ServiceLookupFiltering.md#useidfield)
- [validateEditorValue](ServiceLookupFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new ServiceLookupFiltering**(): [`ServiceLookupFiltering`](ServiceLookupFiltering.md)

#### Returns

[`ServiceLookupFiltering`](ServiceLookupFiltering.md)

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[constructor](BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L642)

## Properties

### editor

• `Protected` **editor**: [`ServiceLookupEditor`](ServiceLookupEditor.md)\<[`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md), `any`\>

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[editor](BaseEditorFiltering.md#editor)

#### Defined in

[src/ui/filtering/filtering.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L321)

___

### editorTypeRef

• **editorTypeRef**: `any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[editorTypeRef](BaseEditorFiltering.md#editortyperef)

#### Defined in

[src/ui/filtering/filtering.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L304)

## Methods

### appendComparisonOperators

▸ **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[appendComparisonOperators](BaseEditorFiltering.md#appendcomparisonoperators)

#### Defined in

[src/ui/filtering/filtering.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L94)

___

### appendNullableOperators

▸ **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `list` | [`FilterOperator`](../interfaces/FilterOperator.md)[] |

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[appendNullableOperators](BaseEditorFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

___

### argumentNull

▸ **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[argumentNull](BaseEditorFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L240)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[createEditor](BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L323)

___

### displayText

▸ **displayText**(`op`, `values?`): `string`

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

[src/ui/filtering/filtering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L141)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getCriteria](BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L157)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getCriteriaField](BaseEditorFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L341)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorOptions](BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L351)

___

### getEditorText

▸ **getEditorText**(): `string`

#### Returns

`string`

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorText](BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L660)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorValue](BaseEditorFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L379)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[getOperators](BaseEditorFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L646)

___

### getTitle

▸ **getTitle**(`field`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | [`PropertyItem`](../interfaces/PropertyItem.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getTitle](BaseEditorFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L137)

___

### get\_container

▸ **get_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_container](BaseEditorFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_field](BaseEditorFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[get_operator](BaseEditorFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L75)

___

### initQuickFilter

▸ **initQuickFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\> |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[initQuickFilter](BaseEditorFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L392)

___

### isNullable

▸ **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[isNullable](BaseEditorFiltering.md#isnullable)

#### Defined in

[src/ui/filtering/filtering.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L104)

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

[src/ui/filtering/filtering.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L358)

___

### operatorFormat

▸ **operatorFormat**(`op`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `op` | [`FilterOperator`](../interfaces/FilterOperator.md) |

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[operatorFormat](BaseEditorFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L133)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[saveState](BaseEditorFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L371)

___

### set\_container

▸ **set_container**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `HTMLElement` |

#### Returns

`void`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[set_container](BaseEditorFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L69)

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

[src/ui/filtering/filtering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L59)

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

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

___

### useEditor

▸ **useEditor**(): `boolean`

#### Returns

`boolean`

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[useEditor](BaseEditorFiltering.md#useeditor)

#### Defined in

[src/ui/filtering/filtering.ts:651](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L651)

___

### useIdField

▸ **useIdField**(): `boolean`

#### Returns

`boolean`

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[useIdField](BaseEditorFiltering.md#useidfield)

#### Defined in

[src/ui/filtering/filtering.ts:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L656)

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

[src/ui/filtering/filtering.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L244)
