[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DecimalEditor

# Class: DecimalEditor

[corelib](../modules/corelib.md).DecimalEditor

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`DecimalEditorOptions`](../interfaces/corelib.DecimalEditorOptions.md)\>

  ↳ **`DecimalEditor`**

## Implements

- [`IDoubleValue`](corelib.IDoubleValue.md)

## Table of contents

### Constructors

- [constructor](corelib.DecimalEditor.md#constructor)

### Properties

- [element](corelib.DecimalEditor.md#element)
- [idPrefix](corelib.DecimalEditor.md#idprefix)
- [options](corelib.DecimalEditor.md#options)
- [uniqueName](corelib.DecimalEditor.md#uniquename)
- [widgetName](corelib.DecimalEditor.md#widgetname)

### Accessors

- [value](corelib.DecimalEditor.md#value)

### Methods

- [addCssClass](corelib.DecimalEditor.md#addcssclass)
- [addValidationRule](corelib.DecimalEditor.md#addvalidationrule)
- [change](corelib.DecimalEditor.md#change)
- [changeSelect2](corelib.DecimalEditor.md#changeselect2)
- [destroy](corelib.DecimalEditor.md#destroy)
- [getCssClass](corelib.DecimalEditor.md#getcssclass)
- [getGridField](corelib.DecimalEditor.md#getgridfield)
- [get\_isValid](corelib.DecimalEditor.md#get_isvalid)
- [get\_value](corelib.DecimalEditor.md#get_value)
- [init](corelib.DecimalEditor.md#init)
- [initialize](corelib.DecimalEditor.md#initialize)
- [renderContents](corelib.DecimalEditor.md#rendercontents)
- [set\_value](corelib.DecimalEditor.md#set_value)
- [create](corelib.DecimalEditor.md#create)
- [defaultAutoNumericOptions](corelib.DecimalEditor.md#defaultautonumericoptions)
- [elementFor](corelib.DecimalEditor.md#elementfor)
- [getWidgetName](corelib.DecimalEditor.md#getwidgetname)

## Constructors

### constructor

• **new DecimalEditor**(`input`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |
| `opt?` | [`DecimalEditorOptions`](../interfaces/corelib.DecimalEditorOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/decimaleditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L18)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`DecimalEditorOptions`](../interfaces/corelib.DecimalEditorOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/editors/decimaleditor.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L53)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `number` |

#### Returns

`void`

#### Defined in

[src/ui/editors/decimaleditor.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L68)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

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

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

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

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

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

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### get\_isValid

▸ **get_isValid**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/decimaleditor.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L72)

___

### get\_value

▸ **get_value**(): `number`

#### Returns

`number`

#### Implementation of

[IDoubleValue](corelib.IDoubleValue.md).[get_value](corelib.IDoubleValue.md#get_value)

#### Defined in

[src/ui/editors/decimaleditor.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L39)

___

### init

▸ **init**(`action?`): [`DecimalEditor`](corelib.DecimalEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DecimalEditor`](corelib.DecimalEditor.md)

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `number` |

#### Returns

`void`

#### Implementation of

[IDoubleValue](corelib.IDoubleValue.md).[set_value](corelib.IDoubleValue.md#set_value)

#### Defined in

[src/ui/editors/decimaleditor.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L57)

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

[Widget](corelib.Widget.md).[create](corelib.Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

___

### defaultAutoNumericOptions

▸ `Static` **defaultAutoNumericOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/decimaleditor.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/decimaleditor.ts#L76)

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

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

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

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
