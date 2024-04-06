[@serenity-is/corelib](../README.md) / GridUtils

# Namespace: GridUtils

## Table of contents

### Functions

- [addIncludeDeletedToggle](GridUtils.md#addincludedeletedtoggle)
- [addQuickSearchInput](GridUtils.md#addquicksearchinput)
- [addQuickSearchInputCustom](GridUtils.md#addquicksearchinputcustom)
- [addToggleButton](GridUtils.md#addtogglebutton)
- [makeOrderable](GridUtils.md#makeorderable)
- [makeOrderableWithUpdateRequest](GridUtils.md#makeorderablewithupdaterequest)

## Functions

### addIncludeDeletedToggle

▸ **addIncludeDeletedToggle**(`toolDiv`, `view`, `hint?`, `initial?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `view` | [`RemoteView`](../classes/RemoteView.md)\<`any`\> |
| `hint?` | `string` |
| `initial?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L359)

___

### addQuickSearchInput

▸ **addQuickSearchInput**(`toolDiv`, `view`, `fields?`, `onChange?`): [`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `view` | [`RemoteView`](../classes/RemoteView.md)\<`any`\> |
| `fields?` | [`QuickSearchField`](../interfaces/QuickSearchField.md)[] |
| `onChange?` | () => `void` |

#### Returns

[`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L388)

___

### addQuickSearchInputCustom

▸ **addQuickSearchInputCustom**(`container`, `onSearch`, `fields?`): [`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `onSearch` | (`p1`: `string`, `p2`: `string`, `done`: (`p3`: `boolean`) => `void`) => `void` |
| `fields?` | [`QuickSearchField`](../interfaces/QuickSearchField.md)[] |

#### Returns

[`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:435](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L435)

___

### addToggleButton

▸ **addToggleButton**(`toolDiv`, `cssClass`, `callback`, `hint`, `initial?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `cssClass` | `string` |
| `callback` | (`p1`: `boolean`) => `void` |
| `hint` | `string` |
| `initial?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L336)

___

### makeOrderable

▸ **makeOrderable**(`grid`, `handleMove`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | `Grid`\<`any`\> |
| `handleMove` | (`rows`: `number`[], `insertBefore`: `number`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:457](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L457)

___

### makeOrderableWithUpdateRequest

▸ **makeOrderableWithUpdateRequest**\<`TItem`, `TId`\>(`grid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |
| `TId` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `getId` | (`item`: `TItem`) => `TId` |
| `getDisplayOrder` | (`item`: `TItem`) => `any` |
| `service` | `string` |
| `getUpdateRequest` | (`id`: `TId`, `order`: `number`) => [`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\> |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:484](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L484)
