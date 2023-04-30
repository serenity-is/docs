[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PropertyGrid

# Class: PropertyGrid

[corelib](../modules/corelib.md).PropertyGrid

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)\>

  ↳ **`PropertyGrid`**

## Table of contents

### Constructors

- [constructor](corelib.PropertyGrid.md#constructor)

### Properties

- [editors](corelib.PropertyGrid.md#editors)
- [element](corelib.PropertyGrid.md#element)
- [idPrefix](corelib.PropertyGrid.md#idprefix)
- [items](corelib.PropertyGrid.md#items)
- [options](corelib.PropertyGrid.md#options)
- [uniqueName](corelib.PropertyGrid.md#uniquename)
- [widgetName](corelib.PropertyGrid.md#widgetname)

### Accessors

- [value](corelib.PropertyGrid.md#value)

### Methods

- [addCssClass](corelib.PropertyGrid.md#addcssclass)
- [addValidationRule](corelib.PropertyGrid.md#addvalidationrule)
- [canModifyItem](corelib.PropertyGrid.md#canmodifyitem)
- [categoryLinkClick](corelib.PropertyGrid.md#categorylinkclick)
- [change](corelib.PropertyGrid.md#change)
- [changeSelect2](corelib.PropertyGrid.md#changeselect2)
- [createCategoryDiv](corelib.PropertyGrid.md#createcategorydiv)
- [createCategoryLinks](corelib.PropertyGrid.md#createcategorylinks)
- [createField](corelib.PropertyGrid.md#createfield)
- [createItems](corelib.PropertyGrid.md#createitems)
- [destroy](corelib.PropertyGrid.md#destroy)
- [determineText](corelib.PropertyGrid.md#determinetext)
- [enumerateItems](corelib.PropertyGrid.md#enumerateitems)
- [getCategoryOrder](corelib.PropertyGrid.md#getcategoryorder)
- [getCssClass](corelib.PropertyGrid.md#getcssclass)
- [getGridField](corelib.PropertyGrid.md#getgridfield)
- [get\_editors](corelib.PropertyGrid.md#get_editors)
- [get\_idPrefix](corelib.PropertyGrid.md#get_idprefix)
- [get\_items](corelib.PropertyGrid.md#get_items)
- [get\_mode](corelib.PropertyGrid.md#get_mode)
- [init](corelib.PropertyGrid.md#init)
- [initialize](corelib.PropertyGrid.md#initialize)
- [load](corelib.PropertyGrid.md#load)
- [renderContents](corelib.PropertyGrid.md#rendercontents)
- [save](corelib.PropertyGrid.md#save)
- [set\_mode](corelib.PropertyGrid.md#set_mode)
- [updateInterface](corelib.PropertyGrid.md#updateinterface)
- [create](corelib.PropertyGrid.md#create)
- [elementFor](corelib.PropertyGrid.md#elementfor)
- [getWidgetName](corelib.PropertyGrid.md#getwidgetname)
- [loadEditorValue](corelib.PropertyGrid.md#loadeditorvalue)
- [saveEditorValue](corelib.PropertyGrid.md#saveeditorvalue)
- [setMaxLength](corelib.PropertyGrid.md#setmaxlength)
- [setReadOnly](corelib.PropertyGrid.md#setreadonly)
- [setReadonly](corelib.PropertyGrid.md#setreadonly-1)
- [setRequired](corelib.PropertyGrid.md#setrequired)

## Constructors

### constructor

• **new PropertyGrid**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/widgets/propertygrid.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L15)

## Properties

### editors

• `Private` **editors**: [`Widget`](corelib.Widget.md)<`any`\>[]

#### Defined in

[src/ui/widgets/propertygrid.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L11)

___

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Overrides

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/propertygrid.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L13)

___

### items

• `Private` **items**: [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertygrid.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L12)

___

### options

• `Protected` **options**: [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

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

• `get` **value**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L570)

• `set` **value**(`val`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `val` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L574)

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

### canModifyItem

▸ `Private` **canModifyItem**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/propertygrid.ts:580](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L580)

___

### categoryLinkClick

▸ `Private` **categoryLinkClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L198)

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

### createCategoryDiv

▸ `Private` **createCategoryDiv**(`categoriesDiv`, `categoryIndexes`, `category`, `collapsed`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `categoriesDiv` | `JQuery` |
| `categoryIndexes` | `Object` |
| `category` | `string` |
| `collapsed` | `boolean` |

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/propertygrid.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L167)

___

### createCategoryLinks

▸ `Private` **createCategoryLinks**(`container`, `items`): `Record`<`string`, `number`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `items` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[] |

#### Returns

`Record`<`string`, `number`\>

#### Defined in

[src/ui/widgets/propertygrid.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L413)

___

### createField

▸ `Private` **createField**(`container`, `item`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `item` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L255)

___

### createItems

▸ `Private` **createItems**(`container`, `items`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `items` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[] |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L113)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/propertygrid.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L100)

___

### determineText

▸ `Private` **determineText**(`text`, `getKey`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `text` | `string` |
| `getKey` | (`s`: `string`) => `string` |

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertygrid.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L233)

___

### enumerateItems

▸ **enumerateItems**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`p1`: [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md), `p2`: [`Widget`](corelib.Widget.md)<`any`\>) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L628)

___

### getCategoryOrder

▸ `Private` **getCategoryOrder**(`items`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[] |

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L382)

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

### get\_editors

▸ **get_editors**(): [`Widget`](corelib.Widget.md)<`any`\>[]

#### Returns

[`Widget`](corelib.Widget.md)<`any`\>[]

#### Defined in

[src/ui/widgets/propertygrid.ts:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L483)

___

### get\_idPrefix

▸ **get_idPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertygrid.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L491)

___

### get\_items

▸ **get_items**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertygrid.ts:487](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L487)

___

### get\_mode

▸ **get_mode**(): [`PropertyGridMode`](../enums/corelib.PropertyGridMode.md)

#### Returns

[`PropertyGridMode`](../enums/corelib.PropertyGridMode.md)

#### Defined in

[src/ui/widgets/propertygrid.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L495)

___

### init

▸ **init**(`action?`): [`PropertyGrid`](corelib.PropertyGrid.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PropertyGrid`](corelib.PropertyGrid.md)

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

### load

▸ **load**(`source`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `source` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L544)

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

### save

▸ **save**(`target?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target?` | `any` |

#### Returns

`any`

#### Defined in

[src/ui/widgets/propertygrid.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L557)

___

### set\_mode

▸ **set_mode**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`PropertyGridMode`](../enums/corelib.PropertyGridMode.md) |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:499](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L499)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:606](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L606)

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

___

### loadEditorValue

▸ `Static` **loadEditorValue**(`editor`, `item`, `source`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](corelib.Widget.md)<`any`\> |
| `item` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |
| `source` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L507)

___

### saveEditorValue

▸ `Static` **saveEditorValue**(`editor`, `item`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](corelib.Widget.md)<`any`\> |
| `item` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L512)

___

### setMaxLength

▸ `Static` `Private` **setMaxLength**(`widget`, `maxLength`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](corelib.Widget.md)<`any`\> |
| `maxLength` | `number` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:533](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L533)

___

### setReadOnly

▸ `Static` `Private` **setReadOnly**(`widget`, `isReadOnly`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](corelib.Widget.md)<`any`\> |
| `isReadOnly` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L519)

___

### setReadonly

▸ `Static` `Private` **setReadonly**(`elements`, `isReadOnly`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `elements` | `JQuery` |
| `isReadOnly` | `boolean` |

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/propertygrid.ts:524](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L524)

___

### setRequired

▸ `Static` `Private` **setRequired**(`widget`, `isRequired`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](corelib.Widget.md)<`any`\> |
| `isRequired` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertygrid.ts:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.ts#L529)
