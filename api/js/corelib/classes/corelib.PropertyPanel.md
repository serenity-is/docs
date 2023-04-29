[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PropertyPanel

# Class: PropertyPanel<TItem, TOptions\>

[corelib](../modules/corelib.md).PropertyPanel

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`TemplatedPanel`](corelib.TemplatedPanel.md)<`TOptions`\>

  ↳ **`PropertyPanel`**

## Table of contents

### Constructors

- [constructor](corelib.PropertyPanel.md#constructor)

### Properties

- [\_entity](corelib.PropertyPanel.md#_entity)
- [\_entityId](corelib.PropertyPanel.md#_entityid)
- [element](corelib.PropertyPanel.md#element)
- [idPrefix](corelib.PropertyPanel.md#idprefix)
- [isPanel](corelib.PropertyPanel.md#ispanel)
- [options](corelib.PropertyPanel.md#options)
- [propertyGrid](corelib.PropertyPanel.md#propertygrid)
- [responsive](corelib.PropertyPanel.md#responsive)
- [tabs](corelib.PropertyPanel.md#tabs)
- [toolbar](corelib.PropertyPanel.md#toolbar)
- [uniqueName](corelib.PropertyPanel.md#uniquename)
- [validator](corelib.PropertyPanel.md#validator)
- [widgetName](corelib.PropertyPanel.md#widgetname)

### Methods

- [addCssClass](corelib.PropertyPanel.md#addcssclass)
- [addValidationRule](corelib.PropertyPanel.md#addvalidationrule)
- [arrange](corelib.PropertyPanel.md#arrange)
- [byId](corelib.PropertyPanel.md#byid)
- [change](corelib.PropertyPanel.md#change)
- [changeSelect2](corelib.PropertyPanel.md#changeselect2)
- [destroy](corelib.PropertyPanel.md#destroy)
- [getCssClass](corelib.PropertyPanel.md#getcssclass)
- [getFallbackTemplate](corelib.PropertyPanel.md#getfallbacktemplate)
- [getFormKey](corelib.PropertyPanel.md#getformkey)
- [getGridField](corelib.PropertyPanel.md#getgridfield)
- [getPropertyGridOptions](corelib.PropertyPanel.md#getpropertygridoptions)
- [getPropertyItems](corelib.PropertyPanel.md#getpropertyitems)
- [getSaveEntity](corelib.PropertyPanel.md#getsaveentity)
- [getTemplate](corelib.PropertyPanel.md#gettemplate)
- [getTemplateName](corelib.PropertyPanel.md#gettemplatename)
- [getToolbarButtons](corelib.PropertyPanel.md#gettoolbarbuttons)
- [getValidatorOptions](corelib.PropertyPanel.md#getvalidatoroptions)
- [get\_entity](corelib.PropertyPanel.md#get_entity)
- [get\_entityId](corelib.PropertyPanel.md#get_entityid)
- [init](corelib.PropertyPanel.md#init)
- [initPropertyGrid](corelib.PropertyPanel.md#initpropertygrid)
- [initTabs](corelib.PropertyPanel.md#inittabs)
- [initToolbar](corelib.PropertyPanel.md#inittoolbar)
- [initValidator](corelib.PropertyPanel.md#initvalidator)
- [initialize](corelib.PropertyPanel.md#initialize)
- [loadInitialEntity](corelib.PropertyPanel.md#loadinitialentity)
- [renderContents](corelib.PropertyPanel.md#rendercontents)
- [resetValidation](corelib.PropertyPanel.md#resetvalidation)
- [set\_entity](corelib.PropertyPanel.md#set_entity)
- [set\_entityId](corelib.PropertyPanel.md#set_entityid)
- [useIdPrefix](corelib.PropertyPanel.md#useidprefix)
- [validateBeforeSave](corelib.PropertyPanel.md#validatebeforesave)
- [validateForm](corelib.PropertyPanel.md#validateform)
- [create](corelib.PropertyPanel.md#create)
- [elementFor](corelib.PropertyPanel.md#elementfor)
- [getWidgetName](corelib.PropertyPanel.md#getwidgetname)

## Constructors

### constructor

• **new PropertyPanel**<`TItem`, `TOptions`\>(`container`, `options?`)

#### Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `options?` | `TOptions` |

#### Overrides

[TemplatedPanel](corelib.TemplatedPanel.md).[constructor](corelib.TemplatedPanel.md#constructor)

#### Defined in

[src/ui/widgets/propertypanel.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;12)

## Properties

### \_entity

• `Private` **\_entity**: `TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;9)

___

### \_entityId

• `Private` **\_entityId**: `any`

#### Defined in

[src/ui/widgets/propertypanel.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;10)

___

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[element](corelib.TemplatedPanel.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[idPrefix](corelib.TemplatedPanel.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### isPanel

• `Protected` **isPanel**: `boolean`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[isPanel](corelib.TemplatedPanel.md#ispanel)

#### Defined in

[src/ui/widgets/templatedpanel.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;38)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[options](corelib.TemplatedPanel.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](corelib.PropertyGrid.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;113)

___

### responsive

• `Protected` **responsive**: `boolean`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[responsive](corelib.TemplatedPanel.md#responsive)

#### Defined in

[src/ui/widgets/templatedpanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;39)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[tabs](corelib.TemplatedPanel.md#tabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;35)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[toolbar](corelib.TemplatedPanel.md#toolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;36)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[uniqueName](corelib.TemplatedPanel.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### validator

• `Protected` **validator**: `Validator`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[validator](corelib.TemplatedPanel.md#validator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;37)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[widgetName](corelib.TemplatedPanel.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[addCssClass](corelib.TemplatedPanel.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[addValidationRule](corelib.TemplatedPanel.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[arrange](corelib.TemplatedPanel.md#arrange)

#### Defined in

[src/ui/widgets/templatedpanel.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;41)

___

### byId

▸ `Protected` **byId**(`id`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[byId](corelib.TemplatedPanel.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;10)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[change](corelib.TemplatedPanel.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[change](corelib.TemplatedPanel.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[changeSelect2](corelib.TemplatedPanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[changeSelect2](corelib.TemplatedPanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedPanel](corelib.TemplatedPanel.md).[destroy](corelib.TemplatedPanel.md#destroy)

#### Defined in

[src/ui/widgets/propertypanel.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;19)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getCssClass](corelib.TemplatedPanel.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getFallbackTemplate](corelib.TemplatedPanel.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;79)

___

### getFormKey

▸ `Protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertypanel.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;49)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getGridField](corelib.TemplatedPanel.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getPropertyGridOptions

▸ `Protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;70)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertypanel.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;80)

___

### getSaveEntity

▸ `Protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;85)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getTemplate](corelib.TemplatedPanel.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getTemplateName](corelib.TemplatedPanel.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getToolbarButtons](corelib.TemplatedPanel.md#gettoolbarbuttons)

#### Defined in

[src/ui/widgets/templatedpanel.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;47)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getValidatorOptions](corelib.TemplatedPanel.md#getvalidatoroptions)

#### Defined in

[src/ui/widgets/templatedpanel.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;51)

___

### get\_entity

▸ `Protected` **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;93)

___

### get\_entityId

▸ `Protected` **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertypanel.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;97)

___

### init

▸ **init**(`action?`): [`PropertyPanel`](corelib.PropertyPanel.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PropertyPanel`](corelib.PropertyPanel.md)<`TItem`, `TOptions`\>

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[init](corelib.TemplatedPanel.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initPropertyGrid

▸ `Protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;31)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[initTabs](corelib.TemplatedPanel.md#inittabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;55)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[initToolbar](corelib.TemplatedPanel.md#inittoolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;63)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[initValidator](corelib.TemplatedPanel.md#initvalidator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;72)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[initialize](corelib.TemplatedPanel.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### loadInitialEntity

▸ `Protected` **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;43)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[renderContents](corelib.TemplatedPanel.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[resetValidation](corelib.TemplatedPanel.md#resetvalidation)

#### Defined in

[src/ui/widgets/templatedpanel.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;80)

___

### set\_entity

▸ `Protected` **set_entity**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;101)

___

### set\_entityId

▸ `Protected` **set_entityId**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;105)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[useIdPrefix](corelib.TemplatedPanel.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;131)

___

### validateBeforeSave

▸ `Protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/propertypanel.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#line&#x3D;109)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[validateForm](corelib.TemplatedPanel.md#validateform)

#### Defined in

[src/ui/widgets/templatedpanel.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#line&#x3D;86)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[create](corelib.TemplatedPanel.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[elementFor](corelib.TemplatedPanel.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[TemplatedPanel](corelib.TemplatedPanel.md).[getWidgetName](corelib.TemplatedPanel.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)
