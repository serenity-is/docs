# User and Role Management

Serene has user, role and rights management built in.

> This feature is not embedded in Serenity itself. It is just a sample, so you can always implement and use your user management of choice. We'll take a look at how in following chapters.

Open Administration / Roles to create roles *Administrators* and *Translators*. 

Click *New Role* and  and type *Administrators*, then click Save.

Repeat it for *Translators*.

![Create Admin Role](img/create_admin_role.jpg)

Then click role *Administrators* to open edit form, and click *Edit Permissons* button to modify its permissions. Check all boxes to grant every permisson to this role, then click *OK*.

![Admin Permissions](img/admin_permissions.jpg)

Repeat same steps for the *Translations* role but this time grant only the *Administration: Languages and Translations* permission.

Navigate to *Administration / User Management* page to add more users.

Click *admin* user to edit its details.

![Edit Admin User](img/edit_admin_user.jpg)

Here you can change admin details like username, display name, email.

You can also change its password (which is *serenity* by default) by typing into *Password* and *Confirm Password* inputs and clicking *Update*.

> You can also delete it but this would make your site unusable as you wouldn't be able to login.

*admin* is a special user in Serene, as it has all permissions even if none is explicitly granted to him.

Lets create another one and grant roles / permissions to it.

Close this dialog, click new user and type *translator* as username. Fill in other fields as you'd like, then click *Update*.

![Create Translator User](img/create_translator_user.jpg)

> You may have noticed there is a *Apply Changes* button with a black disk icon without title, next to *Save*. Unlike *Save*, when you use it, the form stays open, so you can see how your record looks like after saving, also you can edit roles and permissions before closing the form.

Now click *Translator* role to open its edit form and click *Edit Roles*. Grant him *Translators* role and click *OK*.

![Edit Translator Roles](img/edit_translator_roles.jpg)

> When you grant a role to a user, he gets all permissions granted to the role automatically. By clicking Edit Permissions and you can also grant extra permissions explicitly. But you can't revoke a role permission from a user, unless you remove him from the role.





