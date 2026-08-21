[@serenity-is/corelib](../README.md) / TypeMemberKind

# Enumeration: TypeMemberKind

Defined in: [src/compat/system-compat.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L122)

Bitmask discriminating type-member kinds stored in [TypeMember.kind](../interfaces/TypeMember.md#kind).
Values are powers of two so they can be combined and filtered with bitwise operators.

## Enumeration Members

### field

> **field**: `4`

Defined in: [src/compat/system-compat.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L124)

A plain field member.

***

### property

> **property**: `16`

Defined in: [src/compat/system-compat.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L126)

A property member (with optional getter/setter).
