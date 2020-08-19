using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementSystem.Areas.Identity.Data
{
    public class AuthSignInManager : SignInManager<ApplicationUser>
    {
        public AuthSignInManager(
            UserManager<ApplicationUser> userManager
            , IHttpContextAccessor contextAccessor
            , IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory
            , IOptions<IdentityOptions> optionsAccessor
            , ILogger<SignInManager<ApplicationUser>> logger
            , IAuthenticationSchemeProvider schemes
            , IUserConfirmation<ApplicationUser> confirmation)
            : base (userManager
                    , contextAccessor
                    , claimsFactory
                    , optionsAccessor
                    , logger
                    , schemes
                    , confirmation)
        { }
        public override async Task<SignInResult> PasswordSignInAsync
                (string userName, string password,
                bool isPersistent, bool lockoutOnFailure)
        {

            Console.WriteLine(userName);

            // ERROR : Not match database
            // Maybe create SQL Query
            var user = await UserManager.FindByNameAsync(userName);

            if (user == null)
            {
                return SignInResult.Failed;
            }else
            {
                return SignInResult.Success;
            }
        }
    }
}
