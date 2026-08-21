[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / editor

# ~~Function: editor()~~

> **editor**(): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L122)

Legacy decorator that attaches an [EditorAttribute](../../../../classes/EditorAttribute.md) to an editor class.

## Returns

Class decorator.

> (`target`, `_context?`): `void`

### Parameters

#### target

`Function`

#### \_context?

`any`

### Returns

`void`

## Deprecated

Prefer `static override [Symbol.typeInfo] = editorTypeInfo("...")` instead.
