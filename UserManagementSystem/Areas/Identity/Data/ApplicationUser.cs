using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserManagementSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string FirstName { set; get; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string LastName { set; get; }

        [Column(TypeName = "char(10)")]
        public char acc_IsChangePassword { set; get; }

        [Column(TypeName = "char(10)")]
        public char acc_IsActive { set; get; }

        [Column(TypeName = "int")]
        public int acc_mem_Id { set; get; }

        [Column(TypeName = "int")]
        public int acc_ro_Id { set; get; }

        [Column(TypeName = "int")]
        public int acc_ta_Id { set; get; }

    }
}
