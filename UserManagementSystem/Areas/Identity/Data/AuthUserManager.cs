using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UserManagementSystem.Data;

namespace UserManagementSystem.Areas.Identity.Data
{
    public class AuthUserManager : UserManager<ApplicationUser> 
    {

        private readonly AuthDbContext _cc;
        public AuthUserManager(
            AuthDbContext context
            ,IUserStore<ApplicationUser> store
            ,IOptions<IdentityOptions> optionsAccessor
            ,IPasswordHasher<ApplicationUser> passwordHasher
            ,IEnumerable<IUserValidator<ApplicationUser>> userValidators
            ,IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators
            ,ILookupNormalizer keyNormalizer
            ,IdentityErrorDescriber errors, IServiceProvider services
            ,ILogger<UserManager<ApplicationUser>> logger) : base(store
                         ,optionsAccessor, passwordHasher, userValidators, passwordValidators
                        ,keyNormalizer, errors, services, logger)
        {
            this._cc = context;
        }

        public async Task<string> GetNameAsync(ClaimsPrincipal principal)
        {
            var user = await GetUserAsync(principal);
            return user.FirstName;
        }

        public async Task<IdentityResult> NewCreateAsync(ApplicationUser user)
        {

            FormattableString sql_query = @$"EXECUTE dbo.ums_insertAccount {user.Id}, {user.UserName}, {user.PasswordHash}, {user.acc_IsActive}, {user.acc_IsChangePassword}, {user.acc_mem_Id}, {user.acc_ro_Id}, {user.acc_ta_Id}";
           
            int rows = await _cc.Database.ExecuteSqlInterpolatedAsync(sql_query);

            if (rows > 0)
            {
                return IdentityResult.Success;
            }
            return IdentityResult.Failed(new IdentityError { Description = $"Could not insert user {user.Email}." });
        }

    }
}
