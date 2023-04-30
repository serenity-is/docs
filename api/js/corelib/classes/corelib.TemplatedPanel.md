[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / TemplatedPanel

# Class: TemplatedPanel<TOptions\>

[corelib](../modules/corelib.md).TemplatedPanel

## Type parameters

| Name |
| :------ |
| `TOptions` |

## Hierarchy

- [`TemplatedWidget`](corelib.TemplatedWidget.md)<`TOptions`\>

  ↳ **`TemplatedPanel`**

  ↳↳ [`PropertyPanel`](corelib.PropertyPanel.md)

## Table of contents

### Constructors

- [constructor](corelib.TemplatedPanel.md#constructor)

### Properties

- [element](corelib.TemplatedPanel.md#element)
- [idPrefix](corelib.TemplatedPanel.md#idprefix)
- [isPanel](corelib.TemplatedPanel.md#ispanel)
- [options](corelib.TemplatedPanel.md#options)
- [responsive](corelib.TemplatedPanel.md#responsive)
- [tabs](corelib.TemplatedPanel.md#tabs)
- [toolbar](corelib.TemplatedPanel.md#toolbar)
- [uniqueName](corelib.TemplatedPanel.md#uniquename)
- [validator](corelib.TemplatedPanel.md#validator)
- [widgetName](corelib.TemplatedPanel.md#widgetname)

### Methods

- [addCssClass](corelib.TemplatedPanel.md#addcssclass)
- [addValidationRule](corelib.TemplatedPanel.md#addvalidationrule)
- [arrange](corelib.TemplatedPanel.md#arrange)
- [byId](corelib.TemplatedPanel.md#byid)
- [change](corelib.TemplatedPanel.md#change)
- [changeSelect2](corelib.TemplatedPanel.md#changeselect2)
- [destroy](corelib.TemplatedPanel.md#destroy)
- [getCssClass](corelib.TemplatedPanel.md#getcssclass)
- [getFallbackTemplate](corelib.TemplatedPanel.md#getfallbacktemplate)
- [getGridField](corelib.TemplatedPanel.md#getgridfield)
- [getTemplate](corelib.TemplatedPanel.md#gettemplate)
- [getTemplateName](corelib.TemplatedPanel.md#gettemplatename)
- [getToolbarButtons](corelib.TemplatedPanel.md#gettoolbarbuttons)
- [getValidatorOptions](corelib.TemplatedPanel.md#getvalidatoroptions)
- [init](corelib.TemplatedPanel.md#init)
- [initTabs](corelib.TemplatedPanel.md#inittabs)
- [initToolbar](corelib.TemplatedPanel.md#inittoolbar)
- [initValidator](corelib.TemplatedPanel.md#initvalidator)
- [initialize](corelib.TemplatedPanel.md#initialize)
- [renderContents](corelib.TemplatedPanel.md#rendercontents)
- [resetValidation](corelib.TemplatedPanel.md#resetvalidation)
- [useIdPrefix](corelib.TemplatedPanel.md#useidprefix)
- [validateForm](corelib.TemplatedPanel.md#validateform)
- [create](corelib.TemplatedPanel.md#create)
- [elementFor](corelib.TemplatedPanel.md#elementfor)
- [getWidgetName](corelib.TemplatedPanel.md#getwidgetname)

## Constructors

### constructor

• **new TemplatedPanel**<`TOptions`\>(`container`, `options?`)

#### Type parameters

| Name |
| :------ |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `options?` | `TOptions` |

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[constructor](corelib.TemplatedWidget.md#constructor)

#### Defined in

[src/ui/widgets/templatedpanel.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L8)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[element](corelib.TemplatedWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[idPrefix](corelib.TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### isPanel

• `Protected` **isPanel**: `boolean`

#### Defined in

[src/ui/widgets/templatedpanel.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L38)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[options](corelib.TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### responsive

• `Protected` **responsive**: `boolean`

#### Defined in

[src/ui/widgets/templatedpanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L39)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Defined in

[src/ui/widgets/templatedpanel.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L35)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/widgets/templatedpanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L36)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[uniqueName](corelib.TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### validator

• `Protected` **validator**: `Validator`

#### Defined in

[src/ui/widgets/templatedpanel.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L37)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[widgetName](corelib.TemplatedWidget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[addCssClass](corelib.TemplatedWidget.md#addcssclass)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[addValidationRule](corelib.TemplatedWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

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

[TemplatedWidget](corelib.TemplatedWidget.md).[byId](corelib.TemplatedWidget.md#byid-1)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[destroy](corelib.TemplatedWidget.md#destroy)

#### Defined in

[src/ui/widgets/templatedpanel.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L16)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getCssClass](corelib.TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getFallbackTemplate](corelib.TemplatedWidget.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getGridField](corelib.TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplate](corelib.TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplateName](corelib.TemplatedWidget.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Defined in

[src/ui/widgets/templatedpanel.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L47)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Defined in

[src/ui/widgets/templatedpanel.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L51)

___

### init

▸ **init**(`action?`): [`TemplatedPanel`](corelib.TemplatedPanel.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`TemplatedPanel`](corelib.TemplatedPanel.md)<`TOptions`\>

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[init](corelib.TemplatedWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/templatedpanel.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L55)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/templatedpanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L63)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/templatedpanel.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L72)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[initialize](corelib.TemplatedWidget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[renderContents](corelib.TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/templatedpanel.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L80)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[useIdPrefix](corelib.TemplatedWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/templatedpanel.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L86)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[create](corelib.TemplatedWidget.md#create)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[elementFor](corelib.TemplatedWidget.md#elementfor)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[getWidgetName](corelib.TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
