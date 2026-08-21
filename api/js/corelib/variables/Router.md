[@serenity-is/corelib](../README.md) / Router

# ~~Variable: Router~~

> `const` **Router**: [`IClassicRouter`](../interfaces/IClassicRouter.md)

Defined in: [src/compat/router.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L488)

Singleton instance of the legacy hash router.
Compat shim for the global `Q.Router` / `Serenity.Router`. Initialized at module load and wired to `hashchange` and dialog events.

## Deprecated

Prefer not to use hash-based dialog routing in new code. Kept for legacy pages that rely on `Router.resolve()` / `Router.navigate()`.
