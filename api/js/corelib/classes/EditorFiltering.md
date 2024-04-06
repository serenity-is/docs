[@serenity-is/corelib](../README.md) / EditorFiltering

# Class: EditorFiltering

## Hierarchy

- [`BaseEditorFiltering`](BaseEditorFiltering.md)\<[`Widget`](Widget.md)\<`any`\>\>

  ↳ **`EditorFiltering`**

## Table of contents

### Constructors

- [constructor](EditorFiltering.md#constructor)

### Properties

- [editor](EditorFiltering.md#editor)
- [editorTypeRef](EditorFiltering.md#editortyperef)
- [props](EditorFiltering.md#props)

### Accessors

- [editorType](EditorFiltering.md#editortype)
- [useLike](EditorFiltering.md#uselike)
- [useRelative](EditorFiltering.md#userelative)

### Methods

- [appendComparisonOperators](EditorFiltering.md#appendcomparisonoperators)
- [appendNullableOperators](EditorFiltering.md#appendnullableoperators)
- [argumentNull](EditorFiltering.md#argumentnull)
- [createEditor](EditorFiltering.md#createeditor)
- [displayText](EditorFiltering.md#displaytext)
- [getCriteria](EditorFiltering.md#getcriteria)
- [getCriteriaField](EditorFiltering.md#getcriteriafield)
- [getEditorOptions](EditorFiltering.md#geteditoroptions)
- [getEditorText](EditorFiltering.md#geteditortext)
- [getEditorValue](EditorFiltering.md#geteditorvalue)
- [getOperators](EditorFiltering.md#getoperators)
- [getTitle](EditorFiltering.md#gettitle)
- [get\_container](EditorFiltering.md#get_container)
- [get\_field](EditorFiltering.md#get_field)
- [get\_operator](EditorFiltering.md#get_operator)
- [initQuickFilter](EditorFiltering.md#initquickfilter)
- [isNullable](EditorFiltering.md#isnullable)
- [loadState](EditorFiltering.md#loadstate)
- [operatorFormat](EditorFiltering.md#operatorformat)
- [saveState](EditorFiltering.md#savestate)
- [set\_container](EditorFiltering.md#set_container)
- [set\_field](EditorFiltering.md#set_field)
- [set\_operator](EditorFiltering.md#set_operator)
- [useEditor](EditorFiltering.md#useeditor)
- [useIdField](EditorFiltering.md#useidfield)
- [validateEditorValue](EditorFiltering.md#validateeditorvalue)

## Constructors

### constructor

• **new EditorFiltering**(`props?`): [`EditorFiltering`](EditorFiltering.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.editorType?` | `string` |
| `props.useLike?` | `boolean` |
| `props.useRelative?` | `boolean` |

#### Returns

[`EditorFiltering`](EditorFiltering.md)

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[constructor](BaseEditorFiltering.md#constructor)

#### Defined in

[src/ui/filtering/filtering.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L502)

## Properties

### editor

• `Protected` **editor**: [`Widget`](Widget.md)\<`any`\>

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

___

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `editorType?` | `string` |
| `useLike?` | `boolean` |
| `useRelative?` | `boolean` |

#### Defined in

[src/ui/filtering/filtering.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L502)

## Accessors

### editorType

• `get` **editorType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filtering.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L507)

• `set` **editorType**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:508](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L508)

___

### useLike

• `get` **useLike**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:513](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L513)

• `set` **useLike**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L514)

___

### useRelative

• `get` **useRelative**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L510)

• `set` **useRelative**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filtering.ts:511](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L511)

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

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[createEditor](BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:560](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L560)

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

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorOptions](BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:551](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L551)

___

### getEditorText

▸ **getEditorText**(): `string`

#### Returns

`string`

#### Inherited from

[BaseEditorFiltering](BaseEditorFiltering.md).[getEditorText](BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L273)

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

[src/ui/filtering/filtering.ts:516](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L516)

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

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[initQuickFilter](BaseEditorFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:579](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L579)

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

[src/ui/filtering/filtering.ts:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L539)

___

### useIdField

▸ **useIdField**(): `boolean`

#### Returns

`boolean`

#### Overrides

[BaseEditorFiltering](BaseEditorFiltering.md).[useIdField](BaseEditorFiltering.md#useidfield)

#### Defined in

[src/ui/filtering/filtering.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L575)

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
