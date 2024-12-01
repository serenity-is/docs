[@serenity-is/corelib](../README.md) / Uploader

# Class: Uploader

## Constructors

### new Uploader()

> **new Uploader**(`opt`): [`Uploader`](Uploader.md)

#### Parameters

##### opt

[`UploaderOptions`](../interfaces/UploaderOptions.md)

#### Returns

[`Uploader`](Uploader.md)

#### Defined in

[src/base/uploader.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L86)

## Properties

### defaults

> `static` **defaults**: `Partial`\<[`UploaderOptions`](../interfaces/UploaderOptions.md)\>

#### Defined in

[src/base/uploader.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L142)

***

### requestDefaults

> `static` **requestDefaults**: `Partial`\<[`UploaderRequest`](../interfaces/UploaderRequest.md)\>

#### Defined in

[src/base/uploader.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L148)

## Methods

### uploadBatch()

> **uploadBatch**(`batch`, `request`?): `Promise`\<`void`\>

#### Parameters

##### batch

[`UploaderBatch`](../interfaces/UploaderBatch.md)

##### request?

[`UploaderRequest`](../interfaces/UploaderRequest.md)

#### Returns

`Promise`\<`void`\>

#### Defined in

[src/base/uploader.ts:343](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L343)

***

### errorHandler()

> `static` **errorHandler**(`data`): `void`

#### Parameters

##### data

[`UploaderErrorData`](../interfaces/UploaderErrorData.md)

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L460)
