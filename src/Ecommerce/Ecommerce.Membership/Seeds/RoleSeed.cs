namespace Ecommerce.Membership.Seeds
{
    internal static class RoleSeed
    {
        internal static Role[] Roles
        {
            get
            {
                return new Role[]
                {
                    new Role{ Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp =  DateTime.Now.Ticks.ToString()  },
                    new Role{ Id = Guid.NewGuid(), Name = "Customer", NormalizedName = "CUSTOMER", ConcurrencyStamp =  DateTime.Now.Ticks.ToString()  }
                };
            }
        }
    }
}
