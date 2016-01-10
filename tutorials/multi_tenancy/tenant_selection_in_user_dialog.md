# Tenant Selection in User Dialog

We added a *TenantId* field to *Users* table, but it's not defined in UserRow, and not visible in user dialog.

This field, should only be seen and edited by *admin* user. Other users, even if we give them access to users page to manage their tenant users, shouldn't be able to see or change this information.

Let's first add it to *UserRow*:

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class UserRow : LoggingRow, IIdRow, INameRow
    {
        //...
        [DisplayName("Last Directory Update"), Insertable(false), Updatable(false)]
        public DateTime? LastDirectoryUpdate
        {
            get { return Fields.LastDirectoryUpdate[this]; }
            set { Fields.LastDirectoryUpdate[this] = value; }
        }

        [DisplayName("Tenant"), ForeignKey("Tenants", "TenantId"), LeftJoin("tnt")]
        [LookupEditor(typeof(TenantRow))]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Tenant"), Expression("tnt.TenantName")]
        public String TenantName
        {
            get { return Fields.TenantName[this]; }
            set { Fields.TenantName[this] = value; }
        }

        //...
        public class RowFields : LoggingRowFields
        {
            //...
            public readonly DateTimeField LastDirectoryUpdate;
            public readonly Int32Field TenantId;
            public readonly StringField TenantName;
            //...
        }
    }
}

```

