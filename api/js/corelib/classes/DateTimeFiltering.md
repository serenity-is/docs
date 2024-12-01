[@serenity-is/corelib](../README.md) / DateTimeFiltering

# Class: DateTimeFiltering

## Extends

- [`BaseEditorFiltering`](BaseEditorFiltering.md)\<[`DateEditor`](DateEditor.md)\>

## Constructors

### new DateTimeFiltering()

> **new DateTimeFiltering**(): [`DateTimeFiltering`](DateTimeFiltering.md)

#### Returns

[`DateTimeFiltering`](DateTimeFiltering.md)

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`constructor`](BaseEditorFiltering.md#constructors)

#### Defined in

[src/ui/filtering/filtering.ts:427](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L427)

## Properties

### editor

> `protected` **editor**: [`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editor`](BaseEditorFiltering.md#editor)

#### Defined in

[src/ui/filtering/filtering.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L323)

***

### editorTypeRef

> **editorTypeRef**: `any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editorTypeRef`](BaseEditorFiltering.md#editortyperef)

#### Defined in

[src/ui/filtering/filtering.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L306)

## Methods

### appendComparisonOperators()

> `protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendComparisonOperators`](BaseEditorFiltering.md#appendcomparisonoperators)

#### Defined in

[src/ui/filtering/filtering.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L94)

***

### appendNullableOperators()

> `protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendNullableOperators`](BaseEditorFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`argumentNull`](BaseEditorFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)

***

### createEditor()

> **createEditor**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`createEditor`](BaseEditorFiltering.md#createeditor)

#### Defined in

[src/ui/filtering/filtering.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L325)

***

### displayText()

> `protected` **displayText**(`op`, `values`?): `string`

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

##### values?

`any`[]

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`displayText`](BaseEditorFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L143)

***

### get\_container()

> **get\_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_container`](BaseEditorFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_field`](BaseEditorFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_operator`](BaseEditorFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L75)

***

### getCriteria()

> **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteria`](BaseEditorFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L436)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteriaField`](BaseEditorFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:343](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L343)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorOptions`](BaseEditorFiltering.md#geteditoroptions)

#### Defined in

[src/ui/filtering/filtering.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L353)

***

### getEditorText()

> **getEditorText**(): `string`

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorText`](BaseEditorFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L275)

***

### getEditorValue()

> **getEditorValue**(): `any`

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorValue`](BaseEditorFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L381)

***

### getOperators()

> **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getOperators`](BaseEditorFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L431)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getTitle`](BaseEditorFiltering.md#gettitle)

#### Defined in

[src/ui/filtering/filtering.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L139)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`initQuickFilter`](BaseEditorFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L394)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`isNullable`](BaseEditorFiltering.md#isnullable)

#### Defined in

[src/ui/filtering/filtering.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L104)

***

### loadState()

> **loadState**(`state`): `void`

#### Parameters

##### state

`any`

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`loadState`](BaseEditorFiltering.md#loadstate)

#### Defined in

[src/ui/filtering/filtering.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L360)

***

### operatorFormat()

> `protected` **operatorFormat**(`op`): `string`

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`operatorFormat`](BaseEditorFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

***

### saveState()

> **saveState**(): `any`

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`saveState`](BaseEditorFiltering.md#savestate)

#### Defined in

[src/ui/filtering/filtering.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L373)

***

### set\_container()

> **set\_container**(`value`): `void`

#### Parameters

##### value

`HTMLElement`

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_container`](BaseEditorFiltering.md#set_container)

#### Defined in

[src/ui/filtering/filtering.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L69)

***

### set\_field()

> **set\_field**(`value`): `void`

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_field`](BaseEditorFiltering.md#set_field)

#### Defined in

[src/ui/filtering/filtering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L59)

***

### set\_operator()

> **set\_operator**(`value`): `void`

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_operator`](BaseEditorFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useEditor`](BaseEditorFiltering.md#useeditor)

#### Defined in

[src/ui/filtering/filtering.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L310)

***

### useIdField()

> `protected` **useIdField**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useIdField`](BaseEditorFiltering.md#useidfield)

#### Defined in

[src/ui/filtering/filtering.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L339)

***

### validateEditorValue()

> **validateEditorValue**(`value`): `string`

#### Parameters

##### value

`string`

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`validateEditorValue`](BaseEditorFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L246)
