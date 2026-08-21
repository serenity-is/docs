[@serenity-is/corelib](../README.md) / BaseEditorFiltering

# Abstract Class: BaseEditorFiltering\<TEditor\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L12)

Base filtering handler that uses an editor widget for comparison operators.

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

The editor widget type.

## Constructors

### Constructor

> **new BaseEditorFiltering**\<`TEditor`\>(`editorTypeRef`): `BaseEditorFiltering`\<`TEditor`\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L18)

Creates a base editor filtering handler.

#### Parameters

##### editorTypeRef

`any`

Constructor of the editor widget type.

#### Returns

`BaseEditorFiltering`\<`TEditor`\>

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`constructor`](BaseFiltering.md#constructor)

## Properties

### editor

> `protected` **editor**: `TEditor`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L39)

***

### editorTypeRef

> **editorTypeRef**: `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L18)

Constructor of the editor widget type.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/baseeditorfiltering.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L13)

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`[typeInfo]`](BaseFiltering.md#typeinfo)

## Methods

### appendComparisonOperators()

> `protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L96)

Appends the comparison operators (eq, ne, lt, le, gt, ge).

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`appendComparisonOperators`](BaseFiltering.md#appendcomparisonoperators)

***

### appendNullableOperators()

> `protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L82)

Appends the is-null and is-not-null operators when the field is nullable.

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`appendNullableOperators`](BaseFiltering.md#appendnullableoperators)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

Defined in: [src/ui/filtering/basefiltering.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L287)

Returns the error thrown when a required value is missing.

#### Returns

`Error`

The error.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`argumentNull`](BaseFiltering.md#argumentnull)

***

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L44)

Creates the editor for the current operator.

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`createEditor`](BaseFiltering.md#createeditor)

***

### displayText()

> `protected` **displayText**(`op`, `values?`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L168)

Builds the display text for an operator and its values.

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

##### values?

`any`[]

The filter values.

#### Returns

`string`

The display text.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`displayText`](BaseFiltering.md#displaytext)

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/basefiltering.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L41)

Returns the container element for the editor.

#### Returns

`HTMLElement`

The container element.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_container`](BaseFiltering.md#get_container)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/basefiltering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L23)

Returns the field being filtered.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_field`](BaseFiltering.md#get_field)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/basefiltering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L59)

Returns the current operator.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`get_operator`](BaseFiltering.md#get_operator)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/basefiltering.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L192)

Returns the criteria and display text for the current operator.

#### Returns

`CriteriaWithText`

The criteria with display text.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getCriteria`](BaseFiltering.md#getcriteria)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L70)

Returns the criteria field name, using the filtering id field when applicable.

#### Returns

`string`

The criteria field name.

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getCriteriaField`](BaseFiltering.md#getcriteriafield)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L84)

Returns the options for the editor widget.

#### Returns

`any`

The editor options.

***

### getEditorText()

> **getEditorText**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L333)

Returns the display text of the current editor value.

#### Returns

`string`

The editor text.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getEditorText`](BaseFiltering.md#geteditortext)

***

### getEditorValue()

> **getEditorValue**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L124)

Returns the current editor value.

#### Returns

`any`

The editor value.

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`getEditorValue`](BaseFiltering.md#geteditorvalue)

***

### getOperators()

> `abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L75)

Returns the operators supported by this filtering handler.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operators.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getOperators`](BaseFiltering.md#getoperators)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L158)

Returns the localized title of a field.

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Returns

`string`

The title.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`getTitle`](BaseFiltering.md#gettitle)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L141)

Initializes a quick filter using the editor type.

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

The quick filter to initialize.

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`initQuickFilter`](BaseFiltering.md#initquickfilter)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

Defined in: [src/ui/filtering/basefiltering.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L110)

Whether the field is nullable.

#### Returns

`boolean`

True when the field is not required.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`isNullable`](BaseFiltering.md#isnullable)

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L95)

Loads persisted state into the editor.

#### Parameters

##### state

`any`

The persisted state.

#### Returns

`void`

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`loadState`](BaseFiltering.md#loadstate)

***

### operatorFormat()

> `protected` **operatorFormat**(`op`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L149)

Returns the format string for an operator.

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Returns

`string`

The format string.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`operatorFormat`](BaseFiltering.md#operatorformat)

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L112)

Saves the editor state for persistence.

#### Returns

`any`

The saved state.

#### Overrides

[`BaseFiltering`](BaseFiltering.md).[`saveState`](BaseFiltering.md#savestate)

***

### set\_container()

> **set\_container**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L49)

Sets the container element for the editor.

#### Parameters

##### value

`HTMLElement`

The container element.

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_container`](BaseFiltering.md#set_container)

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L31)

Sets the field being filtered.

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_field`](BaseFiltering.md#set_field)

***

### set\_operator()

> **set\_operator**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L67)

Sets the current operator.

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Returns

`void`

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`set_operator`](BaseFiltering.md#set_operator)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L26)

Whether the current operator uses an editor.

#### Returns

`boolean`

True when an editor is used.

***

### useIdField()

> `protected` **useIdField**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L62)

Whether to use the id field for the criteria.

#### Returns

`boolean`

True when the id field is used.

***

### validateEditorValue()

> **validateEditorValue**(`value`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L296)

Validates the editor value.

#### Parameters

##### value

`string`

The value to validate.

#### Returns

`string`

The validated value.

#### Inherited from

[`BaseFiltering`](BaseFiltering.md).[`validateEditorValue`](BaseFiltering.md#validateeditorvalue)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/filtering/basefiltering.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L361)

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
