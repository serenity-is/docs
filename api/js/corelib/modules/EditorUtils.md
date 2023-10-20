[@serenity-is/corelib](../README.md) / EditorUtils

# Namespace: EditorUtils

## Table of contents

### Functions

- [getDisplayText](EditorUtils.md#getdisplaytext)
- [getValue](EditorUtils.md#getvalue)
- [loadValue](EditorUtils.md#loadvalue)
- [saveValue](EditorUtils.md#savevalue)
- [setContainerReadOnly](EditorUtils.md#setcontainerreadonly)
- [setReadOnly](EditorUtils.md#setreadonly)
- [setReadonly](EditorUtils.md#setreadonly-1)
- [setRequired](EditorUtils.md#setrequired)
- [setValue](EditorUtils.md#setvalue)

## Functions

### getDisplayText

▸ **getDisplayText**(`editor`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](../classes/Widget.md)<`any`\> |

#### Returns

`string`

#### Defined in

[src/ui/editors/editorutils.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L6)

___

### getValue

▸ **getValue**(`editor`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](../classes/Widget.md)<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/editors/editorutils.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L35)

___

### loadValue

▸ **loadValue**(`editor`, `item`, `source`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](../classes/Widget.md)<`any`\> |
| `item` | [`PropertyItem`](../interfaces/PropertyItem.md) |
| `source` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L85)

___

### saveValue

▸ **saveValue**(`editor`, `item`, `target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](../classes/Widget.md)<`any`\> |
| `item` | [`PropertyItem`](../interfaces/PropertyItem.md) |
| `target` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L41)

___

### setContainerReadOnly

▸ **setContainerReadOnly**(`container`, `readOnly`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `readOnly` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L204)

___

### setReadOnly

▸ **setReadOnly**(`widget`, `isReadOnly`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](../classes/Widget.md)<`any`\> |
| `isReadOnly` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L173)

___

### setReadonly

▸ **setReadonly**(`elements`, `isReadOnly`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `elements` | `JQuery` |
| `isReadOnly` | `boolean` |

#### Returns

`JQuery`

#### Defined in

[src/ui/editors/editorutils.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L150)

___

### setRequired

▸ **setRequired**(`widget`, `isRequired`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](../classes/Widget.md)<`any`\> |
| `isRequired` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L185)

___

### setValue

▸ **setValue**(`editor`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor` | [`Widget`](../classes/Widget.md)<`any`\> |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/editorutils.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.ts#L80)
