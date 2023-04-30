[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PasswordEditor

# Class: PasswordEditor

[corelib](../modules/corelib.md).PasswordEditor

## Hierarchy

- [`StringEditor`](corelib.StringEditor.md)

  ↳ **`PasswordEditor`**

## Table of contents

### Constructors

- [constructor](corelib.PasswordEditor.md#constructor)

### Properties

- [element](corelib.PasswordEditor.md#element)
- [idPrefix](corelib.PasswordEditor.md#idprefix)
- [options](corelib.PasswordEditor.md#options)
- [uniqueName](corelib.PasswordEditor.md#uniquename)
- [widgetName](corelib.PasswordEditor.md#widgetname)

### Accessors

- [value](corelib.PasswordEditor.md#value)

### Methods

- [addCssClass](corelib.PasswordEditor.md#addcssclass)
- [addValidationRule](corelib.PasswordEditor.md#addvalidationrule)
- [change](corelib.PasswordEditor.md#change)
- [changeSelect2](corelib.PasswordEditor.md#changeselect2)
- [destroy](corelib.PasswordEditor.md#destroy)
- [getCssClass](corelib.PasswordEditor.md#getcssclass)
- [getGridField](corelib.PasswordEditor.md#getgridfield)
- [get\_value](corelib.PasswordEditor.md#get_value)
- [init](corelib.PasswordEditor.md#init)
- [initialize](corelib.PasswordEditor.md#initialize)
- [renderContents](corelib.PasswordEditor.md#rendercontents)
- [set\_value](corelib.PasswordEditor.md#set_value)
- [create](corelib.PasswordEditor.md#create)
- [elementFor](corelib.PasswordEditor.md#elementfor)
- [getWidgetName](corelib.PasswordEditor.md#getwidgetname)

## Constructors

### constructor

• **new PasswordEditor**(`input`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `JQuery` |

#### Overrides

[StringEditor](corelib.StringEditor.md).[constructor](corelib.StringEditor.md#constructor)

#### Defined in

[src/ui/editors/passwordeditor.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/passwordeditor.ts#L6)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[element](corelib.StringEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[idPrefix](corelib.StringEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[options](corelib.StringEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[uniqueName](corelib.StringEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[widgetName](corelib.StringEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

StringEditor.value

#### Defined in

[src/ui/editors/stringeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L13)

• `set` **value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

StringEditor.value

#### Defined in

[src/ui/editors/stringeditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L21)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[addCssClass](corelib.StringEditor.md#addcssclass)

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

[StringEditor](corelib.StringEditor.md).[addValidationRule](corelib.StringEditor.md#addvalidationrule)

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

[StringEditor](corelib.StringEditor.md).[change](corelib.StringEditor.md#change)

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

[StringEditor](corelib.StringEditor.md).[change](corelib.StringEditor.md#change)

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

[StringEditor](corelib.StringEditor.md).[changeSelect2](corelib.StringEditor.md#changeselect2)

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

[StringEditor](corelib.StringEditor.md).[changeSelect2](corelib.StringEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[destroy](corelib.StringEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[getCssClass](corelib.StringEditor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[getGridField](corelib.StringEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### get\_value

▸ `Protected` **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[get_value](corelib.StringEditor.md#get_value)

#### Defined in

[src/ui/editors/stringeditor.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L17)

___

### init

▸ **init**(`action?`): [`PasswordEditor`](corelib.PasswordEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PasswordEditor`](corelib.PasswordEditor.md)

#### Inherited from

[StringEditor](corelib.StringEditor.md).[init](corelib.StringEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[initialize](corelib.StringEditor.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[renderContents](corelib.StringEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### set\_value

▸ `Protected` **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

[StringEditor](corelib.StringEditor.md).[set_value](corelib.StringEditor.md#set_value)

#### Defined in

[src/ui/editors/stringeditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/stringeditor.ts#L25)

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

[StringEditor](corelib.StringEditor.md).[create](corelib.StringEditor.md#create)

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

[StringEditor](corelib.StringEditor.md).[elementFor](corelib.StringEditor.md#elementfor)

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

[StringEditor](corelib.StringEditor.md).[getWidgetName](corelib.StringEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
