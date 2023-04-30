[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / ServiceOptions

# Interface: ServiceOptions<TResponse\>

[corelib/q](../modules/corelib_q.md).ServiceOptions

## Type parameters

| Name | Type |
| :------ | :------ |
| `TResponse` | extends [`ServiceResponse`](corelib_q.ServiceResponse.md) |

## Hierarchy

- `JQueryAjaxSettings`

  ↳ **`ServiceOptions`**

## Table of contents

### Properties

- [accepts](corelib_q.ServiceOptions.md#accepts)
- [async](corelib_q.ServiceOptions.md#async)
- [blockUI](corelib_q.ServiceOptions.md#blockui)
- [cache](corelib_q.ServiceOptions.md#cache)
- [contentType](corelib_q.ServiceOptions.md#contenttype)
- [contents](corelib_q.ServiceOptions.md#contents)
- [context](corelib_q.ServiceOptions.md#context)
- [converters](corelib_q.ServiceOptions.md#converters)
- [crossDomain](corelib_q.ServiceOptions.md#crossdomain)
- [data](corelib_q.ServiceOptions.md#data)
- [dataType](corelib_q.ServiceOptions.md#datatype)
- [global](corelib_q.ServiceOptions.md#global)
- [headers](corelib_q.ServiceOptions.md#headers)
- [ifModified](corelib_q.ServiceOptions.md#ifmodified)
- [isLocal](corelib_q.ServiceOptions.md#islocal)
- [jsonp](corelib_q.ServiceOptions.md#jsonp)
- [jsonpCallback](corelib_q.ServiceOptions.md#jsonpcallback)
- [method](corelib_q.ServiceOptions.md#method)
- [mimeType](corelib_q.ServiceOptions.md#mimetype)
- [password](corelib_q.ServiceOptions.md#password)
- [processData](corelib_q.ServiceOptions.md#processdata)
- [request](corelib_q.ServiceOptions.md#request)
- [scriptCharset](corelib_q.ServiceOptions.md#scriptcharset)
- [service](corelib_q.ServiceOptions.md#service)
- [statusCode](corelib_q.ServiceOptions.md#statuscode)
- [timeout](corelib_q.ServiceOptions.md#timeout)
- [traditional](corelib_q.ServiceOptions.md#traditional)
- [type](corelib_q.ServiceOptions.md#type)
- [url](corelib_q.ServiceOptions.md#url)
- [username](corelib_q.ServiceOptions.md#username)
- [xhr](corelib_q.ServiceOptions.md#xhr)
- [xhrFields](corelib_q.ServiceOptions.md#xhrfields)

### Methods

- [beforeSend](corelib_q.ServiceOptions.md#beforesend)
- [complete](corelib_q.ServiceOptions.md#complete)
- [dataFilter](corelib_q.ServiceOptions.md#datafilter)
- [error](corelib_q.ServiceOptions.md#error)
- [onCleanup](corelib_q.ServiceOptions.md#oncleanup)
- [onError](corelib_q.ServiceOptions.md#onerror)
- [onSuccess](corelib_q.ServiceOptions.md#onsuccess)
- [success](corelib_q.ServiceOptions.md#success)

## Properties

### accepts

• `Optional` **accepts**: `any`

The content type sent in the request header that tells the server what kind of response it will accept in return. If the accepts setting needs modification, it is recommended to do so once in the $.ajaxSetup() method.

#### Inherited from

JQueryAjaxSettings.accepts

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:50

___

### async

• `Optional` **async**: `boolean`

By default, all requests are sent asynchronously (i.e. this is set to true by default). If you need synchronous requests, set this option to false. Cross-domain requests and dataType: "jsonp" requests do not support synchronous operation. Note that synchronous requests may temporarily lock the browser, disabling any actions while the request is active. As of jQuery 1.8, the use of async: false with jqXHR ($.Deferred) is deprecated; you must use the success/error/complete callback options instead of the corresponding methods of the jqXHR object such as jqXHR.done() or the deprecated jqXHR.success().

#### Inherited from

JQueryAjaxSettings.async

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:54

___

### blockUI

• `Optional` **blockUI**: `boolean`

#### Defined in

[src/q/servicetypes.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L19)

___

### cache

• `Optional` **cache**: `boolean`

If set to false, it will force requested pages not to be cached by the browser. Note: Setting cache to false will only work correctly with HEAD and GET requests. It works by appending "_={timestamp}" to the GET parameters. The parameter is not needed for other types of requests, except in IE8 when a POST is made to a URL that has already been requested by a GET.

#### Inherited from

JQueryAjaxSettings.cache

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:62

___

### contentType

• `Optional` **contentType**: `any`

When sending data to the server, use this content type. Default is "application/x-www-form-urlencoded; charset=UTF-8", which is fine for most cases. If you explicitly pass in a content-type to $.ajax(), then it is always sent to the server (even if no data is sent). The W3C XMLHttpRequest specification dictates that the charset is always UTF-8; specifying another charset will not force the browser to change the encoding.

#### Inherited from

JQueryAjaxSettings.contentType

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:76

___

### contents

• `Optional` **contents**: `Object`

An object of string/regular-expression pairs that determine how jQuery will parse the response, given its content type. (version added: 1.5)

#### Index signature

▪ [key: `string`]: `any`

#### Inherited from

JQueryAjaxSettings.contents

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:70

___

### context

• `Optional` **context**: `any`

This object will be made the context of all Ajax-related callbacks. By default, the context is an object that represents the ajax settings used in the call ($.ajaxSettings merged with the settings passed to $.ajax).

#### Inherited from

JQueryAjaxSettings.context

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:80

___

### converters

• `Optional` **converters**: `Object`

An object containing dataType-to-dataType converters. Each converter's value is a function that returns the transformed value of the response. (version added: 1.5)

#### Index signature

▪ [key: `string`]: `any`

#### Inherited from

JQueryAjaxSettings.converters

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:84

___

### crossDomain

• `Optional` **crossDomain**: `boolean`

If you wish to force a crossDomain request (such as JSONP) on the same domain, set the value of crossDomain to true. This allows, for example, server-side redirection to another domain. (version added: 1.5)

#### Inherited from

JQueryAjaxSettings.crossDomain

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:88

___

### data

• `Optional` **data**: `any`

Data to be sent to the server. It is converted to a query string, if not already a string. It's appended to the url for GET-requests. See processData option to prevent this automatic processing. Object must be key-value pairs. If value is an Array, jQuery serializes multiple values with same key based on the value of the traditional setting (described below).

#### Inherited from

JQueryAjaxSettings.data

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:92

___

### dataType

• `Optional` **dataType**: `string`

The type of data that you're expecting back from the server. If none is specified, jQuery will try to infer it based on the MIME type of the response (an XML MIME type will yield XML, in 1.4 JSON will yield a JavaScript object, in 1.4 script will execute the script, and anything else will be returned as a string).

#### Inherited from

JQueryAjaxSettings.dataType

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:100

___

### global

• `Optional` **global**: `boolean`

Whether to trigger global Ajax event handlers for this request. The default is true. Set to false to prevent the global handlers like ajaxStart or ajaxStop from being triggered. This can be used to control various Ajax Events.

#### Inherited from

JQueryAjaxSettings.global

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:108

___

### headers

• `Optional` **headers**: `Object`

An object of additional header key/value pairs to send along with requests using the XMLHttpRequest transport. The header X-Requested-With: XMLHttpRequest is always added, but its default XMLHttpRequest value can be changed here. Values in the headers setting can also be overwritten from within the beforeSend function. (version added: 1.5)

#### Index signature

▪ [key: `string`]: `any`

#### Inherited from

JQueryAjaxSettings.headers

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:112

___

### ifModified

• `Optional` **ifModified**: `boolean`

Allow the request to be successful only if the response has changed since the last request. This is done by checking the Last-Modified header. Default value is false, ignoring the header. In jQuery 1.4 this technique also checks the 'etag' specified by the server to catch unmodified data.

#### Inherited from

JQueryAjaxSettings.ifModified

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:116

___

### isLocal

• `Optional` **isLocal**: `boolean`

Allow the current environment to be recognized as "local," (e.g. the filesystem), even if jQuery does not recognize it as such by default. The following protocols are currently recognized as local: file, *-extension, and widget. If the isLocal setting needs modification, it is recommended to do so once in the $.ajaxSetup() method. (version added: 1.5.1)

#### Inherited from

JQueryAjaxSettings.isLocal

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:120

___

### jsonp

• `Optional` **jsonp**: `any`

Override the callback function name in a jsonp request. This value will be used instead of 'callback' in the 'callback=?' part of the query string in the url. So {jsonp:'onJSONPLoad'} would result in 'onJSONPLoad=?' passed to the server. As of jQuery 1.5, setting the jsonp option to false prevents jQuery from adding the "?callback" string to the URL or attempting to use "=?" for transformation. In this case, you should also explicitly set the jsonpCallback setting. For example, { jsonp: false, jsonpCallback: "callbackName" }

#### Inherited from

JQueryAjaxSettings.jsonp

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:124

___

### jsonpCallback

• `Optional` **jsonpCallback**: `any`

Specify the callback function name for a JSONP request. This value will be used instead of the random name automatically generated by jQuery. It is preferable to let jQuery generate a unique name as it'll make it easier to manage the requests and provide callbacks and error handling. You may want to specify the callback when you want to enable better browser caching of GET requests. As of jQuery 1.5, you can also use a function for this setting, in which case the value of jsonpCallback is set to the return value of that function.

#### Inherited from

JQueryAjaxSettings.jsonpCallback

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:128

___

### method

• `Optional` **method**: `string`

The HTTP method to use for the request (e.g. "POST", "GET", "PUT"). (version added: 1.9.0)

#### Inherited from

JQueryAjaxSettings.method

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:132

___

### mimeType

• `Optional` **mimeType**: `string`

A MIME type to override the XHR MIME type. (version added: 1.5.1)

#### Inherited from

JQueryAjaxSettings.mimeType

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:136

___

### password

• `Optional` **password**: `string`

A password to be used with XMLHttpRequest in response to an HTTP access authentication request.

#### Inherited from

JQueryAjaxSettings.password

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:140

___

### processData

• `Optional` **processData**: `boolean`

By default, data passed in to the data option as an object (technically, anything other than a string) will be processed and transformed into a query string, fitting to the default content-type "application/x-www-form-urlencoded". If you want to send a DOMDocument, or other non-processed data, set this option to false.

#### Inherited from

JQueryAjaxSettings.processData

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:144

___

### request

• `Optional` **request**: `any`

#### Defined in

[src/q/servicetypes.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L17)

___

### scriptCharset

• `Optional` **scriptCharset**: `string`

Only applies when the "script" transport is used (e.g., cross-domain requests with "jsonp" or "script" dataType and "GET" type). Sets the charset attribute on the script tag used in the request. Used when the character set on the local page is not the same as the one on the remote script.

#### Inherited from

JQueryAjaxSettings.scriptCharset

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:148

___

### service

• `Optional` **service**: `string`

#### Defined in

[src/q/servicetypes.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L18)

___

### statusCode

• `Optional` **statusCode**: `Object`

An object of numeric HTTP codes and functions to be called when the response has the corresponding code. f the request is successful, the status code functions take the same parameters as the success callback; if it results in an error (including 3xx redirect), they take the same parameters as the error callback. (version added: 1.5)

#### Index signature

▪ [key: `string`]: `any`

#### Inherited from

JQueryAjaxSettings.statusCode

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:152

___

### timeout

• `Optional` **timeout**: `number`

Set a timeout (in milliseconds) for the request. This will override any global timeout set with $.ajaxSetup(). The timeout period starts at the point the $.ajax call is made; if several other requests are in progress and the browser has no connections available, it is possible for a request to time out before it can be sent. In jQuery 1.4.x and below, the XMLHttpRequest object will be in an invalid state if the request times out; accessing any object members may throw an exception. In Firefox 3.0+ only, script and JSONP requests cannot be cancelled by a timeout; the script will run even if it arrives after the timeout period.

#### Inherited from

JQueryAjaxSettings.timeout

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:160

___

### traditional

• `Optional` **traditional**: `boolean`

Set this to true if you wish to use the traditional style of parameter serialization.

#### Inherited from

JQueryAjaxSettings.traditional

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:164

___

### type

• `Optional` **type**: `string`

The type of request to make ("POST" or "GET"), default is "GET". Note: Other HTTP request methods, such as PUT and DELETE, can also be used here, but they are not supported by all browsers.

#### Inherited from

JQueryAjaxSettings.type

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:168

___

### url

• `Optional` **url**: `string`

A string containing the URL to which the request is sent.

#### Inherited from

JQueryAjaxSettings.url

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:172

___

### username

• `Optional` **username**: `string`

A username to be used with XMLHttpRequest in response to an HTTP access authentication request.

#### Inherited from

JQueryAjaxSettings.username

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:176

___

### xhr

• `Optional` **xhr**: `any`

Callback for creating the XMLHttpRequest object. Defaults to the ActiveXObject when available (IE), the XMLHttpRequest otherwise. Override to provide your own implementation for XMLHttpRequest or enhancements to the factory.

#### Inherited from

JQueryAjaxSettings.xhr

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:180

___

### xhrFields

• `Optional` **xhrFields**: `Object`

An object of fieldName-fieldValue pairs to set on the native XHR object. For example, you can use it to set withCredentials to true for cross-domain requests if needed. In jQuery 1.5, the withCredentials property was not propagated to the native XHR and thus CORS requests requiring it would ignore this flag. For this reason, we recommend using jQuery 1.5.1+ should you require the use of it. (version added: 1.5.1)

#### Index signature

▪ [key: `string`]: `any`

#### Inherited from

JQueryAjaxSettings.xhrFields

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:184

## Methods

### beforeSend

▸ `Optional` **beforeSend**(`jqXHR`, `settings`): `any`

A pre-request callback function that can be used to modify the jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object before it is sent. Use this to set custom headers, etc. The jqXHR and settings objects are passed as arguments. This is an Ajax Event. Returning false in the beforeSend function will cancel the request. As of jQuery 1.5, the beforeSend option will be called regardless of the type of request.

#### Parameters

| Name | Type |
| :------ | :------ |
| `jqXHR` | `JQueryXHR` |
| `settings` | `JQueryAjaxSettings` |

#### Returns

`any`

#### Inherited from

JQueryAjaxSettings.beforeSend

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:58

___

### complete

▸ `Optional` **complete**(`jqXHR`, `textStatus`): `any`

A function to be called when the request finishes (after success and error callbacks are executed). The function gets passed two arguments: The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the request ("success", "notmodified", "error", "timeout", "abort", or "parsererror"). As of jQuery 1.5, the complete setting can accept an array of functions. Each function will be called in turn. This is an Ajax Event.

#### Parameters

| Name | Type |
| :------ | :------ |
| `jqXHR` | `JQueryXHR` |
| `textStatus` | `string` |

#### Returns

`any`

#### Inherited from

JQueryAjaxSettings.complete

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:66

___

### dataFilter

▸ `Optional` **dataFilter**(`data`, `ty`): `any`

A function to be used to handle the raw response data of XMLHttpRequest.This is a pre-filtering function to sanitize the response. You should return the sanitized data. The function accepts two arguments: The raw data returned from the server and the 'dataType' parameter.

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `any` |
| `ty` | `any` |

#### Returns

`any`

#### Inherited from

JQueryAjaxSettings.dataFilter

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:96

___

### error

▸ `Optional` **error**(`jqXHR`, `textStatus`, `errorThrown`): `any`

A function to be called if the request fails. The function receives three arguments: The jqXHR (in jQuery 1.4.x, XMLHttpRequest) object, a string describing the type of error that occurred and an optional exception object, if one occurred. Possible values for the second argument (besides null) are "timeout", "error", "abort", and "parsererror". When an HTTP error occurs, errorThrown receives the textual portion of the HTTP status, such as "Not Found" or "Internal Server Error." As of jQuery 1.5, the error setting can accept an array of functions. Each function will be called in turn. Note: This handler is not called for cross-domain script and cross-domain JSONP requests. This is an Ajax Event.

#### Parameters

| Name | Type |
| :------ | :------ |
| `jqXHR` | `JQueryXHR` |
| `textStatus` | `string` |
| `errorThrown` | `string` |

#### Returns

`any`

#### Inherited from

JQueryAjaxSettings.error

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:104

___

### onCleanup

▸ `Optional` **onCleanup**(): `void`

#### Returns

`void`

#### Defined in

[src/q/servicetypes.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L22)

___

### onError

▸ `Optional` **onError**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `TResponse` |

#### Returns

`void`

#### Defined in

[src/q/servicetypes.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L20)

___

### onSuccess

▸ `Optional` **onSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | `TResponse` |

#### Returns

`void`

#### Defined in

[src/q/servicetypes.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L21)

___

### success

▸ `Optional` **success**(`data`, `textStatus`, `jqXHR`): `any`

A function to be called if the request succeeds. The function gets passed three arguments: The data returned from the server, formatted according to the dataType parameter; a string describing the status; and the jqXHR (in jQuery 1.4.x, XMLHttpRequest) object. As of jQuery 1.5, the success setting can accept an array of functions. Each function will be called in turn. This is an Ajax Event.

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `any` |
| `textStatus` | `string` |
| `jqXHR` | `JQueryXHR` |

#### Returns

`any`

#### Inherited from

JQueryAjaxSettings.success

#### Defined in

../../node_modules/.pnpm/@types+jquery@2.0.48/node_modules/@types/jquery/index.d.ts:156
