[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / element

# ~~Function: element()~~

> **element**(`value`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L134)

Legacy decorator that attaches an [ElementAttribute](../../../../classes/ElementAttribute.md) specifying the root element tag.

## Parameters

### value

`string`

Tag name for the widget root element (e.g. `"div"`).

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

Prefer `static override [Symbol.typeInfo] = classTypeInfo("...", [new ElementAttribute(...)])` or widget `createDefaultElement` override instead.
