[@serenity-is/corelib](../README.md) / InitGlobalMappingsOptions

# Interface: InitGlobalMappingsOptions

Defined in: [src/compat/init-global-mappings.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L23)

Options bag for [initGlobalMappings](../functions/initGlobalMappings.md).

## Properties

### bootstrap?

> `optional` **bootstrap**: `any`

Defined in: [src/compat/init-global-mappings.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L37)

Bootstrap module (unwraps `.default` if needed) to expose as `bootstrap`.

***

### corelib?

> `optional` **corelib**: `any`

Defined in: [src/compat/init-global-mappings.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L27)

Core library exports to expose as `Serenity` / `Q` globals.

***

### domwise?

> `optional` **domwise**: `any`

Defined in: [src/compat/init-global-mappings.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L29)

`domwise` package exports to merge into `Serenity`.

***

### extensions?

> `optional` **extensions**: `any`

Defined in: [src/compat/init-global-mappings.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L33)

`extensions` package exports to merge into `Serenity` / `Serenity.Extensions`.

***

### flatpickr?

> `optional` **flatpickr**: `any`

Defined in: [src/compat/init-global-mappings.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L39)

flatpickr module to expose as `flatpickr` (also calls [initFlatpickrLocale](../functions/initFlatpickrLocale.md)).

***

### glightbox?

> `optional` **glightbox**: `any`

Defined in: [src/compat/init-global-mappings.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L41)

GLightbox module to expose as `GLightbox`.

***

### globals?

> `optional` **globals**: `any`

Defined in: [src/compat/init-global-mappings.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L25)

Global object to install mappings on; defaults to [getGlobalObject](../functions/getGlobalObject.md).

***

### mousetrap?

> `optional` **mousetrap**: `any`

Defined in: [src/compat/init-global-mappings.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L43)

Mousetrap module to expose as `Mousetrap`.

***

### nprogress?

> `optional` **nprogress**: `any`

Defined in: [src/compat/init-global-mappings.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L45)

NProgress module to expose as `NProgress` (also calls [initNProgress](../functions/initNProgress.md)).

***

### proextensions?

> `optional` **proextensions**: `any`

Defined in: [src/compat/init-global-mappings.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L35)

`proextensions` package exports to merge into `Serenity`.

***

### sleekgrid?

> `optional` **sleekgrid**: `any`

Defined in: [src/compat/init-global-mappings.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L31)

`sleekgrid` package exports to expose as `Slick` and merge into `Serenity`.

***

### sortable?

> `optional` **sortable**: `any`

Defined in: [src/compat/init-global-mappings.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/init-global-mappings.ts#L47)

SortableJS module to expose as `Sortable`.
