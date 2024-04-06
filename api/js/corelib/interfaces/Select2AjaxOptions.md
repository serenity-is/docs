[@serenity-is/corelib](../README.md) / Select2AjaxOptions

# Interface: Select2AjaxOptions

## Hierarchy

- `RequestInit`

  ↳ **`Select2AjaxOptions`**

## Table of contents

### Properties

- [data](Select2AjaxOptions.md#data)
- [headers](Select2AjaxOptions.md#headers)
- [params](Select2AjaxOptions.md#params)
- [quietMillis](Select2AjaxOptions.md#quietmillis)
- [results](Select2AjaxOptions.md#results)
- [url](Select2AjaxOptions.md#url)

### Methods

- [onError](Select2AjaxOptions.md#onerror)
- [onSuccess](Select2AjaxOptions.md#onsuccess)

## Properties

### data

• `Optional` **data**: (`p1`: `string`, `p2`: `number`, `p3`: `any`) => `any`

#### Type declaration

▸ (`p1`, `p2`, `p3`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |
| `p2` | `number` |
| `p3` | `any` |

##### Returns

`any`

#### Defined in

[src/ui/editors/select2.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L40)

___

### headers

• `Optional` **headers**: `Record`\<`string`, `string`\>

#### Overrides

RequestInit.headers

#### Defined in

[src/ui/editors/select2.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L37)

___

### params

• `Optional` **params**: `any`

#### Defined in

[src/ui/editors/select2.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L42)

___

### quietMillis

• `Optional` **quietMillis**: `number`

#### Defined in

[src/ui/editors/select2.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L39)

___

### results

• `Optional` **results**: (`p1`: `any`, `p2`: `number`, `p3`: `any`) => `any`

#### Type declaration

▸ (`p1`, `p2`, `p3`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `number` |
| `p3` | `any` |

##### Returns

`any`

#### Defined in

[src/ui/editors/select2.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L41)

___

### url

• `Optional` **url**: `string` \| (`term`: `string`, `page`: `number`, `context`: `any`) => `string`

#### Defined in

[src/ui/editors/select2.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L38)

## Methods

### onError

▸ **onError**(`response`, `info?`): `boolean` \| `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `any` |
| `info?` | `any` |

#### Returns

`boolean` \| `void`

#### Defined in

[src/ui/editors/select2.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L43)

___

### onSuccess

▸ **onSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L44)
