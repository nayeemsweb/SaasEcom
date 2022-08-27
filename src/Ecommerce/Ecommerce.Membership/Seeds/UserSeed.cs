namespace Ecommerce.Membership.Seeds
{
    internal static class UserSeed
    {
        internal static ApplicationUser[] Users
        {
            get
            {
                return new ApplicationUser[]
                {
                    new ApplicationUser{ Id= new Guid("0B3B9EDB-ABA7-45A4-B31B-88F1235E0680"), FirstName="Mehedi", LastName="Senior" },
                    new ApplicationUser{ Id= new Guid("21C20E80-103E-47CD-BED1-40AE0ABC637B"), FirstName="Mizanur", LastName="Rahman" },
                    new ApplicationUser{ Id= new Guid("DB6FA3F2-6EE6-4A3B-AC6C-9FB746857A56"), FirstName="Zubayer", LastName="Ahmed" },
                    new ApplicationUser{ Id= new Guid("E7F746E7-8B57-4484-8C7F-195E24BF78E4"), FirstName="Nayeem", LastName="Rahman" },
                    new ApplicationUser{ Id= new Guid("0C096510-CE94-44C9-A870-A625120DEBBB"), FirstName="Shad", LastName="Amin" },
                    new ApplicationUser{ Id= new Guid("97E98FAA-1917-4C69-8BA9-2BA91D9D8E68"), FirstName="Mehedi", LastName="Junior" }
                };
            }
        }
    }
}


