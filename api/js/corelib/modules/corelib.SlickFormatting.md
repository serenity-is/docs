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

▸ **checkBox**(): [`Format`](corelib_slick.md#format)

#### Returns

[`Format`](corelib_slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;636)

___

### date

▸ **date**(`format?`): [`Format`](corelib_slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](corelib_slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:617](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;617)

___

### dateTime

▸ **dateTime**(`format?`): [`Format`](corelib_slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format?` | `string` |

#### Returns

[`Format`](corelib_slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;627)

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

[src/ui/helpers/slickhelpers.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;588)

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

[src/ui/helpers/slickhelpers.ts:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;652)

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

[src/ui/helpers/slickhelpers.ts:648](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;648)

___

### itemLink

▸ **itemLink**<`TItem`\>(`itemType`, `idField`, `getText`, `cssClass?`, `encode?`): [`Format`](corelib_slick.md#format)<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemType` | `string` |
| `idField` | `string` |
| `getText` | [`Format`](corelib_slick.md#format)<`TItem`\> |
| `cssClass?` | [`Format`](corelib_slick.md#format)<`TItem`\> |
| `encode?` | `boolean` |

#### Returns

[`Format`](corelib_slick.md#format)<`TItem`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;668)

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

[src/ui/helpers/slickhelpers.ts:657](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;657)

___

### number

▸ **number**(`format`): [`Format`](corelib_slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `format` | `string` |

#### Returns

[`Format`](corelib_slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:642](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;642)

___

### treeToggle

▸ **treeToggle**(`getView`, `getId`, `formatter`): [`Format`](corelib_slick.md#format)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getView` | () => [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`any`\> |
| `getId` | (`x`: `any`) => `any` |
| `formatter` | [`Format`](corelib_slick.md#format)<`any`\> |

#### Returns

[`Format`](corelib_slick.md#format)

#### Defined in

[src/ui/helpers/slickhelpers.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;592)
