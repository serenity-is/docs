[corelib](../README.md) / BaseEditorFiltering

# Abstract Class: BaseEditorFiltering\<TEditor\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L8)

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

### TEditor

`TEditor` *extends* [`Widget`](Widget.md)\<`any`\>

## Constructors

### Constructor

> **new BaseEditorFiltering**\<`TEditor`\>(`editorTypeRef`): `BaseEditorFiltering`\<`TEditor`\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L10)

#### Parameters

##### editorTypeRef

`any`

#### Returns

`BaseEditorFiltering`\<`TEditor`\>

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`constructor`](BaseFiltering.md#constructor)

## Properties

### editor

> `protected` **editor**: `TEditor`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L27)

***

### editorTypeRef

> **editorTypeRef**: `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L10)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L9)

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`[typeInfo]`](BaseFiltering.md#typeinfo)

## Methods

### appendComparisonOperators()

> `protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L55)

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`appendComparisonOperators`](BaseFiltering.md#appendcomparisonoperators)

***

### appendNullableOperators()

> `protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L46)

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`appendNullableOperators`](BaseFiltering.md#appendnullableoperators)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

Defined in: [src/ui/filtering/basefiltering.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L203)

#### Returns

`Error`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`argumentNull`](BaseFiltering.md#argumentnull)

***

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L29)

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`createEditor`](BaseFiltering.md#createeditor)

***

### displayText()

> `protected` **displayText**(`op`, `values?`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L104)

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

##### values?

`any`[]

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`displayText`](BaseFiltering.md#displaytext)

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/basefiltering.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L26)

#### Returns

`HTMLElement`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_container`](BaseFiltering.md#get_container)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/basefiltering.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L16)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_field`](BaseFiltering.md#get_field)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/basefiltering.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L36)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_operator`](BaseFiltering.md#get_operator)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/basefiltering.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L120)

#### Returns

`CriteriaWithText`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getCriteria`](BaseFiltering.md#getcriteria)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L47)

#### Returns

`string`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getCriteriaField`](BaseFiltering.md#getcriteriafield)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L57)

#### Returns

`any`

***

### getEditorText()

> **getEditorText**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L236)

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getEditorText`](BaseFiltering.md#geteditortext)

***

### getEditorValue()

> **getEditorValue**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L85)

#### Returns

`any`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getEditorValue`](BaseFiltering.md#geteditorvalue)

***

### getOperators()

> `abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L44)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getOperators`](BaseFiltering.md#getoperators)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L100)

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getTitle`](BaseFiltering.md#gettitle)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L98)

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`initQuickFilter`](BaseFiltering.md#initquickfilter)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

Defined in: [src/ui/filtering/basefiltering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L65)

#### Returns

`boolean`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`isNullable`](BaseFiltering.md#isnullable)

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L64)

#### Parameters

##### state

`any`

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`loadState`](BaseFiltering.md#loadstate)

***

### operatorFormat()

> `protected` **operatorFormat**(`op`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L96)

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`operatorFormat`](BaseFiltering.md#operatorformat)

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L77)

#### Returns

`any`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`saveState`](BaseFiltering.md#savestate)

***

### set\_container()

> **set\_container**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L30)

#### Parameters

##### value

`HTMLElement`

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_container`](BaseFiltering.md#set_container)

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L20)

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_field`](BaseFiltering.md#set_field)

***

### set\_operator()

> **set\_operator**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L40)

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_operator`](BaseFiltering.md#set_operator)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L14)

#### Returns

`boolean`

***

### useIdField()

> `protected` **useIdField**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L43)

#### Returns

`boolean`

***

### validateEditorValue()

> **validateEditorValue**(`value`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L207)

#### Parameters

##### value

`string`

#### Returns

`string`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`validateEditorValue`](BaseFiltering.md#validateeditorvalue)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/filtering/basefiltering.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L260)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`registerClass`](BaseFiltering.md#registerclass)
