[@serenity-is/corelib](../README.md) / DateFiltering

# Class: DateFiltering

Defined in: [src/ui/filtering/datefiltering.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/datefiltering.ts#L6)

## Extends

- [`BaseEditorFiltering`](BaseEditorFiltering.md)\<[`DateEditor`](DateEditor.md)\>

## Constructors

### Constructor

> **new DateFiltering**(): `DateFiltering`

Defined in: [src/ui/filtering/datefiltering.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/datefiltering.ts#L9)

#### Returns

`DateFiltering`

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`constructor`](BaseEditorFiltering.md#constructor)

## Properties

### editor

> `protected` **editor**: [`DateEditor`](DateEditor.md)

Defined in: [src/ui/filtering/baseeditorfiltering.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L27)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editor`](BaseEditorFiltering.md#editor)

***

### editorTypeRef

> **editorTypeRef**: `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L10)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editorTypeRef`](BaseEditorFiltering.md#editortyperef)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/datefiltering.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/datefiltering.ts#L7)

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`[typeInfo]`](BaseEditorFiltering.md#typeinfo)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendComparisonOperators`](BaseEditorFiltering.md#appendcomparisonoperators)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendNullableOperators`](BaseEditorFiltering.md#appendnullableoperators)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

Defined in: [src/ui/filtering/basefiltering.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L203)

#### Returns

`Error`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`argumentNull`](BaseEditorFiltering.md#argumentnull)

***

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L29)

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`createEditor`](BaseEditorFiltering.md#createeditor)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`displayText`](BaseEditorFiltering.md#displaytext)

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/basefiltering.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L26)

#### Returns

`HTMLElement`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_container`](BaseEditorFiltering.md#get_container)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/basefiltering.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L16)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_field`](BaseEditorFiltering.md#get_field)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/basefiltering.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L36)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_operator`](BaseEditorFiltering.md#get_operator)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/basefiltering.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L120)

#### Returns

`CriteriaWithText`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteria`](BaseEditorFiltering.md#getcriteria)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L47)

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteriaField`](BaseEditorFiltering.md#getcriteriafield)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L57)

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorOptions`](BaseEditorFiltering.md#geteditoroptions)

***

### getEditorText()

> **getEditorText**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L236)

#### Returns

`string`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorText`](BaseEditorFiltering.md#geteditortext)

***

### getEditorValue()

> **getEditorValue**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L85)

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorValue`](BaseEditorFiltering.md#geteditorvalue)

***

### getOperators()

> **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/datefiltering.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/datefiltering.ts#L13)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getOperators`](BaseEditorFiltering.md#getoperators)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getTitle`](BaseEditorFiltering.md#gettitle)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L98)

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`initQuickFilter`](BaseEditorFiltering.md#initquickfilter)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

Defined in: [src/ui/filtering/basefiltering.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L65)

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`isNullable`](BaseEditorFiltering.md#isnullable)

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L64)

#### Parameters

##### state

`any`

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`loadState`](BaseEditorFiltering.md#loadstate)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`operatorFormat`](BaseEditorFiltering.md#operatorformat)

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L77)

#### Returns

`any`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`saveState`](BaseEditorFiltering.md#savestate)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_container`](BaseEditorFiltering.md#set_container)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_field`](BaseEditorFiltering.md#set_field)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_operator`](BaseEditorFiltering.md#set_operator)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L14)

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useEditor`](BaseEditorFiltering.md#useeditor)

***

### useIdField()

> `protected` **useIdField**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L43)

#### Returns

`boolean`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useIdField`](BaseEditorFiltering.md#useidfield)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`validateEditorValue`](BaseEditorFiltering.md#validateeditorvalue)

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

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`registerClass`](BaseEditorFiltering.md#registerclass)
