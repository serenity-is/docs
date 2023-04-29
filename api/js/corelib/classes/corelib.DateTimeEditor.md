[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / DateTimeEditor

# Class: DateTimeEditor

[corelib](../modules/corelib.md).DateTimeEditor

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

  ↳ **`DateTimeEditor`**

## Implements

- [`IStringValue`](corelib.IStringValue.md)
- [`IReadOnly`](corelib.IReadOnly.md)

## Table of contents

### Constructors

- [constructor](corelib.DateTimeEditor.md#constructor)

### Properties

- [element](corelib.DateTimeEditor.md#element)
- [idPrefix](corelib.DateTimeEditor.md#idprefix)
- [lastSetValue](corelib.DateTimeEditor.md#lastsetvalue)
- [lastSetValueGet](corelib.DateTimeEditor.md#lastsetvalueget)
- [maxValue](corelib.DateTimeEditor.md#maxvalue)
- [minValue](corelib.DateTimeEditor.md#minvalue)
- [options](corelib.DateTimeEditor.md#options)
- [time](corelib.DateTimeEditor.md#time)
- [uniqueName](corelib.DateTimeEditor.md#uniquename)
- [widgetName](corelib.DateTimeEditor.md#widgetname)
- [getTimeOptions](corelib.DateTimeEditor.md#gettimeoptions)

### Accessors

- [value](corelib.DateTimeEditor.md#value)
- [valueAsDate](corelib.DateTimeEditor.md#valueasdate)

### Methods

- [addCssClass](corelib.DateTimeEditor.md#addcssclass)
- [addValidationRule](corelib.DateTimeEditor.md#addvalidationrule)
- [change](corelib.DateTimeEditor.md#change)
- [changeSelect2](corelib.DateTimeEditor.md#changeselect2)
- [destroy](corelib.DateTimeEditor.md#destroy)
- [getCssClass](corelib.DateTimeEditor.md#getcssclass)
- [getDisplayFormat](corelib.DateTimeEditor.md#getdisplayformat)
- [getFlatpickrOptions](corelib.DateTimeEditor.md#getflatpickroptions)
- [getGridField](corelib.DateTimeEditor.md#getgridfield)
- [getInplaceNowText](corelib.DateTimeEditor.md#getinplacenowtext)
- [get\_maxDate](corelib.DateTimeEditor.md#get_maxdate)
- [get\_maxValue](corelib.DateTimeEditor.md#get_maxvalue)
- [get\_minDate](corelib.DateTimeEditor.md#get_mindate)
- [get\_minValue](corelib.DateTimeEditor.md#get_minvalue)
- [get\_readOnly](corelib.DateTimeEditor.md#get_readonly)
- [get\_sqlMinMax](corelib.DateTimeEditor.md#get_sqlminmax)
- [get\_value](corelib.DateTimeEditor.md#get_value)
- [get\_valueAsDate](corelib.DateTimeEditor.md#get_valueasdate)
- [init](corelib.DateTimeEditor.md#init)
- [initialize](corelib.DateTimeEditor.md#initialize)
- [renderContents](corelib.DateTimeEditor.md#rendercontents)
- [set\_maxDate](corelib.DateTimeEditor.md#set_maxdate)
- [set\_maxValue](corelib.DateTimeEditor.md#set_maxvalue)
- [set\_minDate](corelib.DateTimeEditor.md#set_mindate)
- [set\_minValue](corelib.DateTimeEditor.md#set_minvalue)
- [set\_readOnly](corelib.DateTimeEditor.md#set_readonly)
- [set\_sqlMinMax](corelib.DateTimeEditor.md#set_sqlminmax)
- [set\_value](corelib.DateTimeEditor.md#set_value)
- [set\_valueAsDate](corelib.DateTimeEditor.md#set_valueasdate)
- [create](corelib.DateTimeEditor.md#create)
- [elementFor](corelib.DateTimeEditor.md#elementfor)
- [getWidgetName](corelib.DateTimeEditor.md#getwidgetname)
- [roundToMinutes](corelib.DateTimeEditor.md#roundtominutes)

## Constructors

### constructor

• **new DateTimeEditor**(`input`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |
| `opt?` | [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/datetimeeditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;18)

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

### lastSetValue

• `Private` **lastSetValue**: `string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;15)

___

### lastSetValueGet

• `Private` **lastSetValueGet**: `string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;16)

___

### maxValue

• `Private` **maxValue**: `string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;13)

___

### minValue

• `Private` **minValue**: `string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;12)

___

### options

• `Protected` **options**: [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### time

• `Private` **time**: `JQuery`

#### Defined in

[src/ui/editors/datetimeeditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;14)

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

### getTimeOptions

▪ `Static` **getTimeOptions**: (`fromHour`: `number`, `fromMin`: `number`, `toHour`: `number`, `toMin`: `number`, `stepMins`: `number`) => `string`[]

#### Type declaration

▸ (`fromHour`, `fromMin`, `toHour`, `toMin`, `stepMins`): `string`[]

##### Parameters

| Name | Type |
| :------ | :------ |
| `fromHour` | `number` |
| `fromMin` | `number` |
| `toHour` | `number` |
| `toMin` | `number` |
| `stepMins` | `number` |

##### Returns

`string`[]

#### Defined in

[src/ui/editors/datetimeeditor.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;332)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;178)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/datetimeeditor.ts:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;222)

___

### valueAsDate

• `get` **valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/datetimeeditor.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;234)

• `set` **valueAsDate**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Date` |

#### Returns

`void`

#### Defined in

[src/ui/editors/datetimeeditor.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;246)

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

### getDisplayFormat

▸ `Private` **getDisplayFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;218)

___

### getFlatpickrOptions

▸ **getFlatpickrOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/datetimeeditor.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;137)

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

### getInplaceNowText

▸ `Private` **getInplaceNowText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;214)

___

### get\_maxDate

▸ **get_maxDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/datetimeeditor.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;276)

___

### get\_maxValue

▸ **get_maxValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;259)

___

### get\_minDate

▸ **get_minDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/datetimeeditor.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;268)

___

### get\_minValue

▸ **get_minValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/datetimeeditor.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;250)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/datetimeeditor.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;301)

___

### get\_sqlMinMax

▸ **get_sqlMinMax**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/datetimeeditor.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;285)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](corelib.IStringValue.md).[get_value](corelib.IStringValue.md#get_value)

#### Defined in

[src/ui/editors/datetimeeditor.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;153)

___

### get\_valueAsDate

▸ `Private` **get_valueAsDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/datetimeeditor.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;226)

___

### init

▸ **init**(`action?`): [`DateTimeEditor`](corelib.DateTimeEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`DateTimeEditor`](corelib.DateTimeEditor.md)

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

[src/ui/editors/datetimeeditor.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;281)

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

[src/ui/editors/datetimeeditor.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;264)

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

[src/ui/editors/datetimeeditor.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;272)

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

[src/ui/editors/datetimeeditor.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;255)

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

[src/ui/editors/datetimeeditor.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;305)

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

[src/ui/editors/datetimeeditor.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;290)

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

[src/ui/editors/datetimeeditor.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;182)

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

[src/ui/editors/datetimeeditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;238)

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

### roundToMinutes

▸ `Static` **roundToMinutes**(`date`, `minutesStep`): `Date`

#### Parameters

| Name | Type |
| :------ | :------ |
| `date` | `Date` |
| `minutesStep` | `number` |

#### Returns

`Date`

#### Defined in

[src/ui/editors/datetimeeditor.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.ts#line&#x3D;323)
