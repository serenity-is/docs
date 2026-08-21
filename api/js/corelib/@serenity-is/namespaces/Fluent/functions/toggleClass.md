[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / toggleClass

# Function: toggleClass()

> **toggleClass**(`element`, `value`, `add?`): `void`

Defined in: [src/base/fluent.ts:755](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L755)

Toggles one or more classes on the element.

## Parameters

### element

`Element`

Target element.

### value

Class name(s) to toggle. Falsy entries are ignored.

`string` | `boolean` | (`string` \| `boolean`)[]

### add?

`boolean`

When `true`, forces addition; when `false`, forces removal; when omitted, each class is toggled.

## Returns

`void`

`void`.
