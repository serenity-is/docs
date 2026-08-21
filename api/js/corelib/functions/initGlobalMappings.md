[@serenity-is/corelib](../README.md) / initGlobalMappings

# Function: initGlobalMappings()

> **initGlobalMappings**(`options`): `void`

Defined in: [src/compat/init-global-mappings.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L63)

Installs legacy global namespace mappings (`Serenity`, `Slick`, `Q`, and vendor globals) for
compatibility with feature packages that consume globals via `tsbuild`'s `importAsGlobals`.

## Parameters

### options

[`InitGlobalMappingsOptions`](../interfaces/InitGlobalMappingsOptions.md)

Bag of package exports / vendor modules to expose on the global object.

## Returns

`void`

## Remarks

- When `corelib` is provided it becomes `globals.Serenity` (or is merged via live getters if `Serenity` already exists).
- `sleekgrid` populates `globals.Slick` and is merged into `Serenity`; `Aggregators`/`AggregateFormatting` sub-objects and `RemoteView` are synced between `Slick` and `Serenity`.
- `extensions`/`proextensions`/`domwise` are merged into `Serenity` (extensions also under `Serenity.Extensions`).
- `bootstrap`/`mousetrap`/`sortable`/`nprogress`/`glightbox`/`flatpickr` unwrap `.default` when needed and are assigned to `bootstrap`/`Mousetrap`/`Sortable`/`NProgress`/`GLightbox`/`flatpickr` respectively.
- Missing or already-present targets are merged via getter/setter proxies (`copyProps`) so later assignments stay in sync.

## Example

```ts
initGlobalMappings({ corelib: SerenityCore, sleekgrid: SlickGrid, globals: window });
```
