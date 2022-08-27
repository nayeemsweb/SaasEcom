namespace Ecommerce.Membership.Security
{
    public class ApiRequirementHandler :
          AuthorizationHandler<ApiRequirement>
    {
        protected override Task HandleRequirementAsync(
               AuthorizationHandlerContext context,
               ApiRequirement requirement)
        {
            var claim = context.User.FindFirst("ViewTestPage");
            if (claim != null && bool.Parse(claim.Value))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
