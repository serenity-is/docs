[@serenity-is/corelib](../README.md) / CascadedWidgetLink

# Class: CascadedWidgetLink<TParent\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TParent` | extends [`Widget`](Widget.md)<`any`\> |

## Table of contents

### Constructors

- [constructor](CascadedWidgetLink.md#constructor)

### Properties

- [\_parentID](CascadedWidgetLink.md#_parentid)
- [parentChange](CascadedWidgetLink.md#parentchange)
- [parentType](CascadedWidgetLink.md#parenttype)
- [widget](CascadedWidgetLink.md#widget)

### Methods

- [bind](CascadedWidgetLink.md#bind)
- [get\_parentID](CascadedWidgetLink.md#get_parentid)
- [set\_parentID](CascadedWidgetLink.md#set_parentid)
- [unbind](CascadedWidgetLink.md#unbind)

## Constructors

### constructor

• **new CascadedWidgetLink**<`TParent`\>(`parentType`, `widget`, `parentChange`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TParent` | extends [`Widget`](Widget.md)<`any`, `TParent`\> |

#### Parameters

| Name | Type |
| :------ | :------ |
| `parentType` | (...`args`: `any`[]) => `TParent` |
| `widget` | [`Widget`](Widget.md)<`any`\> |
| `parentChange` | (`p1`: `TParent`) => `void` |

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L8)

## Properties

### \_parentID

• `Private` **\_parentID**: `string`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L19)

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

[src/ui/editors/cascadedwidgetlink.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L10)

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

[src/ui/editors/cascadedwidgetlink.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L8)

___

### widget

• `Private` **widget**: [`Widget`](Widget.md)<`any`\>

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L9)

## Methods

### bind

▸ **bind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L21)

___

### get\_parentID

▸ **get_parentID**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L57)

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

[src/ui/editors/cascadedwidgetlink.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L61)

___

### unbind

▸ **unbind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L42)
