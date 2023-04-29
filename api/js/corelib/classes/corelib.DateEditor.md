[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DateEditor

# Class: DateEditor

[corelib](../modules/corelib.md).DateEditor

## Hierarchy

- [`Widget`](corelib.Widget.md)<`any`\>

  ↳ **`DateEditor`**

## Implements

- [`IStringValue`](corelib.IStringValue.md)
- [`IReadOnly`](corelib.IReadOnly.md)

## Table of contents

### Constructors

- [constructor](corelib.DateEditor.md#constructor)

### Properties

- [element](corelib.DateEditor.md#element)
- [idPrefix](corelib.DateEditor.md#idprefix)
- [maxValue](corelib.DateEditor.md#maxvalue)
- [minValue](corelib.DateEditor.md#minvalue)
- [options](corelib.DateEditor.md#options)
- [uniqueName](corelib.DateEditor.md#uniquename)
- [widgetName](corelib.DateEditor.md#widgetname)
- [yearRange](corelib.DateEditor.md#yearrange)
- [dateInputChange](corelib.DateEditor.md#dateinputchange)
- [useFlatpickr](corelib.DateEditor.md#useflatpickr)

### Accessors

- [value](corelib.DateEditor.md#value)
- [valueAsDate](corelib.DateEditor.md#valueasdate)

### Methods

- [addCssClass](corelib.DateEditor.md#addcssclass)
- [addValidationRule](corelib.DateEditor.md#addvalidationrule)
- [change](corelib.DateEditor.md#change)
- [changeSelect2](corelib.DateEditor.md#changeselect2)
- [destroy](corelib.DateEditor.md#destroy)
- [getCssClass](corelib.DateEditor.md#getcssclass)
- [getGridField](corelib.DateEditor.md#getgridfield)
- [get\_maxDate](corelib.DateEditor.md#get_maxdate)
- [get\_maxValue](corelib.DateEditor.md#get_maxvalue)
- [get\_minDate](corelib.DateEditor.md#get_mindate)
- [get\_minValue](corelib.DateEditor.md#get_minvalue)
- [get\_readOnly](corelib.DateEditor.md#get_readonly)
- [get\_sqlMinMax](corelib.DateEditor.md#get_sqlminmax)
- [get\_value](corelib.DateEditor.md#get_value)
- [get\_valueAsDate](corelib.DateEditor.md#get_valueasdate)
- [init](corelib.DateEditor.md#init)
- [initialize](corelib.DateEditor.md#initialize)
- [renderContents](corelib.DateEditor.md#rendercontents)
- [set\_maxDate](corelib.DateEditor.md#set_maxdate)
- [set\_maxValue](corelib.DateEditor.md#set_maxvalue)
- [set\_minDate](corelib.DateEditor.md#set_mindate)
- [set\_minValue](corelib.DateEditor.md#set_minvalue)
- [set\_readOnly](corelib.DateEditor.md#set_readonly)
- [set\_sqlMinMax](corelib.DateEditor.md#set_sqlminmax)
- [set\_value](corelib.DateEditor.md#set_value)
- [set\_valueAsDate](corelib.DateEditor.md#set_valueasdate)
- [create](corelib.DateEditor.md#create)
- [dateInputKeyup](corelib.DateEditor.md#dateinputkeyup)
- [elementFor](corelib.DateEditor.md#elementfor)
- [flatPickrOptions](corelib.DateEditor.md#flatpickroptions)
- [flatPickrTrigger](corelib.DateEditor.md#flatpickrtrigger)
- [getWidgetName](corelib.DateEditor.md#getwidgetname)
- [uiPickerZIndexWorkaround](corelib.DateEditor.md#uipickerzindexworkaround)

## Constructors

### constructor

• **new DateEditor**(`input`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/dateeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;15)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### maxValue

• `Private` **maxValue**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;13)

___

### minValue

• `Private` **minValue**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;12)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

___

### yearRange

• **yearRange**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;159)

___

### dateInputChange

▪ `Static` **dateInputChange**: (`e`: `JQueryEventObject`) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

##### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;212)

___

### useFlatpickr

▪ `Static` **useFlatpickr**: `boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;74)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;96)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;112)

___

### valueAsDate

• `get` **valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;124)

• `set` **valueAsDate**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;136)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

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

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### get\_maxDate

▸ **get_maxDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;187)

___

### get\_maxValue

▸ **get_maxValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;170)

___

### get\_minDate

▸ **get_minDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;179)

___

### get\_minValue

▸ **get_minValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;161)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;140)

___

### get\_sqlMinMax

▸ **get_sqlMinMax**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;196)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](corelib.IStringValue.md).[get_value](corelib.IStringValue.md#get_value)

#### Defined in

[src/ui/editors/dateeditor.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;87)

___

### get\_valueAsDate

▸ `Private` **get_valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;116)

___

### init

▸ **init**(`action?`): [`DateEditor`](corelib.DateEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DateEditor`](corelib.DateEditor.md)

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;184)

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

[src/ui/editors/dateeditor.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;192)

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

[src/ui/editors/dateeditor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;175)

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

[src/ui/editors/dateeditor.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;183)

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

[src/ui/editors/dateeditor.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;166)

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

[IReadOnly](corelib.IReadOnly.md).[set_readOnly](corelib.IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;144)

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

[src/ui/editors/dateeditor.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;201)

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

[IStringValue](corelib.IStringValue.md).[set_value](corelib.IStringValue.md#set_value)

#### Defined in

[src/ui/editors/dateeditor.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;100)

___

### set\_valueAsDate

▸ `Private` **set_valueAsDate**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;128)

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

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

___

### dateInputKeyup

▸ `Static` **dateInputKeyup**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;241)

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

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

___

### flatPickrOptions

▸ `Static` **flatPickrOptions**(`input`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `allowInput` | `boolean` |
| `clickOpens` | `boolean` |
| `dateFormat` | `string` |
| `onChange` | () => `void` |

#### Defined in

[src/ui/editors/dateeditor.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;76)

___

### flatPickrTrigger

▸ `Static` **flatPickrTrigger**(`input`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Returns

`JQuery`

#### Defined in

[src/ui/editors/dateeditor.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;232)

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

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)

___

### uiPickerZIndexWorkaround

▸ `Static` **uiPickerZIndexWorkaround**(`input`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#line&#x3D;409)
