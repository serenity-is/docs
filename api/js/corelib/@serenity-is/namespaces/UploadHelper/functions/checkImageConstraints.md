[@serenity-is/corelib](../../../../README.md) / [UploadHelper](../README.md) / checkImageConstraints

# Function: checkImageConstraints()

> **checkImageConstraints**(`file`, `opt`): `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L92)

Checks an uploaded file against the given image constraints, notifying the
user of any violation.

## Parameters

### file

[`UploadResponse`](../../../../interfaces/UploadResponse.md)

The uploaded file response.

### opt

[`FileUploadConstraints`](../../../../interfaces/FileUploadConstraints.md)

The constraints to check against.

## Returns

`boolean`

True if the file satisfies all constraints, otherwise false.
