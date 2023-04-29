[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / CascadedWidgetLink

# Class: CascadedWidgetLink<TParent\>

[corelib](../modules/corelib.md).CascadedWidgetLink

## Type parameters

| Name | Type |
| :------ | :------ |
| `TParent` | extends [`Widget`](corelib.Widget.md)<`any`\> |

## Table of contents

### Constructors

- [constructor](corelib.CascadedWidgetLink.md#constructor)

### Properties

- [\_parentID](corelib.CascadedWidgetLink.md#_parentid)
- [parentChange](corelib.CascadedWidgetLink.md#parentchange)
- [parentType](corelib.CascadedWidgetLink.md#parenttype)
- [widget](corelib.CascadedWidgetLink.md#widget)

### Methods

- [bind](corelib.CascadedWidgetLink.md#bind)
- [get\_parentID](corelib.CascadedWidgetLink.md#get_parentid)
- [set\_parentID](corelib.CascadedWidgetLink.md#set_parentid)
- [unbind](corelib.CascadedWidgetLink.md#unbind)

## Constructors

### constructor

• **new CascadedWidgetLink**<`TParent`\>(`parentType`, `widget`, `parentChange`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TParent` | extends [`Widget`](corelib.Widget.md)<`any`, `TParent`\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `parentType` | (...`args`: `any`[]) => `TParent` |
| `widget` | [`Widget`](corelib.Widget.md)<`any`\> |
| `parentChange` | (`p1`: `TParent`) => `void` |

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;8)

## Properties

### \_parentID

• `Private` **\_parentID**: `string`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;19)

___

### parentChange

• `Private` **parentChange**: (`p1`: `TParent`) => `void`

#### Type declaration

▸ (`p1`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `TParent` |

##### Returns

`void`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;10)

___

### parentType

• `Private` **parentType**: (...`args`: `any`[]) => `TParent`

#### Type declaration

• **new parentType**(`...args`)

##### Parameters

| Name | Type |
| :------ | :------ |
| `...args` | `any`[] |

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;8)

___

### widget

• `Private` **widget**: [`Widget`](corelib.Widget.md)<`any`\>

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;9)

## Methods

### bind

▸ **bind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;21)

___

### get\_parentID

▸ **get_parentID**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;57)

___

### set\_parentID

▸ **set_parentID**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;61)

___

### unbind

▸ **unbind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#line&#x3D;42)
