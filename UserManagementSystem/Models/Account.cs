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
        public int acc_Id { set; get; }

        [ForeignKey("Member")]
        [Required]
        public int acc_mem_Id { set; get; }

        [ForeignKey("Role")]
        [Required]
        public int acc_ro_Id { set; get; }

        [ForeignKey("TypeAccount")]
        [Required]
        public int acc_ta_Id { set; get; }

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
        public char acc_IsChangePassword { set; get; }
    }
}
