[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / GridUtils

# Namespace: GridUtils

[corelib](corelib.md).GridUtils

## Table of contents

### Functions

- [addIncludeDeletedToggle](corelib.GridUtils.md#addincludedeletedtoggle)
- [addQuickSearchInput](corelib.GridUtils.md#addquicksearchinput)
- [addQuickSearchInputCustom](corelib.GridUtils.md#addquicksearchinputcustom)
- [addToggleButton](corelib.GridUtils.md#addtogglebutton)
- [makeOrderable](corelib.GridUtils.md#makeorderable)
- [makeOrderableWithUpdateRequest](corelib.GridUtils.md#makeorderablewithupdaterequest)

## Functions

### addIncludeDeletedToggle

▸ **addIncludeDeletedToggle**(`toolDiv`, `view`, `hint?`, `initial?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `JQuery` |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`any`\> |
| `hint?` | `string` |
| `initial?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;352)

___

### addQuickSearchInput

▸ **addQuickSearchInput**(`toolDiv`, `view`, `fields?`, `onChange?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `JQuery` |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`any`\> |
| `fields?` | [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[] |
| `onChange?` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;380)

___

### addQuickSearchInputCustom

▸ **addQuickSearchInputCustom**(`container`, `onSearch`, `fields?`): [`QuickSearchInput`](../classes/corelib.QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `onSearch` | (`p1`: `string`, `p2`: `string`, `done`: (`p3`: `boolean`) => `void`) => `void` |
| `fields?` | [`QuickSearchField`](../interfaces/corelib.QuickSearchField.md)[] |

#### Returns

[`QuickSearchInput`](../classes/corelib.QuickSearchInput.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:425](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;425)

___

### addToggleButton

▸ **addToggleButton**(`toolDiv`, `cssClass`, `callback`, `hint`, `initial?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `JQuery` |
| `cssClass` | `string` |
| `callback` | (`p1`: `boolean`) => `void` |
| `hint` | `string` |
| `initial?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;335)

___

### makeOrderable

▸ **makeOrderable**(`grid`, `handleMove`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | `Grid`<`any`\> |
| `handleMove` | (`p1`: `any`, `p2`: `number`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;442)

___

### makeOrderableWithUpdateRequest

▸ **makeOrderableWithUpdateRequest**(`grid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/corelib.IDataGrid.md) |
| `getId` | (`p1`: `any`) => `number` |
| `getDisplayOrder` | (`p1`: `any`) => `any` |
| `service` | `string` |
| `getUpdateRequest` | (`p1`: `number`, `p2`: `number`) => [`SaveRequest`](../interfaces/corelib_q.SaveRequest.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;469)
