[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / PropertyPanel

# Class: PropertyPanel<TItem, TOptions\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`TemplatedPanel`](TemplatedPanel.md)<`TOptions`\>

  ↳ **`PropertyPanel`**

## Table of contents

### Constructors

- [constructor](PropertyPanel.md#constructor)

### Properties

- [\_entity](PropertyPanel.md#_entity)
- [\_entityId](PropertyPanel.md#_entityid)
- [element](PropertyPanel.md#element)
- [idPrefix](PropertyPanel.md#idprefix)
- [isPanel](PropertyPanel.md#ispanel)
- [options](PropertyPanel.md#options)
- [propertyGrid](PropertyPanel.md#propertygrid)
- [responsive](PropertyPanel.md#responsive)
- [tabs](PropertyPanel.md#tabs)
- [toolbar](PropertyPanel.md#toolbar)
- [uniqueName](PropertyPanel.md#uniquename)
- [validator](PropertyPanel.md#validator)
- [widgetName](PropertyPanel.md#widgetname)

### Methods

- [addCssClass](PropertyPanel.md#addcssclass)
- [addValidationRule](PropertyPanel.md#addvalidationrule)
- [arrange](PropertyPanel.md#arrange)
- [byId](PropertyPanel.md#byid)
- [change](PropertyPanel.md#change)
- [changeSelect2](PropertyPanel.md#changeselect2)
- [destroy](PropertyPanel.md#destroy)
- [getCssClass](PropertyPanel.md#getcssclass)
- [getFallbackTemplate](PropertyPanel.md#getfallbacktemplate)
- [getFormKey](PropertyPanel.md#getformkey)
- [getGridField](PropertyPanel.md#getgridfield)
- [getPropertyGridOptions](PropertyPanel.md#getpropertygridoptions)
- [getPropertyItems](PropertyPanel.md#getpropertyitems)
- [getSaveEntity](PropertyPanel.md#getsaveentity)
- [getTemplate](PropertyPanel.md#gettemplate)
- [getTemplateName](PropertyPanel.md#gettemplatename)
- [getToolbarButtons](PropertyPanel.md#gettoolbarbuttons)
- [getValidatorOptions](PropertyPanel.md#getvalidatoroptions)
- [get\_entity](PropertyPanel.md#get_entity)
- [get\_entityId](PropertyPanel.md#get_entityid)
- [init](PropertyPanel.md#init)
- [initPropertyGrid](PropertyPanel.md#initpropertygrid)
- [initTabs](PropertyPanel.md#inittabs)
- [initToolbar](PropertyPanel.md#inittoolbar)
- [initValidator](PropertyPanel.md#initvalidator)
- [initialize](PropertyPanel.md#initialize)
- [loadInitialEntity](PropertyPanel.md#loadinitialentity)
- [renderContents](PropertyPanel.md#rendercontents)
- [resetValidation](PropertyPanel.md#resetvalidation)
- [set\_entity](PropertyPanel.md#set_entity)
- [set\_entityId](PropertyPanel.md#set_entityid)
- [useIdPrefix](PropertyPanel.md#useidprefix)
- [validateBeforeSave](PropertyPanel.md#validatebeforesave)
- [validateForm](PropertyPanel.md#validateform)
- [create](PropertyPanel.md#create)
- [elementFor](PropertyPanel.md#elementfor)
- [getWidgetName](PropertyPanel.md#getwidgetname)

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

[TemplatedPanel](TemplatedPanel.md).[constructor](TemplatedPanel.md#constructor)

#### Defined in

[src/ui/widgets/propertypanel.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L12)

## Properties

### \_entity

• `Private` **\_entity**: `TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L9)

___

### \_entityId

• `Private` **\_entityId**: `any`

#### Defined in

[src/ui/widgets/propertypanel.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L10)

___

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[element](TemplatedPanel.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[idPrefix](TemplatedPanel.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### isPanel

• `Protected` **isPanel**: `boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[isPanel](TemplatedPanel.md#ispanel)

#### Defined in

[src/ui/widgets/templatedpanel.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L38)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[options](TemplatedPanel.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L113)

___

### responsive

• `Protected` **responsive**: `boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[responsive](TemplatedPanel.md#responsive)

#### Defined in

[src/ui/widgets/templatedpanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L39)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[tabs](TemplatedPanel.md#tabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L35)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[toolbar](TemplatedPanel.md#toolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L36)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[uniqueName](TemplatedPanel.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### validator

• `Protected` **validator**: `Validator`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[validator](TemplatedPanel.md#validator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L37)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[widgetName](TemplatedPanel.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[addCssClass](TemplatedPanel.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

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

[TemplatedPanel](TemplatedPanel.md).[addValidationRule](TemplatedPanel.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[arrange](TemplatedPanel.md#arrange)

#### Defined in

[src/ui/widgets/templatedpanel.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L41)

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

[TemplatedPanel](TemplatedPanel.md).[byId](TemplatedPanel.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L10)

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

[TemplatedPanel](TemplatedPanel.md).[change](TemplatedPanel.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[change](TemplatedPanel.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

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

[TemplatedPanel](TemplatedPanel.md).[changeSelect2](TemplatedPanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[changeSelect2](TemplatedPanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedPanel](TemplatedPanel.md).[destroy](TemplatedPanel.md#destroy)

#### Defined in

[src/ui/widgets/propertypanel.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L19)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getCssClass](TemplatedPanel.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getFallbackTemplate](TemplatedPanel.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getFormKey

▸ `Protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertypanel.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L49)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getGridField](TemplatedPanel.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getPropertyGridOptions

▸ `Protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L70)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertypanel.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L80)

___

### getSaveEntity

▸ `Protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L85)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getTemplate](TemplatedPanel.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getTemplateName](TemplatedPanel.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getToolbarButtons](TemplatedPanel.md#gettoolbarbuttons)

#### Defined in

[src/ui/widgets/templatedpanel.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L47)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[getValidatorOptions](TemplatedPanel.md#getvalidatoroptions)

#### Defined in

[src/ui/widgets/templatedpanel.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L51)

___

### get\_entity

▸ `Protected` **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L93)

___

### get\_entityId

▸ `Protected` **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertypanel.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L97)

___

### init

▸ **init**(`action?`): [`PropertyPanel`](PropertyPanel.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PropertyPanel`](PropertyPanel.md)<`TItem`, `TOptions`\>

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[init](TemplatedPanel.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initPropertyGrid

▸ `Protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L31)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initTabs](TemplatedPanel.md#inittabs)

#### Defined in

[src/ui/widgets/templatedpanel.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L55)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initToolbar](TemplatedPanel.md#inittoolbar)

#### Defined in

[src/ui/widgets/templatedpanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L63)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initValidator](TemplatedPanel.md#initvalidator)

#### Defined in

[src/ui/widgets/templatedpanel.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L72)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[initialize](TemplatedPanel.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### loadInitialEntity

▸ `Protected` **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L43)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[renderContents](TemplatedPanel.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[resetValidation](TemplatedPanel.md#resetvalidation)

#### Defined in

[src/ui/widgets/templatedpanel.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L80)

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

[src/ui/widgets/propertypanel.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L101)

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

[src/ui/widgets/propertypanel.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L105)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[useIdPrefix](TemplatedPanel.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

___

### validateBeforeSave

▸ `Protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/propertypanel.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L109)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[validateForm](TemplatedPanel.md#validateform)

#### Defined in

[src/ui/widgets/templatedpanel.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L86)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedPanel](TemplatedPanel.md).[create](TemplatedPanel.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

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

[TemplatedPanel](TemplatedPanel.md).[elementFor](TemplatedPanel.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

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

[TemplatedPanel](TemplatedPanel.md).[getWidgetName](TemplatedPanel.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
