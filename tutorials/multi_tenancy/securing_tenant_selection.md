# Securing Tenant Selection

Now signout and login with user *tenant2*.

When you open *User Management* page, you'll see that user can see and edit *admin* user, in addition to his own *tenant2* user. He can even see and edit his tenant in user dialog.

![Tenant2 Logged In](img/tenant2_logged_in.png)

This is not what we wanted.

Let's prevent him seeing users of other tenants.

We first need to load and cache user tenant information in UserDefinition.

Open *UserDefinition.cs* under *Multitenancy.Web/ Modules/ Administration/ User/ Authentication* and add a *TenantId* property.


