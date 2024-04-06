[@serenity-is/corelib](../README.md) / PropertyPanel

# Class: PropertyPanel\<TItem, P\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `P` |

## Hierarchy

- [`TemplatedPanel`](TemplatedPanel.md)\<`P`\>

  ↳ **`PropertyPanel`**

## Table of contents

### Constructors

- [constructor](PropertyPanel.md#constructor)

### Properties

- [domNode](PropertyPanel.md#domnode)
- [idPrefix](PropertyPanel.md#idprefix)
- [isPanel](PropertyPanel.md#ispanel)
- [options](PropertyPanel.md#options)
- [propertyGrid](PropertyPanel.md#propertygrid)
- [responsive](PropertyPanel.md#responsive)
- [tabs](PropertyPanel.md#tabs)
- [toolbar](PropertyPanel.md#toolbar)
- [uniqueName](PropertyPanel.md#uniquename)
- [validator](PropertyPanel.md#validator)
- [typeInfo](PropertyPanel.md#typeinfo)

### Accessors

- [element](PropertyPanel.md#element)
- [props](PropertyPanel.md#props)

### Methods

- [addCssClass](PropertyPanel.md#addcssclass)
- [addValidationRule](PropertyPanel.md#addvalidationrule)
- [arrange](PropertyPanel.md#arrange)
- [byId](PropertyPanel.md#byid)
- [change](PropertyPanel.md#change)
- [changeSelect2](PropertyPanel.md#changeselect2)
- [destroy](PropertyPanel.md#destroy)
- [findById](PropertyPanel.md#findbyid)
- [getCssClass](PropertyPanel.md#getcssclass)
- [getCustomAttribute](PropertyPanel.md#getcustomattribute)
- [getFieldElement](PropertyPanel.md#getfieldelement)
- [getFormKey](PropertyPanel.md#getformkey)
- [getGridField](PropertyPanel.md#getgridfield)
- [getPropertyGridOptions](PropertyPanel.md#getpropertygridoptions)
- [getPropertyItems](PropertyPanel.md#getpropertyitems)
- [getSaveEntity](PropertyPanel.md#getsaveentity)
- [getTemplate](PropertyPanel.md#gettemplate)
- [getToolbarButtons](PropertyPanel.md#gettoolbarbuttons)
- [getValidatorOptions](PropertyPanel.md#getvalidatoroptions)
- [get\_entity](PropertyPanel.md#get_entity)
- [get\_entityId](PropertyPanel.md#get_entityid)
- [init](PropertyPanel.md#init)
- [initPropertyGrid](PropertyPanel.md#initpropertygrid)
- [initTabs](PropertyPanel.md#inittabs)
- [initToolbar](PropertyPanel.md#inittoolbar)
- [initValidator](PropertyPanel.md#initvalidator)
- [internalInit](PropertyPanel.md#internalinit)
- [internalRenderContents](PropertyPanel.md#internalrendercontents)
- [loadInitialEntity](PropertyPanel.md#loadinitialentity)
- [render](PropertyPanel.md#render)
- [renderContents](PropertyPanel.md#rendercontents)
- [resetValidation](PropertyPanel.md#resetvalidation)
- [set\_entity](PropertyPanel.md#set_entity)
- [set\_entityId](PropertyPanel.md#set_entityid)
- [syncOrAsyncThen](PropertyPanel.md#syncorasyncthen)
- [useIdPrefix](PropertyPanel.md#useidprefix)
- [validateBeforeSave](PropertyPanel.md#validatebeforesave)
- [validateForm](PropertyPanel.md#validateform)
- [create](PropertyPanel.md#create)
- [createDefaultElement](PropertyPanel.md#createdefaultelement)
- [getWidgetName](PropertyPanel.md#getwidgetname)

## Constructors

### constructor

• **new PropertyPanel**\<`TItem`, `P`\>(`props`): [`PropertyPanel`](PropertyPanel.md)\<`TItem`, `P`\>

#### Type parameters

| Name |
| :------ |
| `TItem` |
| `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`PropertyPanel`](PropertyPanel.md)\<`TItem`, `P`\>

#### Overrides

[TemplatedPanel](TemplatedPanel.md).[constructor](TemplatedPanel.md#constructor)

#### Defined in

[src/ui/widgets/propertypanel.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L15)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[domNode](TemplatedPanel.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[idPrefix](TemplatedPanel.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### isPanel

• `Protected` **isPanel**: `boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[isPanel](TemplatedPanel.md#ispanel)

#### Defined in

[src/ui/widgets/templatedpanel.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L42)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[options](TemplatedPanel.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/widgets/propertypanel.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L107)

___

### responsive

• `Protected` **responsive**: `boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[responsive](TemplatedPanel.md#responsive)

#### Defined in

[src/ui/widgets/templatedpanel.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L43)

___

### tabs

• `Protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[tabs](TemplatedPanel.md#tabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L39)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[toolbar](TemplatedPanel.md#toolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L40)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[uniqueName](TemplatedPanel.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### validator

• `Protected` **validator**: [`Validator`](Validator.md)

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[validator](TemplatedPanel.md#validator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L41)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[typeInfo](TemplatedPanel.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

TemplatedPanel.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

TemplatedPanel.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[addCssClass](TemplatedPanel.md#addcssclass)

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

[TemplatedPanel](TemplatedPanel.md).[addValidationRule](TemplatedPanel.md#addvalidationrule)

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

[TemplatedPanel](TemplatedPanel.md).[addValidationRule](TemplatedPanel.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[arrange](TemplatedPanel.md#arrange)

#### Defined in

[src/ui/widgets/templatedpanel.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L45)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[byId](TemplatedPanel.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L8)

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

[TemplatedPanel](TemplatedPanel.md).[change](TemplatedPanel.md#change)

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

[TemplatedPanel](TemplatedPanel.md).[changeSelect2](TemplatedPanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedPanel](TemplatedPanel.md).[destroy](TemplatedPanel.md#destroy)

#### Defined in

[src/ui/widgets/propertypanel.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L22)

___

### findById

▸ **findById**\<`TElement`\>(`id`): `TElement`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`TElement`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[findById](TemplatedPanel.md#findbyid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L12)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getCssClass](TemplatedPanel.md#getcssclass)

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

[TemplatedPanel](TemplatedPanel.md).[getCustomAttribute](TemplatedPanel.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getFieldElement](TemplatedPanel.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFormKey

▸ **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertypanel.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L48)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getGridField](TemplatedPanel.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getPropertyGridOptions

▸ **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L64)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertypanel.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L74)

___

### getSaveEntity

▸ **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L79)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getTemplate](TemplatedPanel.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L16)

___

### getToolbarButtons

▸ **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getToolbarButtons](TemplatedPanel.md#gettoolbarbuttons)

#### Defined in

[src/ui/widgets/templatedpanel.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L51)

___

### getValidatorOptions

▸ **getValidatorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getValidatorOptions](TemplatedPanel.md#getvalidatoroptions)

#### Defined in

[src/ui/widgets/templatedpanel.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L55)

___

### get\_entity

▸ **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L87)

___

### get\_entityId

▸ **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertypanel.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L91)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[init](TemplatedPanel.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initPropertyGrid

▸ **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L34)

___

### initTabs

▸ **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initTabs](TemplatedPanel.md#inittabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L59)

___

### initToolbar

▸ **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initToolbar](TemplatedPanel.md#inittoolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L66)

___

### initValidator

▸ **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initValidator](TemplatedPanel.md#initvalidator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L73)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[internalInit](TemplatedPanel.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[internalRenderContents](TemplatedPanel.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### loadInitialEntity

▸ **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L42)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[render](TemplatedPanel.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[renderContents](TemplatedPanel.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L20)

___

### resetValidation

▸ **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[resetValidation](TemplatedPanel.md#resetvalidation)

#### Defined in

[src/ui/widgets/templatedpanel.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L81)

___

### set\_entity

▸ **set_entity**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L95)

___

### set\_entityId

▸ **set_entityId**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L99)

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

[TemplatedPanel](TemplatedPanel.md).[syncOrAsyncThen](TemplatedPanel.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[useIdPrefix](TemplatedPanel.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### validateBeforeSave

▸ **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/propertypanel.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L103)

___

### validateForm

▸ **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[validateForm](TemplatedPanel.md#validateform)

#### Defined in

[src/ui/widgets/templatedpanel.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L87)

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

[TemplatedPanel](TemplatedPanel.md).[create](TemplatedPanel.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[createDefaultElement](TemplatedPanel.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L60)

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

[TemplatedPanel](TemplatedPanel.md).[getWidgetName](TemplatedPanel.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
