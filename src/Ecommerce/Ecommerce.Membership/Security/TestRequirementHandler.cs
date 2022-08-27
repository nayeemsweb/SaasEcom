namespace Ecommerce.Membership.Security
{
    public class TestRequirementHandler :
          AuthorizationHandler<TestRequirement>
    {
        protected override Task HandleRequirementAsync(
               AuthorizationHandlerContext context,
               TestRequirement requirement)
        {
            if (context.User.HasClaim(x => x.Type == "ViewTestPage" && x.Value == "true"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
