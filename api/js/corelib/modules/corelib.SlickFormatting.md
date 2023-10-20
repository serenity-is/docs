[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / SlickFormatting

# Namespace: SlickFormatting

[corelib](corelib.md).SlickFormatting

## Table of contents

### Functions

- [checkBox](corelib.SlickFormatting.md#checkbox)
- [date](corelib.SlickFormatting.md#date)
- [dateTime](corelib.SlickFormatting.md#datetime)
- [getEnumText](corelib.SlickFormatting.md#getenumtext)
- [getItemId](corelib.SlickFormatting.md#getitemid)
- [getItemType](corelib.SlickFormatting.md#getitemtype)
- [itemLink](corelib.SlickFormatting.md#itemlink)
- [itemLinkText](corelib.SlickFormatting.md#itemlinktext)
- [number](corelib.SlickFormatting.md#number)
- [treeToggle](corelib.SlickFormatting.md#treetoggle)

## Functions

### checkBox

▸ **checkBox**(): [`Format`](slick.md#format)

#### Returns

[`Format`](slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L638)

___

### date

▸ **date**(`format?`): [`Format`](slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:619](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L619)

___

### dateTime

▸ **dateTime**(`format?`): [`Format`](slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](slick.md#format)

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

▸ **itemLink**<`TItem`\>(`itemType`, `idField`, `getText`, `cssClass?`, `encode?`): [`Format`](slick.md#format)<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `idField` | `string` |
| `getText` | [`Format`](slick.md#format)<`TItem`\> |
| `cssClass?` | [`Format`](slick.md#format)<`TItem`\> |
| `encode?` | `boolean` |

#### Returns

[`Format`](slick.md#format)<`TItem`\>

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

▸ **number**(`format`): [`Format`](slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |

#### Returns

[`Format`](slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:644](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L644)

___

### treeToggle

▸ **treeToggle**(`getView`, `getId`, `formatter`): [`Format`](slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getView` | () => [`RemoteView`](../classes/slick.RemoteView.md)<`any`\> |
| `getId` | (`x`: `any`) => `any` |
| `formatter` | [`Format`](slick.md#format)<`any`\> |

#### Returns

[`Format`](slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:594](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L594)
