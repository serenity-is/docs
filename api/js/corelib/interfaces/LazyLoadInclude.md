[@serenity-is/corelib](../README.md) / LazyLoadInclude

# Interface: LazyLoadInclude\<TGroup\>

Defined in: [src/base/system.ts:823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L823)

Marker interface used to include a registered class in the lazy type loader during code generation
(sergen servertypings / clienttypes), so that it is loaded when it is first requested by its key from a type
registry, without a side-effect import. Useful for types that are only referenced by their keys, like the
editors of dynamically generated property items. Only the classes directly implementing it are included.
Each type gets its own chunk, unless a group name is passed, like `LazyLoadInclude<"Viewer">`, in which case
the types of a project with the same group are loaded together, resulting in fewer chunks.
This empty interface exists for typing only.

## Type Parameters

### TGroup

`TGroup` *extends* `string` = `""`
