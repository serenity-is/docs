# Preventing Edits To Users From Other Tenants

Remember that user *tenant2* could update his *TenantId* with some service call, and we had to secure it server side.

Similar to this, even if he can't see users from other tenants by default, he can actually retrieve and update them.

Time to hack again.

Open Chrome console and type this:

```js
```