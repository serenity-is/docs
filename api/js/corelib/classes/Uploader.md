[@serenity-is/corelib](../README.md) / Uploader

# Class: Uploader

Defined in: [src/base/uploader.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L81)

## Constructors

### Constructor

> **new Uploader**(`opt`): `Uploader`

Defined in: [src/base/uploader.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L86)

#### Parameters

##### opt

[`UploaderOptions`](../interfaces/UploaderOptions.md)

#### Returns

`Uploader`

## Properties

### defaults

> `static` **defaults**: `Partial`\<[`UploaderOptions`](../interfaces/UploaderOptions.md)\>

Defined in: [src/base/uploader.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L142)

***

### requestDefaults

> `static` **requestDefaults**: `Partial`\<[`UploaderRequest`](../interfaces/UploaderRequest.md)\>

Defined in: [src/base/uploader.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L148)

## Methods

### isMultiple()

> **isMultiple**(): `boolean`

Defined in: [src/base/uploader.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L152)

#### Returns

`boolean`

***

### uploadBatch()

> **uploadBatch**(`batch`, `request?`): `Promise`\<`void`\>

Defined in: [src/base/uploader.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L347)

#### Parameters

##### batch

[`UploaderBatch`](../interfaces/UploaderBatch.md)

##### request?

[`UploaderRequest`](../interfaces/UploaderRequest.md)

#### Returns

`Promise`\<`void`\>

***

### errorHandler()

> `static` **errorHandler**(`data`): `void`

Defined in: [src/base/uploader.ts:464](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L464)

#### Parameters

##### data

[`UploaderErrorData`](../interfaces/UploaderErrorData.md)

#### Returns

`void`
