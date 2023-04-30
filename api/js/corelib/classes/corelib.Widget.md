[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / Widget

# Class: Widget<TOptions\>

[corelib](../modules/corelib.md).Widget

## Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | `any` |

## Hierarchy

- **`Widget`**

  ↳ [`PopupMenuButton`](corelib.PopupMenuButton.md)

  ↳ [`Toolbar`](corelib.Toolbar.md)

  ↳ [`TemplatedWidget`](corelib.TemplatedWidget.md)

  ↳ [`PropertyGrid`](corelib.PropertyGrid.md)

  ↳ [`StringEditor`](corelib.StringEditor.md)

  ↳ [`TextAreaEditor`](corelib.TextAreaEditor.md)

  ↳ [`BooleanEditor`](corelib.BooleanEditor.md)

  ↳ [`DecimalEditor`](corelib.DecimalEditor.md)

  ↳ [`IntegerEditor`](corelib.IntegerEditor.md)

  ↳ [`DateEditor`](corelib.DateEditor.md)

  ↳ [`DateTimeEditor`](corelib.DateTimeEditor.md)

  ↳ [`TimeEditor`](corelib.TimeEditor.md)

  ↳ [`EmailEditor`](corelib.EmailEditor.md)

  ↳ [`RadioButtonEditor`](corelib.RadioButtonEditor.md)

  ↳ [`Select2Editor`](corelib.Select2Editor.md)

  ↳ [`HtmlContentEditor`](corelib.HtmlContentEditor.md)

  ↳ [`MaskedEditor`](corelib.MaskedEditor.md)

  ↳ [`Recaptcha`](corelib.Recaptcha.md)

  ↳ [`FileUploadEditor`](corelib.FileUploadEditor.md)

  ↳ [`MultipleFileUploadEditor`](corelib.MultipleFileUploadEditor.md)

  ↳ [`QuickFilterBar`](corelib.QuickFilterBar.md)

  ↳ [`QuickSearchInput`](corelib.QuickSearchInput.md)

  ↳ [`SlickPager`](corelib.SlickPager.md)

  ↳ [`DataGrid`](corelib.DataGrid.md)

  ↳ [`ReportPage`](corelib.Reporting.ReportPage.md)

  ↳ [`Flexify`](corelib.Flexify.md)

  ↳ [`GoogleMap`](corelib.GoogleMap.md)

  ↳ [`Select2AjaxEditor`](corelib.Select2AjaxEditor.md)

## Table of contents

### Constructors

- [constructor](corelib.Widget.md#constructor)

### Properties

- [element](corelib.Widget.md#element)
- [idPrefix](corelib.Widget.md#idprefix)
- [options](corelib.Widget.md#options)
- [uniqueName](corelib.Widget.md#uniquename)
- [widgetName](corelib.Widget.md#widgetname)
- [\_\_isWidgetType](corelib.Widget.md#__iswidgettype)
- [nextWidgetNumber](corelib.Widget.md#nextwidgetnumber)

### Methods

- [addCssClass](corelib.Widget.md#addcssclass)
- [addValidationRule](corelib.Widget.md#addvalidationrule)
- [change](corelib.Widget.md#change)
- [changeSelect2](corelib.Widget.md#changeselect2)
- [destroy](corelib.Widget.md#destroy)
- [getCssClass](corelib.Widget.md#getcssclass)
- [getGridField](corelib.Widget.md#getgridfield)
- [init](corelib.Widget.md#init)
- [initialize](corelib.Widget.md#initialize)
- [renderContents](corelib.Widget.md#rendercontents)
- [create](corelib.Widget.md#create)
- [elementFor](corelib.Widget.md#elementfor)
- [getWidgetName](corelib.Widget.md#getwidgetname)

## Constructors

### constructor

• **new Widget**<`TOptions`\>(`element`, `options?`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `options?` | `TOptions` |

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

## Properties

### element

• **element**: `JQuery`

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `TOptions`

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### \_\_isWidgetType

▪ `Static` `Private` **\_\_isWidgetType**: `boolean` = `true`

#### Defined in

[src/ui/widgets/widget.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L187)

___

### nextWidgetNumber

▪ `Static` `Private` **nextWidgetNumber**: `number` = `0`

#### Defined in

[src/ui/widgets/widget.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L60)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

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

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

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

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### init

▸ **init**(`action?`): [`Widget`](corelib.Widget.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Widget`](corelib.Widget.md)<`TOptions`\>

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

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

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
