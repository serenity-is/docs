[@serenity-is/corelib](../README.md) / Widget

# Class: Widget<TOptions\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TOptions` | `any` |

## Hierarchy

- **`Widget`**

  ↳ [`PopupMenuButton`](PopupMenuButton.md)

  ↳ [`Toolbar`](Toolbar.md)

  ↳ [`TemplatedWidget`](TemplatedWidget.md)

  ↳ [`PropertyGrid`](PropertyGrid.md)

  ↳ [`StringEditor`](StringEditor.md)

  ↳ [`TextAreaEditor`](TextAreaEditor.md)

  ↳ [`BooleanEditor`](BooleanEditor.md)

  ↳ [`DecimalEditor`](DecimalEditor.md)

  ↳ [`IntegerEditor`](IntegerEditor.md)

  ↳ [`DateEditor`](DateEditor.md)

  ↳ [`DateTimeEditor`](DateTimeEditor.md)

  ↳ [`TimeEditor`](TimeEditor.md)

  ↳ [`EmailEditor`](EmailEditor.md)

  ↳ [`RadioButtonEditor`](RadioButtonEditor.md)

  ↳ [`Select2Editor`](Select2Editor.md)

  ↳ [`HtmlContentEditor`](HtmlContentEditor.md)

  ↳ [`MaskedEditor`](MaskedEditor.md)

  ↳ [`Recaptcha`](Recaptcha.md)

  ↳ [`FileUploadEditor`](FileUploadEditor.md)

  ↳ [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)

  ↳ [`QuickFilterBar`](QuickFilterBar.md)

  ↳ [`QuickSearchInput`](QuickSearchInput.md)

  ↳ [`SlickPager`](SlickPager.md)

  ↳ [`DataGrid`](DataGrid.md)

  ↳ [`ReportPage`](Reporting.ReportPage.md)

  ↳ [`Flexify`](Flexify.md)

  ↳ [`GoogleMap`](GoogleMap.md)

  ↳ [`Select2AjaxEditor`](Select2AjaxEditor.md)

## Table of contents

### Constructors

- [constructor](Widget.md#constructor)

### Properties

- [element](Widget.md#element)
- [idPrefix](Widget.md#idprefix)
- [options](Widget.md#options)
- [uniqueName](Widget.md#uniquename)
- [widgetName](Widget.md#widgetname)
- [\_\_isWidgetType](Widget.md#__iswidgettype)
- [nextWidgetNumber](Widget.md#nextwidgetnumber)

### Methods

- [addCssClass](Widget.md#addcssclass)
- [addValidationRule](Widget.md#addvalidationrule)
- [change](Widget.md#change)
- [changeSelect2](Widget.md#changeselect2)
- [destroy](Widget.md#destroy)
- [getCssClass](Widget.md#getcssclass)
- [getGridField](Widget.md#getgridfield)
- [init](Widget.md#init)
- [initialize](Widget.md#initialize)
- [renderContents](Widget.md#rendercontents)
- [create](Widget.md#create)
- [elementFor](Widget.md#elementfor)
- [getWidgetName](Widget.md#getwidgetname)

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

▸ **init**(`action?`): [`Widget`](Widget.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Widget`](Widget.md)<`TOptions`\>

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
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

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
