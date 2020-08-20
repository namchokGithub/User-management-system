using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

/*
 * Name: Account.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class Account
    {
        [Key]
        [Required]
        public int acc_Id { set; get; }

        [Required]
        [Display(Name = "Username")]
        public string acc_User { set; get; }

        [AllowNull]
        [Required]
        [Display(Name = "Password")]
        public string acc_password { set; get; }

        [Required]
        [Display(Name = "Check Active")]
        public char acc_IsActive { set; get; }

        [Required]
        [Display(Name = "Check Change Password")]
        public char acc_IsChangePassword { set; get; }

        [Required]
        [Display(Name = "Name")]
        public string acc_name { set; get; }

        [Required]
        [Display(Name = "Role Name")]
        public string ro_name { set; get; }

        [Required]
        [Display(Name = "Type Account")]
        public string ta_name { set; get; }

        [Required]
        [Display(Name = "Password Hash")]
        public string acc_salt { set; get; }
    }
}