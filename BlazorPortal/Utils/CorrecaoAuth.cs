using System.Security.Claims;

namespace BlazorPortal.Utils
{

    public static class CorrecaoAuth
    {
        public static void CorrigirRole(ClaimsPrincipal user)
        {
            if (user.Identity.IsAuthenticated)
            {
                user.Claims.ToList().ForEach(c =>
                {
                    if (c.Type == "role")
                    {
                        if (!user.IsInRole(c.Value))
                        {
                            user.AddIdentity(new ClaimsIdentity(new List<Claim>
                            {
                                    new Claim(ClaimTypes.Role, c.Value)
                            }));
                        }

                    }
                });
            }
        }
    }

}
