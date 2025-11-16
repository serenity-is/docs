[corelib](../README.md) / Config

# Variable: Config

> `const` **Config**: `object`

Defined in: [src/base/config.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L1)

## Type Declaration

### applicationPath

> **applicationPath**: `string` = `'/'`

This is the root path of your application. If your application resides under http://localhost/mysite/,
your root path is "/mysite/". This variable is automatically initialized by reading from a <link> element
with ID "ApplicationPath" from current page, which is usually located in your _LayoutHead.cshtml file

### defaultReturnUrl()

> **defaultReturnUrl**: (`purpose?`) => `string`

Gets a default return URL for the application. This is used when a return URL is not specified

#### Parameters

##### purpose?

`string`

Optional purpose for the return URL, for example "login" or "logout"

#### Returns

`string`

### emailAllowOnlyAscii

> **emailAllowOnlyAscii**: `boolean` = `true`

Email validation by default only allows ASCII characters. Set this to true if you want to allow unicode.

### lazyTypeLoader()

> **lazyTypeLoader**: (`typeKey`, `kind`) => `any`

This is an optional callback that is used to load types lazily when they are not found in the
type registry. This is useful when a type is not available in currently loaded scripts 
(e.g. chunks / entry modules) but is available via some other means (e.g. a separate script file).
The method may return a type or a promise that resolves to a type. If either returns null, 
the type is considered to be not found.
The method is called with the type key and an optional kind parameter, which is used to distinguish
between different kinds of types (e.g. "editor" or "dialog" or "enum") usually based on calling type registry.

#### Parameters

##### typeKey

`string`

##### kind

`string`

#### Returns

`any`

### notLoggedInHandler

> **notLoggedInHandler**: `Function`

This is an optional method for handling when user is not logged in. If a users session is expired 
and when a NotAuthorized response is received from a service call, Serenity will call this handler, so
you may intercept it and notify user about this situation and ask if she wants to login again...

### rootNamespaces

> **rootNamespaces**: `string`[]

This is the list of root namespaces that may be searched for types. For example, if you specify an editor type
of "MyEditor", first a class with name "MyEditor" will be searched, if not found, search will be followed by
"Serenity.MyEditor" and "MyApp.MyEditor" if you added "MyApp" to the list of root namespaces.

You should usually add your application root namespace to this list in ScriptInit(ialization).ts file.
