namespace Ecommerce.Membership.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? StoreId { get; set; }

        // public List<Review> Reviews { get; set; }

    }
}
