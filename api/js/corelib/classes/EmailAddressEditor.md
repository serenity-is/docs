[@serenity-is/corelib](../README.md) / EmailAddressEditor

# Class: EmailAddressEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

## Hierarchy

- [`StringEditor`](StringEditor.md)\<`P`\>

  ↳ **`EmailAddressEditor`**

## Table of contents

### Constructors

- [constructor](EmailAddressEditor.md#constructor)

### Properties

- [domNode](EmailAddressEditor.md#domnode)
- [idPrefix](EmailAddressEditor.md#idprefix)
- [options](EmailAddressEditor.md#options)
- [uniqueName](EmailAddressEditor.md#uniquename)
- [typeInfo](EmailAddressEditor.md#typeinfo)

### Accessors

- [element](EmailAddressEditor.md#element)
- [props](EmailAddressEditor.md#props)
- [value](EmailAddressEditor.md#value)

### Methods

- [addCssClass](EmailAddressEditor.md#addcssclass)
- [addValidationRule](EmailAddressEditor.md#addvalidationrule)
- [change](EmailAddressEditor.md#change)
- [changeSelect2](EmailAddressEditor.md#changeselect2)
- [destroy](EmailAddressEditor.md#destroy)
- [getCssClass](EmailAddressEditor.md#getcssclass)
- [getCustomAttribute](EmailAddressEditor.md#getcustomattribute)
- [getFieldElement](EmailAddressEditor.md#getfieldelement)
- [getGridField](EmailAddressEditor.md#getgridfield)
- [get\_value](EmailAddressEditor.md#get_value)
- [init](EmailAddressEditor.md#init)
- [internalInit](EmailAddressEditor.md#internalinit)
- [internalRenderContents](EmailAddressEditor.md#internalrendercontents)
- [render](EmailAddressEditor.md#render)
- [renderContents](EmailAddressEditor.md#rendercontents)
- [set\_value](EmailAddressEditor.md#set_value)
- [syncOrAsyncThen](EmailAddressEditor.md#syncorasyncthen)
- [useIdPrefix](EmailAddressEditor.md#useidprefix)
- [create](EmailAddressEditor.md#create)
- [createDefaultElement](EmailAddressEditor.md#createdefaultelement)
- [getWidgetName](EmailAddressEditor.md#getwidgetname)

## Constructors

### constructor

• **new EmailAddressEditor**\<`P`\>(`props`): [`EmailAddressEditor`](EmailAddressEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`EmailAddressEditor`](EmailAddressEditor.md)\<`P`\>

#### Overrides

[StringEditor](StringEditor.md).[constructor](StringEditor.md#constructor)

#### Defined in

[src/ui/editors/emailaddresseditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/emailaddresseditor.ts#L11)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLInputElement`

#### Inherited from

[StringEditor](StringEditor.md).[domNode](StringEditor.md#domnode)

#### Defined in

[src/ui/editors/stringeditor.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L10)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[StringEditor](StringEditor.md).[idPrefix](StringEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[StringEditor](StringEditor.md).[options](StringEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[StringEditor](StringEditor.md).[uniqueName](StringEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### typeInfo

▪ `Static` **typeInfo**: [`EditorTypeInfo`](../README.md#editortypeinfo)\<``"Serenity.StringEditor"``\>

#### Inherited from

[StringEditor](StringEditor.md).[typeInfo](StringEditor.md#typeinfo)

#### Defined in

[src/ui/editors/stringeditor.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L8)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

StringEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

StringEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

StringEditor.value

#### Defined in

[src/ui/editors/stringeditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L14)

• `set` **value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

StringEditor.value

#### Defined in

[src/ui/editors/stringeditor.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L22)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](StringEditor.md).[addCssClass](StringEditor.md#addcssclass)

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

[StringEditor](StringEditor.md).[addValidationRule](StringEditor.md#addvalidationrule)

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

[StringEditor](StringEditor.md).[addValidationRule](StringEditor.md#addvalidationrule)

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

[StringEditor](StringEditor.md).[change](StringEditor.md#change)

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

[StringEditor](StringEditor.md).[changeSelect2](StringEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](StringEditor.md).[destroy](StringEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L49)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[StringEditor](StringEditor.md).[getCssClass](StringEditor.md#getcssclass)

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

[StringEditor](StringEditor.md).[getCustomAttribute](StringEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[StringEditor](StringEditor.md).[getFieldElement](StringEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[StringEditor](StringEditor.md).[getGridField](StringEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[StringEditor](StringEditor.md).[get_value](StringEditor.md#get_value)

#### Defined in

[src/ui/editors/stringeditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L18)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[StringEditor](StringEditor.md).[init](StringEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](StringEditor.md).[internalInit](StringEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](StringEditor.md).[internalRenderContents](StringEditor.md#internalrendercontents)

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

[StringEditor](StringEditor.md).[render](StringEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[StringEditor](StringEditor.md).[renderContents](StringEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[StringEditor](StringEditor.md).[set_value](StringEditor.md#set_value)

#### Defined in

[src/ui/editors/stringeditor.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L26)

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

[StringEditor](StringEditor.md).[syncOrAsyncThen](StringEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[StringEditor](StringEditor.md).[useIdPrefix](StringEditor.md#useidprefix)

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

[StringEditor](StringEditor.md).[create](StringEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Overrides

[StringEditor](StringEditor.md).[createDefaultElement](StringEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/emailaddresseditor.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/emailaddresseditor.ts#L9)

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

[StringEditor](StringEditor.md).[getWidgetName](StringEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
