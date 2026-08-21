[@serenity-is/corelib](../README.md) / TypeMember

# Interface: TypeMember

Defined in: [src/compat/system-compat.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L105)

Describes a single type member collected via the legacy [addTypeMember](../functions/addTypeMember.md) / option-decorator mechanism.
Preserved for backward compatibility; prefer Symbol.metadata / `Symbol.typeInfo` where possible.

## Properties

### attr?

> `optional` **attr**: `any`[]

Defined in: [src/compat/system-compat.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L111)

Optional attribute/metadata objects attached to the member.

***

### getter?

> `optional` **getter**: `string`

Defined in: [src/compat/system-compat.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L113)

Optional getter method name for property members.

***

### kind

> **kind**: [`TypeMemberKind`](../enumerations/TypeMemberKind.md)

Defined in: [src/compat/system-compat.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L109)

Bitmask indicating the member kind (field vs. property).

***

### name

> **name**: `string`

Defined in: [src/compat/system-compat.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L107)

Member name (field or property name).

***

### setter?

> `optional` **setter**: `string`

Defined in: [src/compat/system-compat.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L115)

Optional setter method name for property members.
