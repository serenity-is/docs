[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / SlickFormatting

# Namespace: SlickFormatting

## Table of contents

### Functions

- [checkBox](SlickFormatting.md#checkbox)
- [date](SlickFormatting.md#date)
- [dateTime](SlickFormatting.md#datetime)
- [getEnumText](SlickFormatting.md#getenumtext)
- [getItemId](SlickFormatting.md#getitemid)
- [getItemType](SlickFormatting.md#getitemtype)
- [itemLink](SlickFormatting.md#itemlink)
- [itemLinkText](SlickFormatting.md#itemlinktext)
- [number](SlickFormatting.md#number)
- [treeToggle](SlickFormatting.md#treetoggle)

## Functions

### checkBox

▸ **checkBox**(): [`Format`](../modules.md#format)

#### Returns

[`Format`](../modules.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L638)

___

### date

▸ **date**(`format?`): [`Format`](../modules.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](../modules.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:619](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L619)

___

### dateTime

▸ **dateTime**(`format?`): [`Format`](../modules.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](../modules.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:629](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L629)

___

### getEnumText

▸ **getEnumText**(`enumKey`, `name`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enumKey` | `string` |
| `name` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:590](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L590)

___

### getItemId

▸ **getItemId**(`link`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `JQuery` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L654)

___

### getItemType

▸ **getItemType**(`link`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `JQuery` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L650)

___

### itemLink

▸ **itemLink**<`TItem`\>(`itemType`, `idField`, `getText`, `cssClass?`, `encode?`): [`Format`](../modules.md#format)<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `idField` | `string` |
| `getText` | [`Format`](../modules.md#format)<`TItem`\> |
| `cssClass?` | [`Format`](../modules.md#format)<`TItem`\> |
| `encode?` | `boolean` |

#### Returns

[`Format`](../modules.md#format)<`TItem`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L670)

___

### itemLinkText

▸ **itemLinkText**(`itemType`, `id`, `text`, `extraClass`, `encode`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `id` | `any` |
| `text` | `any` |
| `extraClass` | `string` |
| `encode` | `boolean` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L659)

___

### number

▸ **number**(`format`): [`Format`](../modules.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |

#### Returns

[`Format`](../modules.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L644)

___

### treeToggle

▸ **treeToggle**(`getView`, `getId`, `formatter`): [`Format`](../modules.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getView` | () => [`RemoteView`](../classes/RemoteView.md)<`any`\> |
| `getId` | (`x`: `any`) => `any` |
| `formatter` | [`Format`](../modules.md#format)<`any`\> |

#### Returns

[`Format`](../modules.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L594)
