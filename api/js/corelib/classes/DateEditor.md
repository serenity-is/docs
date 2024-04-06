[@serenity-is/corelib](../README.md) / DateEditor

# Class: DateEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`DateEditorOptions`](../interfaces/DateEditorOptions.md) = [`DateEditorOptions`](../interfaces/DateEditorOptions.md) |

## Hierarchy

- [`EditorWidget`](EditorWidget.md)\<`P`\>

  ↳ **`DateEditor`**

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](DateEditor.md#constructor)

### Properties

- [domNode](DateEditor.md#domnode)
- [idPrefix](DateEditor.md#idprefix)
- [options](DateEditor.md#options)
- [uniqueName](DateEditor.md#uniquename)
- [dateInputChange](DateEditor.md#dateinputchange)
- [typeInfo](DateEditor.md#typeinfo)
- [useFlatpickr](DateEditor.md#useflatpickr)

### Accessors

- [element](DateEditor.md#element)
- [props](DateEditor.md#props)
- [value](DateEditor.md#value)
- [valueAsDate](DateEditor.md#valueasdate)

### Methods

- [addCssClass](DateEditor.md#addcssclass)
- [addValidationRule](DateEditor.md#addvalidationrule)
- [change](DateEditor.md#change)
- [changeSelect2](DateEditor.md#changeselect2)
- [createFlatPickrTrigger](DateEditor.md#createflatpickrtrigger)
- [destroy](DateEditor.md#destroy)
- [getCssClass](DateEditor.md#getcssclass)
- [getCustomAttribute](DateEditor.md#getcustomattribute)
- [getFieldElement](DateEditor.md#getfieldelement)
- [getFlatpickrOptions](DateEditor.md#getflatpickroptions)
- [getGridField](DateEditor.md#getgridfield)
- [get\_maxDate](DateEditor.md#get_maxdate)
- [get\_maxValue](DateEditor.md#get_maxvalue)
- [get\_minDate](DateEditor.md#get_mindate)
- [get\_minValue](DateEditor.md#get_minvalue)
- [get\_readOnly](DateEditor.md#get_readonly)
- [get\_sqlMinMax](DateEditor.md#get_sqlminmax)
- [get\_value](DateEditor.md#get_value)
- [init](DateEditor.md#init)
- [internalInit](DateEditor.md#internalinit)
- [internalRenderContents](DateEditor.md#internalrendercontents)
- [render](DateEditor.md#render)
- [renderContents](DateEditor.md#rendercontents)
- [set\_maxDate](DateEditor.md#set_maxdate)
- [set\_maxValue](DateEditor.md#set_maxvalue)
- [set\_minDate](DateEditor.md#set_mindate)
- [set\_minValue](DateEditor.md#set_minvalue)
- [set\_readOnly](DateEditor.md#set_readonly)
- [set\_sqlMinMax](DateEditor.md#set_sqlminmax)
- [set\_value](DateEditor.md#set_value)
- [syncOrAsyncThen](DateEditor.md#syncorasyncthen)
- [useIdPrefix](DateEditor.md#useidprefix)
- [create](DateEditor.md#create)
- [createDefaultElement](DateEditor.md#createdefaultelement)
- [dateInputKeyup](DateEditor.md#dateinputkeyup)
- [getWidgetName](DateEditor.md#getwidgetname)
- [uiPickerZIndexWorkaround](DateEditor.md#uipickerzindexworkaround)

## Constructors

### constructor

• **new DateEditor**\<`P`\>(`props`): [`DateEditor`](DateEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`DateEditorOptions`](../interfaces/DateEditorOptions.md) = [`DateEditorOptions`](../interfaces/DateEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`DateEditor`](DateEditor.md)\<`P`\>

#### Overrides

[EditorWidget](EditorWidget.md).[constructor](EditorWidget.md#constructor)

#### Defined in

[src/ui/editors/dateeditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L21)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Overrides

[EditorWidget](EditorWidget.md).[domNode](EditorWidget.md#domnode)

#### Defined in

[src/ui/editors/dateeditor.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L19)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[idPrefix](EditorWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[EditorWidget](EditorWidget.md).[options](EditorWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[uniqueName](EditorWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### dateInputChange

▪ `Static` **dateInputChange**: (`e`: `Event`) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |

##### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L203)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[EditorWidget](EditorWidget.md).[typeInfo](EditorWidget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

___

### useFlatpickr

▪ `Static` **useFlatpickr**: `boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L211)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

EditorWidget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

EditorWidget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L99)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L115)

___

### valueAsDate

• `get` **valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L126)

• `set` **valueAsDate**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L138)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addCssClass](EditorWidget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[change](EditorWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[changeSelect2](EditorWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### createFlatPickrTrigger

▸ **createFlatPickrTrigger**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/dateeditor.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L243)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[EditorWidget](EditorWidget.md).[destroy](EditorWidget.md#destroy)

#### Defined in

[src/ui/editors/dateeditor.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L83)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCssClass](EditorWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCustomAttribute](EditorWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[EditorWidget](EditorWidget.md).[getFieldElement](EditorWidget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFlatpickrOptions

▸ **getFlatpickrOptions**(`input`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLElement` |

#### Returns

`any`

#### Defined in

[src/ui/editors/dateeditor.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L213)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[EditorWidget](EditorWidget.md).[getGridField](EditorWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### get\_maxDate

▸ **get_maxDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L180)

___

### get\_maxValue

▸ **get_maxValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L164)

___

### get\_minDate

▸ **get_minDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L172)

___

### get\_minValue

▸ **get_minValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L156)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L142)

___

### get\_sqlMinMax

▸ **get_sqlMinMax**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L188)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/dateeditor.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L90)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[EditorWidget](EditorWidget.md).[init](EditorWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalInit](EditorWidget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalRenderContents](EditorWidget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[render](EditorWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[renderContents](EditorWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### set\_maxDate

▸ **set_maxDate**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L184)

___

### set\_maxValue

▸ **set_maxValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L168)

___

### set\_minDate

▸ **set_minDate**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L176)

___

### set\_minValue

▸ **set_minValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L160)

___

### set\_readOnly

▸ **set_readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L146)

___

### set\_sqlMinMax

▸ **set_sqlMinMax**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L192)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Implementation of

[IStringValue](IStringValue.md).[set_value](IStringValue.md#set_value)

#### Defined in

[src/ui/editors/dateeditor.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L103)

___

### syncOrAsyncThen

▸ **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `syncMethod` | () => `T` |
| `asyncMethod` | () => `PromiseLike`\<`T`\> |
| `then` | (`v`: `T`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[syncOrAsyncThen](EditorWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[EditorWidget](EditorWidget.md).[useIdPrefix](EditorWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### create

▸ **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Inherited from

[EditorWidget](EditorWidget.md).[create](EditorWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Overrides

[EditorWidget](EditorWidget.md).[createDefaultElement](EditorWidget.md#createdefaultelement)

#### Defined in

[src/ui/editors/dateeditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L18)

___

### dateInputKeyup

▸ **dateInputKeyup**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `KeyboardEvent` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L207)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getWidgetName](EditorWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

___

### uiPickerZIndexWorkaround

▸ **uiPickerZIndexWorkaround**(`el`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L249)
