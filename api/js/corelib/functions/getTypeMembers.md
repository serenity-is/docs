[corelib](../README.md) / getTypeMembers

# Function: getTypeMembers()

> **getTypeMembers**(`type`, `memberKinds?`): [`TypeMember`](../interfaces/TypeMember.md)[]

Defined in: [src/compat/system-compat.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L97)

Gets type members including inherited ones. Optionally filters by member kinds.

## Parameters

### type

`any`

The type to get members for.

### memberKinds?

[`TypeMemberKind`](../enumerations/TypeMemberKind.md)

Optional bitmask of TypeMemberKind to filter by.

## Returns

[`TypeMember`](../interfaces/TypeMember.md)[]

An array of TypeMember objects.

## Remarks

The members should be registered using addTypeMember function or option decorator.
