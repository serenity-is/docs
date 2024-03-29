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
| `toolDiv` | `JQuery` |
| `view` | [`RemoteView`](../classes/RemoteView.md)<`any`\> |
| `hint?` | `string` |
| `initial?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L352)

___

### addQuickSearchInput

▸ **addQuickSearchInput**(`toolDiv`, `view`, `fields?`, `onChange?`): [`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `toolDiv` | `JQuery` |
| `view` | [`RemoteView`](../classes/RemoteView.md)<`any`\> |
| `fields?` | [`QuickSearchField`](../interfaces/QuickSearchField.md)[] |
| `onChange?` | () => `void` |

#### Returns

[`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L380)

___

### addQuickSearchInputCustom

▸ **addQuickSearchInputCustom**(`container`, `onSearch`, `fields?`): [`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `onSearch` | (`p1`: `string`, `p2`: `string`, `done`: (`p3`: `boolean`) => `void`) => `void` |
| `fields?` | [`QuickSearchField`](../interfaces/QuickSearchField.md)[] |

#### Returns

[`QuickSearchInput`](../classes/QuickSearchInput.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:427](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L427)

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

[src/ui/helpers/slickhelpers.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L335)

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

[src/ui/helpers/slickhelpers.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L444)

___

### makeOrderableWithUpdateRequest

▸ **makeOrderableWithUpdateRequest**(`grid`, `getId`, `getDisplayOrder`, `service`, `getUpdateRequest`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `getId` | (`p1`: `any`) => `number` |
| `getDisplayOrder` | (`p1`: `any`) => `any` |
| `service` | `string` |
| `getUpdateRequest` | (`p1`: `number`, `p2`: `number`) => [`SaveRequest`](../interfaces/SaveRequest.md)<`any`\> |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L471)
