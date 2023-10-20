[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / TemplatedPanel

# Class: TemplatedPanel<TOptions\>

## Type parameters

| Name |
| :------ |
| `TOptions` |

## Hierarchy

- [`TemplatedWidget`](TemplatedWidget.md)<`TOptions`\>

  ↳ **`TemplatedPanel`**

  ↳↳ [`PropertyPanel`](PropertyPanel.md)

## Table of contents

### Constructors

- [constructor](TemplatedPanel.md#constructor)

### Properties

- [element](TemplatedPanel.md#element)
- [idPrefix](TemplatedPanel.md#idprefix)
- [isPanel](TemplatedPanel.md#ispanel)
- [options](TemplatedPanel.md#options)
- [responsive](TemplatedPanel.md#responsive)
- [tabs](TemplatedPanel.md#tabs)
- [toolbar](TemplatedPanel.md#toolbar)
- [uniqueName](TemplatedPanel.md#uniquename)
- [validator](TemplatedPanel.md#validator)
- [widgetName](TemplatedPanel.md#widgetname)

### Methods

- [addCssClass](TemplatedPanel.md#addcssclass)
- [addValidationRule](TemplatedPanel.md#addvalidationrule)
- [arrange](TemplatedPanel.md#arrange)
- [byId](TemplatedPanel.md#byid)
- [change](TemplatedPanel.md#change)
- [changeSelect2](TemplatedPanel.md#changeselect2)
- [destroy](TemplatedPanel.md#destroy)
- [getCssClass](TemplatedPanel.md#getcssclass)
- [getFallbackTemplate](TemplatedPanel.md#getfallbacktemplate)
- [getGridField](TemplatedPanel.md#getgridfield)
- [getTemplate](TemplatedPanel.md#gettemplate)
- [getTemplateName](TemplatedPanel.md#gettemplatename)
- [getToolbarButtons](TemplatedPanel.md#gettoolbarbuttons)
- [getValidatorOptions](TemplatedPanel.md#getvalidatoroptions)
- [init](TemplatedPanel.md#init)
- [initTabs](TemplatedPanel.md#inittabs)
- [initToolbar](TemplatedPanel.md#inittoolbar)
- [initValidator](TemplatedPanel.md#initvalidator)
- [initialize](TemplatedPanel.md#initialize)
- [renderContents](TemplatedPanel.md#rendercontents)
- [resetValidation](TemplatedPanel.md#resetvalidation)
- [useIdPrefix](TemplatedPanel.md#useidprefix)
- [validateForm](TemplatedPanel.md#validateform)
- [create](TemplatedPanel.md#create)
- [elementFor](TemplatedPanel.md#elementfor)
- [getWidgetName](TemplatedPanel.md#getwidgetname)

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

[TemplatedWidget](TemplatedWidget.md).[constructor](TemplatedWidget.md#constructor)

#### Defined in

[src/ui/widgets/templatedpanel.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L8)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[element](TemplatedWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[idPrefix](TemplatedWidget.md#idprefix)

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

[TemplatedWidget](TemplatedWidget.md).[options](TemplatedWidget.md#options)

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

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Defined in

[src/ui/widgets/templatedpanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L36)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[uniqueName](TemplatedWidget.md#uniquename)

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

[TemplatedWidget](TemplatedWidget.md).[widgetName](TemplatedWidget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[addCssClass](TemplatedWidget.md#addcssclass)

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

[TemplatedWidget](TemplatedWidget.md).[addValidationRule](TemplatedWidget.md#addvalidationrule)

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

[TemplatedWidget](TemplatedWidget.md).[byId](TemplatedWidget.md#byid-1)

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

[TemplatedWidget](TemplatedWidget.md).[change](TemplatedWidget.md#change)

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

[TemplatedWidget](TemplatedWidget.md).[change](TemplatedWidget.md#change)

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

[TemplatedWidget](TemplatedWidget.md).[changeSelect2](TemplatedWidget.md#changeselect2)

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

[TemplatedWidget](TemplatedWidget.md).[changeSelect2](TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[destroy](TemplatedWidget.md#destroy)

#### Defined in

[src/ui/widgets/templatedpanel.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedpanel.ts#L16)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getCssClass](TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getFallbackTemplate](TemplatedWidget.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getGridField](TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getTemplate](TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getTemplateName](TemplatedWidget.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

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

▸ **init**(`action?`): [`TemplatedPanel`](TemplatedPanel.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`TemplatedPanel`](TemplatedPanel.md)<`TOptions`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[init](TemplatedWidget.md#init)

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

[TemplatedWidget](TemplatedWidget.md).[initialize](TemplatedWidget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[renderContents](TemplatedWidget.md#rendercontents)

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

[TemplatedWidget](TemplatedWidget.md).[useIdPrefix](TemplatedWidget.md#useidprefix)

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
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[create](TemplatedWidget.md#create)

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

[TemplatedWidget](TemplatedWidget.md).[elementFor](TemplatedWidget.md#elementfor)

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

[TemplatedWidget](TemplatedWidget.md).[getWidgetName](TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
