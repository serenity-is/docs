[@serenity-is/corelib](../README.md) / DateEditor

# Class: DateEditor

## Hierarchy

- [`Widget`](Widget.md)<`any`\>

  ↳ **`DateEditor`**

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](DateEditor.md#constructor)

### Properties

- [element](DateEditor.md#element)
- [idPrefix](DateEditor.md#idprefix)
- [maxValue](DateEditor.md#maxvalue)
- [minValue](DateEditor.md#minvalue)
- [options](DateEditor.md#options)
- [uniqueName](DateEditor.md#uniquename)
- [widgetName](DateEditor.md#widgetname)
- [yearRange](DateEditor.md#yearrange)
- [dateInputChange](DateEditor.md#dateinputchange)
- [useFlatpickr](DateEditor.md#useflatpickr)

### Accessors

- [value](DateEditor.md#value)
- [valueAsDate](DateEditor.md#valueasdate)

### Methods

- [addCssClass](DateEditor.md#addcssclass)
- [addValidationRule](DateEditor.md#addvalidationrule)
- [change](DateEditor.md#change)
- [changeSelect2](DateEditor.md#changeselect2)
- [destroy](DateEditor.md#destroy)
- [getCssClass](DateEditor.md#getcssclass)
- [getGridField](DateEditor.md#getgridfield)
- [get\_maxDate](DateEditor.md#get_maxdate)
- [get\_maxValue](DateEditor.md#get_maxvalue)
- [get\_minDate](DateEditor.md#get_mindate)
- [get\_minValue](DateEditor.md#get_minvalue)
- [get\_readOnly](DateEditor.md#get_readonly)
- [get\_sqlMinMax](DateEditor.md#get_sqlminmax)
- [get\_value](DateEditor.md#get_value)
- [get\_valueAsDate](DateEditor.md#get_valueasdate)
- [init](DateEditor.md#init)
- [initialize](DateEditor.md#initialize)
- [renderContents](DateEditor.md#rendercontents)
- [set\_maxDate](DateEditor.md#set_maxdate)
- [set\_maxValue](DateEditor.md#set_maxvalue)
- [set\_minDate](DateEditor.md#set_mindate)
- [set\_minValue](DateEditor.md#set_minvalue)
- [set\_readOnly](DateEditor.md#set_readonly)
- [set\_sqlMinMax](DateEditor.md#set_sqlminmax)
- [set\_value](DateEditor.md#set_value)
- [set\_valueAsDate](DateEditor.md#set_valueasdate)
- [create](DateEditor.md#create)
- [dateInputKeyup](DateEditor.md#dateinputkeyup)
- [elementFor](DateEditor.md#elementfor)
- [flatPickrOptions](DateEditor.md#flatpickroptions)
- [flatPickrTrigger](DateEditor.md#flatpickrtrigger)
- [getWidgetName](DateEditor.md#getwidgetname)
- [uiPickerZIndexWorkaround](DateEditor.md#uipickerzindexworkaround)

## Constructors

### constructor

• **new DateEditor**(`input`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/dateeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L15)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### maxValue

• `Private` **maxValue**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L13)

___

### minValue

• `Private` **minValue**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L12)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### yearRange

• **yearRange**: `string`

#### Defined in

[src/ui/editors/dateeditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L159)

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

[src/ui/editors/dateeditor.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L212)

___

### useFlatpickr

▪ `Static` **useFlatpickr**: `boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L74)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L96)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L112)

___

### valueAsDate

• `get` **valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L124)

• `set` **valueAsDate**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L136)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### get\_maxDate

▸ **get_maxDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L187)

___

### get\_maxValue

▸ **get_maxValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L170)

___

### get\_minDate

▸ **get_minDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L179)

___

### get\_minValue

▸ **get_minValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L161)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L140)

___

### get\_sqlMinMax

▸ **get_sqlMinMax**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/dateeditor.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L196)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/dateeditor.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L87)

___

### get\_valueAsDate

▸ `Private` **get_valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L116)

___

### init

▸ **init**(`action?`): [`DateEditor`](DateEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DateEditor`](DateEditor.md)

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[initialize](Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

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

[src/ui/editors/dateeditor.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L192)

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

[src/ui/editors/dateeditor.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L175)

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

[src/ui/editors/dateeditor.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L183)

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

[src/ui/editors/dateeditor.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L166)

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

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/dateeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L144)

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

[src/ui/editors/dateeditor.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L201)

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

[IStringValue](IStringValue.md).[set_value](IStringValue.md#set_value)

#### Defined in

[src/ui/editors/dateeditor.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L100)

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

[src/ui/editors/dateeditor.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L128)

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

[Widget](Widget.md).[create](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

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

[src/ui/editors/dateeditor.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L243)

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

[Widget](Widget.md).[elementFor](Widget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

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

[src/ui/editors/dateeditor.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L76)

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

[src/ui/editors/dateeditor.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L234)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

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

[src/ui/editors/dateeditor.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.ts#L411)
