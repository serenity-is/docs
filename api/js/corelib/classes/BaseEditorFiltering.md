[@serenity-is/corelib](../README.md) / BaseEditorFiltering

# Class: `abstract` BaseEditorFiltering\<TEditor\>

## Extends

- [`BaseFiltering`](BaseFiltering.md)

## Extended by

- [`DateFiltering`](DateFiltering.md)
- [`DateTimeFiltering`](DateTimeFiltering.md)
- [`DecimalFiltering`](DecimalFiltering.md)
- [`EditorFiltering`](EditorFiltering.md)
- [`EnumFiltering`](EnumFiltering.md)
- [`IntegerFiltering`](IntegerFiltering.md)
- [`LookupFiltering`](LookupFiltering.md)
- [`ServiceLookupFiltering`](ServiceLookupFiltering.md)

## Type Parameters

• **TEditor** *extends* [`Widget`](Widget.md)\<`any`\>

## Constructors

### new BaseEditorFiltering()

> **new BaseEditorFiltering**\<`TEditor`\>(`editorTypeRef`): [`BaseEditorFiltering`](BaseEditorFiltering.md)\<`TEditor`\>

#### Parameters

##### editorTypeRef

`any`

#### Returns

[`BaseEditorFiltering`](BaseEditorFiltering.md)\<`TEditor`\>

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`constructor`](BaseFiltering.md#constructors)

#### Defined in

[src/ui/filtering/filtering.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L306)

## Properties

### editor

> `protected` **editor**: `TEditor`

#### Defined in

[src/ui/filtering/filtering.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L323)

***

### editorTypeRef

> **editorTypeRef**: `any`

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

[`BaseFiltering`](BaseFiltering.md).[`appendComparisonOperators`](BaseFiltering.md#appendcomparisonoperators)

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

[`BaseFiltering`](BaseFiltering.md).[`appendNullableOperators`](BaseFiltering.md#appendnullableoperators)

#### Defined in

[src/ui/filtering/filtering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L85)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

#### Returns

`Error`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`argumentNull`](BaseFiltering.md#argumentnull)

#### Defined in

[src/ui/filtering/filtering.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L242)

***

### createEditor()

> **createEditor**(): `void`

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`createEditor`](BaseFiltering.md#createeditor)

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

[`BaseFiltering`](BaseFiltering.md).[`displayText`](BaseFiltering.md#displaytext)

#### Defined in

[src/ui/filtering/filtering.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L143)

***

### get\_container()

> **get\_container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_container`](BaseFiltering.md#get_container)

#### Defined in

[src/ui/filtering/filtering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L65)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_field`](BaseFiltering.md#get_field)

#### Defined in

[src/ui/filtering/filtering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L55)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_operator`](BaseFiltering.md#get_operator)

#### Defined in

[src/ui/filtering/filtering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L75)

***

### getCriteria()

> **getCriteria**(): [`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Returns

[`CriteriaWithText`](../interfaces/CriteriaWithText.md)

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getCriteria`](BaseFiltering.md#getcriteria)

#### Defined in

[src/ui/filtering/filtering.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L159)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

#### Returns

`string`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getCriteriaField`](BaseFiltering.md#getcriteriafield)

#### Defined in

[src/ui/filtering/filtering.ts:343](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L343)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/filtering/filtering.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L353)

***

### getEditorText()

> **getEditorText**(): `string`

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getEditorText`](BaseFiltering.md#geteditortext)

#### Defined in

[src/ui/filtering/filtering.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L275)

***

### getEditorValue()

> **getEditorValue**(): `any`

#### Returns

`any`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getEditorValue`](BaseFiltering.md#geteditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L381)

***

### getOperators()

> `abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getOperators`](BaseFiltering.md#getoperators)

#### Defined in

[src/ui/filtering/filtering.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L83)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getTitle`](BaseFiltering.md#gettitle)

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

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`initQuickFilter`](BaseFiltering.md#initquickfilter)

#### Defined in

[src/ui/filtering/filtering.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L394)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`isNullable`](BaseFiltering.md#isnullable)

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

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`loadState`](BaseFiltering.md#loadstate)

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

[`BaseFiltering`](BaseFiltering.md).[`operatorFormat`](BaseFiltering.md#operatorformat)

#### Defined in

[src/ui/filtering/filtering.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L135)

***

### saveState()

> **saveState**(): `any`

#### Returns

`any`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`saveState`](BaseFiltering.md#savestate)

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

[`BaseFiltering`](BaseFiltering.md).[`set_container`](BaseFiltering.md#set_container)

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

[`BaseFiltering`](BaseFiltering.md).[`set_field`](BaseFiltering.md#set_field)

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

[`BaseFiltering`](BaseFiltering.md).[`set_operator`](BaseFiltering.md#set_operator)

#### Defined in

[src/ui/filtering/filtering.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L79)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/filtering/filtering.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L310)

***

### useIdField()

> `protected` **useIdField**(): `boolean`

#### Returns

`boolean`

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

[`BaseFiltering`](BaseFiltering.md).[`validateEditorValue`](BaseFiltering.md#validateeditorvalue)

#### Defined in

[src/ui/filtering/filtering.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filtering.ts#L246)
