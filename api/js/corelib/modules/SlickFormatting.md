[@serenity-is/corelib](../README.md) / SlickFormatting

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

▸ **checkBox**(): [`Format`](../README.md#format)

#### Returns

[`Format`](../README.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L662)

___

### date

▸ **date**(`format?`): [`Format`](../README.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](../README.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L643)

___

### dateTime

▸ **dateTime**(`format?`): [`Format`](../README.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](../README.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L653)

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

[src/ui/helpers/slickhelpers.ts:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L599)

___

### getItemId

▸ **getItemId**(`link`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L678)

___

### getItemType

▸ **getItemType**(`link`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L674)

___

### itemLink

▸ **itemLink**\<`TItem`\>(`itemType`, `idField`, `getText`, `cssClass?`, `encode?`): [`Format`](../README.md#format)\<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `idField` | `string` |
| `getText` | [`Format`](../README.md#format)\<`TItem`\> |
| `cssClass?` | (`ctx`: `FormatterContext`\<`TItem`\>) => `string` |
| `encode?` | `boolean` |

#### Returns

[`Format`](../README.md#format)\<`TItem`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L707)

___

### itemLinkText

▸ **itemLinkText**(`itemType`, `id`, `text`, `extraClass`, `encode`): `FormatterResult`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `id` | `any` |
| `text` | `FormatterResult` |
| `extraClass` | `string` |
| `encode` | `boolean` |

#### Returns

`FormatterResult`

#### Defined in

[src/ui/helpers/slickhelpers.ts:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L683)

___

### number

▸ **number**(`format`): [`Format`](../README.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |

#### Returns

[`Format`](../README.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L668)

___

### treeToggle

▸ **treeToggle**(`getView`, `getId`, `formatter`): [`Format`](../README.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getView` | () => [`RemoteView`](../classes/RemoteView.md)\<`any`\> |
| `getId` | (`x`: `any`) => `any` |
| `formatter` | [`Format`](../README.md#format) |

#### Returns

[`Format`](../README.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L603)
