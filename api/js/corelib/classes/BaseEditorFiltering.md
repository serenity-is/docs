[@serenity-is/corelib](../README.md) / BaseEditorFiltering

# Class: BaseEditorFiltering\<TEditor\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](Widget.md)\<`any`\> |

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
- [editorTypeRef](BaseEditorFiltering.md#editortyperef)

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

• **new BaseEditorFiltering**\<`TEditor`\>(`editorTypeRef`): [`BaseEditorFiltering`](BaseEditorFiltering.md)\<`TEditor`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TEditor` | extends [`Widget`](Widget.md)\<`any`\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorTypeRef` | `any` |

#### Returns

[`BaseEditorFiltering`](BaseEditorFiltering.md)\<`TEditor`\>

#### Overrides

[BaseFiltering](BaseFiltering.md).[constructor](BaseFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L304)

## Properties

### editor

• `Protected` **editor**: `TEditor`

#### Defined in

[src/ui/filtering/filtering.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L321)

___

### editorTypeRef

• **editorTypeRef**: `any`

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

[BaseFiltering](BaseFiltering.md).[appendComparisonOperators](BaseFiltering.md#appendcomparisonoperators)

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

[BaseFiltering](BaseFiltering.md).[appendNullableOperators](BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

___

### argumentNull

▸ **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[argumentNull](BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L240)

___

### createEditor

▸ **createEditor**(): `void`

#### Returns

`void`

#### Overrides

[BaseFiltering](BaseFiltering.md).[createEditor](BaseFiltering.md#createeditor)

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

[BaseFiltering](BaseFiltering.md).[displayText](BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L141)

___

### getCriteria

▸ **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getCriteria](BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L157)

___

### getCriteriaField

▸ **getCriteriaField**(): `string`

#### Returns

`string`

#### Overrides

[BaseFiltering](BaseFiltering.md).[getCriteriaField](BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L341)

___

### getEditorOptions

▸ **getEditorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L351)

___

### getEditorText

▸ **getEditorText**(): `string`

#### Returns

`string`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getEditorText](BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L273)

___

### getEditorValue

▸ **getEditorValue**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](BaseFiltering.md).[getEditorValue](BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L379)

___

### getOperators

▸ **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[BaseFiltering](BaseFiltering.md).[getOperators](BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

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

[BaseFiltering](BaseFiltering.md).[getTitle](BaseFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L137)

___

### get\_container

▸ **get_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_container](BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

___

### get\_field

▸ **get_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_field](BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

___

### get\_operator

▸ **get_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[BaseFiltering](BaseFiltering.md).[get_operator](BaseFiltering.md#get_operator)

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

#### Overrides

[BaseFiltering](BaseFiltering.md).[initQuickFilter](BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L392)

___

### isNullable

▸ **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[BaseFiltering](BaseFiltering.md).[isNullable](BaseFiltering.md#isnullable)

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

#### Overrides

[BaseFiltering](BaseFiltering.md).[loadState](BaseFiltering.md#loadstate)

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

[BaseFiltering](BaseFiltering.md).[operatorFormat](BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L133)

___

### saveState

▸ **saveState**(): `any`

#### Returns

`any`

#### Overrides

[BaseFiltering](BaseFiltering.md).[saveState](BaseFiltering.md#savestate)

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

[BaseFiltering](BaseFiltering.md).[set_container](BaseFiltering.md#set_container)

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

[BaseFiltering](BaseFiltering.md).[set_field](BaseFiltering.md#set_field)

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

[BaseFiltering](BaseFiltering.md).[set_operator](BaseFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

___

### useEditor

▸ **useEditor**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L308)

___

### useIdField

▸ **useIdField**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L337)

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

[src/ui/filtering/filtering.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L244)
