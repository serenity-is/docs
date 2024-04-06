[@serenity-is/corelib](../README.md) / QuickFilter

# Interface: QuickFilter\<TWidget, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](../classes/Widget.md)\<`P`\> |
| `P` | `P` |

## Table of contents

### Properties

- [cssClass](QuickFilter.md#cssclass)
- [displayText](QuickFilter.md#displaytext)
- [element](QuickFilter.md#element)
- [field](QuickFilter.md#field)
- [handler](QuickFilter.md#handler)
- [init](QuickFilter.md#init)
- [loadState](QuickFilter.md#loadstate)
- [options](QuickFilter.md#options)
- [saveState](QuickFilter.md#savestate)
- [separator](QuickFilter.md#separator)
- [title](QuickFilter.md#title)
- [type](QuickFilter.md#type)

## Properties

### cssClass

• `Optional` **cssClass**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L23)

___

### displayText

• `Optional` **displayText**: (`w`: `TWidget`, `label`: `string`) => `string`

#### Type declaration

▸ (`w`, `label`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `w` | `TWidget` |
| `label` | `string` |

##### Returns

`string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L26)

___

### element

• `Optional` **element**: (`e`: [`Fluent`](Fluent.md)\<`HTMLElement`\>) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`Fluent`](Fluent.md)\<`HTMLElement`\> |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L20)

___

### field

• `Optional` **field**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L15)

___

### handler

• `Optional` **handler**: (`h`: [`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\>) => `void`

#### Type declaration

▸ (`h`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `h` | [`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\> |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L17)

___

### init

• `Optional` **init**: (`w`: `TWidget`) => `void`

#### Type declaration

▸ (`w`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `w` | `TWidget` |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L21)

___

### loadState

• `Optional` **loadState**: (`w`: `TWidget`, `state`: `any`) => `void`

#### Type declaration

▸ (`w`, `state`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `w` | `TWidget` |
| `state` | `any` |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L24)

___

### options

• `Optional` **options**: `P` & \{ `class?`: `string` ; `element?`: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`: `HTMLElement`) => `void` ; `id?`: `string`  }

#### Defined in

[src/ui/datagrid/quickfilter.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L19)

___

### saveState

• `Optional` **saveState**: (`w`: `TWidget`) => `any`

#### Type declaration

▸ (`w`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `w` | `TWidget` |

##### Returns

`any`

#### Defined in

[src/ui/datagrid/quickfilter.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L25)

___

### separator

• `Optional` **separator**: `boolean`

#### Defined in

[src/ui/datagrid/quickfilter.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L22)

___

### title

• `Optional` **title**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L18)

___

### type

• `Optional` **type**: `Object`

#### Call signature

• **new type**(`options?`): `TWidget`

##### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | `P` |

##### Returns

`TWidget`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `prototype` | `TWidget` |

#### Defined in

[src/ui/datagrid/quickfilter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L16)
